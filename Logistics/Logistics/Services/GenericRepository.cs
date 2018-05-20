using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Logistics.Entities;
using Logistics.Infrastructure;
using Logistics.Models;
using Microsoft.EntityFrameworkCore;

namespace Logistics.Services
{
    public class GenericRepository<TEntity, TDto, TCreationDto> : IGenericRepository<TEntity, TDto, TCreationDto>
        where TDto : BaseDto where TCreationDto : class where TEntity : BaseEntity
    {
        private readonly DatabaseContext _context;
        private DbSet<TEntity> _entities;

        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            IQueryable<TEntity> query = _entities;

            var items = await query
                .ProjectTo<TDto>()
                .ToArrayAsync();

            return items;
        }

        public async Task<TDto> GetSingleAsync(Guid id)
        {
            IQueryable<TEntity> query = _entities;

            var items = await query
                .ProjectTo<TDto>()
                .ToArrayAsync();

            var entity = items.FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                throw new InvalidOperationException("Can not find object with this Id.");
            }
            return Mapper.Map<TDto>(entity);
        }

        public async Task<Guid> CreateAsync(TCreationDto creationDto)
        {
            var entity = Mapper.Map<TEntity>(creationDto);
            entity.Id = Guid.NewGuid();

            _entities.Add(entity);
            var created = await _context.SaveChangesAsync();
            if (created < 1)
            {
                throw new InvalidOperationException("Database context could not create data.");
            }

            return entity.Id;
        }

        public async Task<Guid> EditAsync(Guid id, TCreationDto creationDto)
        {
            var entity = await _entities.SingleOrDefaultAsync(r => r.Id == id);
            if (entity == null)
            {
                throw new InvalidOperationException("Can not find object with this Id.");
            }
            foreach (PropertyInfo propertyInfo in creationDto.GetType().GetProperties())
            {
                string key = propertyInfo.Name;
                if (key != "Id" && entity.GetType().GetProperty(key) != null)
                {
                    entity.GetType().GetProperty(key).SetValue(entity, propertyInfo.GetValue(creationDto, null));
                }
            }

            _entities.Update(entity);
            var updated = await _context.SaveChangesAsync();
            if (updated < 1)
            {
                throw new InvalidOperationException("Database context could not update data.");
            }
            return id;
        }

        public async Task<Guid> DeleteAsync(Guid id)
        {
            var entity = await _entities.SingleOrDefaultAsync(r => r.Id == id);
            if (entity == null)
            {
                throw new InvalidOperationException("Can not find object with this Id.");
            }

            _entities.Remove(entity);
            var deleted = await _context.SaveChangesAsync();
            if (deleted < 1)
            {
                throw new InvalidOperationException("Database context could not delete data.");
            }
            return id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logistics.Services
{
    public interface IGenericRepository<TEntity, TDto, TCreationDto>
    {
        Task<IEnumerable<TDto>> GetAllAsync();

        Task<TDto> GetSingleAsync(Guid id);
      
        Task<Guid> CreateAsync(TCreationDto creationDto);

        Task<Guid> EditAsync(Guid id, TCreationDto creationDto);

        Task<Guid> DeleteAsync(Guid id);
    }
}

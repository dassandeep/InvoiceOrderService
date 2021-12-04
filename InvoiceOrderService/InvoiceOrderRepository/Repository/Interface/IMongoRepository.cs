using InvoiceOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Repository.Interface
{
    public interface IMongoRepository<TEntity>
        where TEntity : MongoEntity
    {
       
        Task<TEntity?> GetAsync(string id, CancellationToken cancellationToken = default);
        Task<ICollection<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
        Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task AddManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(string id, CancellationToken cancellationToken = default);
        Task<TEntity> ReplaceAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}

using InvoiceOrderEntity.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Repository.Interface
{
    public interface IMongoContext
    {
        Task<IMongoCollection<TEntity>> GetCollectionAsync<TEntity>(CancellationToken cancellationToken = default)
        where TEntity : MongoEntity;

        Task DropCollectionAsync<TEntity>(CancellationToken cancellationToken = default);
    }
}

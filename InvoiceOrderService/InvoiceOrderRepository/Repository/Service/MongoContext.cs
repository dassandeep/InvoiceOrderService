using InvoiceOrderEntity.Models;
using InvoiceOrderRepository.Configuration;
using InvoiceOrderRepository.Repository.Interface;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Repository.Service
{
    public class MongoContext : IMongoContext, IDisposable
    {
        private readonly SemaphoreSlim _semaphore;
        private readonly IOptions<MongoRepositoryOptions> _options;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMongoDatabase _database;
        private readonly ConcurrentBag<Type> _bootstrappedCollections = new ConcurrentBag<Type>();
        private bool _disposed;

        public MongoContext(IOptions<MongoRepositoryOptions> options, IServiceProvider serviceProvider)
        {
            _options = options;
            _serviceProvider = serviceProvider;

            var connectionString = options.Value.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString), "Must provide a mongo connection string");
            }

            var url = new MongoUrl(connectionString);
            if (string.IsNullOrEmpty(url.DatabaseName))
            {
                throw new ArgumentNullException(nameof(connectionString), "Must provide a database name with the mongo connection string");
            }

            _semaphore = new SemaphoreSlim(1, 1);
            _database = new MongoClient(MongoClientSettings.FromUrl(url)).GetDatabase(url.DatabaseName);
        }
        public Task DropCollectionAsync<TEntity>(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IMongoCollection<TEntity>> GetCollectionAsync<TEntity>(CancellationToken cancellationToken = default) where TEntity : MongoEntity
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }
            _disposed = true;

            _semaphore.Dispose();
        }
    }
}

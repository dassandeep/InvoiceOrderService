using InvoiceOrderEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Configuration
{
    public sealed class MongoEntityBuilder<TEntity>
         where TEntity : MongoEntity
    {
        /// <summary>
        /// Configures indexes.
        /// </summary>
        public MongoIndexContext<TEntity> Indexes { get; } = new MongoIndexContext<TEntity>();

        /// <summary>
        /// Configures seed data.
        /// </summary>
        public IList<TEntity> Seed { get; } = new List<TEntity>();
    }
}

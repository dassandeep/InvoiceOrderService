using InvoiceOrderEntity.Models;
using InvoiceOrderRepository.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Repository.Interface
{
    public interface IMongoEntityConfiguration<TEntity>
        where TEntity : MongoEntity
    {
        void Configure(MongoEntityBuilder<TEntity> context);
    }
}

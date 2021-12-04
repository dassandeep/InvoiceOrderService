using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOrderRepository.Configuration
{
    public class MongoRepositoryOptions
    {
        public string ConnectionString { get; set; }

        public NamingConvention CollectionNamingConvention { get; set; } = NamingConvention.Snake;

       public bool PluralizeCollectionNames { get; set; } = true;
    }
}

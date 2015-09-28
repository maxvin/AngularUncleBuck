using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UncleBuck.Common
{
    using System.Data.Entity;
    using System.Data.Entity.Migrations;

    public class UncleBuckDb : DbContext, IUncleBuckDb

    {
        public DbSet<Customer> Customers { get; set; }

        IQueryable<Customer> IUncleBuckDb.Customers
        {
            get
            {
                return this.Customers;
            }
        }

        public void Save()
        {
            this.Save();
        }


        public void AddOrUpdateCustomer(Customer customer)
        {
            this.Customers.AddOrUpdate(customer);
        }
    }

    public interface IUncleBuckDb
    {
        IQueryable<Customer> Customers { get; }

        void AddOrUpdateCustomer(Customer customer);

        void Save();

    }
}

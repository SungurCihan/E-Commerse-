using ETicaret.Application.Repositories.CustomerRepositories;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EticaretDbContext context) : base(context)
        {
        }
    }
}

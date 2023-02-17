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
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EticaretDbContext context) : base(context)
        {
        }
    }
}

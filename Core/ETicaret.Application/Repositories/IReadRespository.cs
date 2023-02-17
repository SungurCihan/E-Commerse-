using ETicaret.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories
{
    public interface IReadRespository<T> : IRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(string id, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> filter, bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true);
        IQueryable<T> GetAll(bool tracking = true);
    }
}

using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity // select işlemi yapıcaksak bu read işlemi olacak.
    {
        IQueryable<T> GetAll(bool tracing = true); //sorgu üzerinde çalışmak istiyosak IQueryable kulllanırız.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracing = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracing = true); //first or defoult' un asenkron fonksiyonunu kullanacağı için async keywordünü ekledik.
        Task<T> GetByIdAsync(string id, bool tracing = true);
    }
}

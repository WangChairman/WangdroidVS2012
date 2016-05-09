using AddrBook.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddrBook.DAL
{
    public abstract partial class BaseDal<T>
            where T : class
    {
        DbContext dbContext = new AddrBookContext();

        public IQueryable<T> GetList(int pageSize, int pageIndex)
        {
            return dbContext.Set<T>()
                .OrderByDescending(GetKey()) //u=>u.Tid
                .Skip((pageIndex - 1) * pageSize) //3,5   10
                .Take(pageSize);
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>()
                .Where(GetByIdKey(id))
                .FirstOrDefault();
        }

        public int Add(T bookType)
        {
            dbContext.Set<T>().Add(bookType);
            return dbContext.SaveChanges();
        }

        public int Edit(T bookType)
        {
            dbContext.Set<T>().Attach(bookType);
            dbContext.Entry(bookType).State = EntityState.Modified;
            return dbContext.SaveChanges();
        }

        public int Remove(int id)
        {
            var bookType = GetById(id);
            dbContext.Set<T>().Remove(bookType);
            return dbContext.SaveChanges();
        }

        public abstract Expression<Func<T, int>> GetKey();
        public abstract Expression<Func<T, bool>> GetByIdKey(int id);

        public int GetCount()
        {
            return dbContext.Set<T>().Count();
        }
    }
}

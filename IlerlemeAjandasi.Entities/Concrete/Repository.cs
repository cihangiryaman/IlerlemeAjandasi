using IlerlemeAjandasi.Entities.Abstract;
using IlerlemeAjandasi.Entities.Database.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.Entities.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, IEntity<T>, new()
    {
        private IlerlemeAjandasiContext _context;
        private DbSet<T> table;

        public Repository()
        {
            this._context = new IlerlemeAjandasiContext();
            table = _context.Set<T>();
        }

        public Repository(IlerlemeAjandasiContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void BulkDelete(List<int> ids)
        {
            foreach (var item in ids)
            {
                T existing = table.Find(item);
                table.Remove(existing);
            }
        }

        public IEnumerable<T> GetByExpression(Expression<Func<T,bool>> expression)
        {
            IEnumerable<T> entities = table.Where(expression).ToList();
            return entities;
        }
    }
}

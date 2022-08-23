using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IlerlemeAjandasi.Entities.Abstract
{
    public interface IRepository<T> where T : class, IEntity<T>, new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetByExpression(Expression<Func<T,bool>> expression);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void BulkDelete(List<int> ids);
        void SaveChanges();
    }
}

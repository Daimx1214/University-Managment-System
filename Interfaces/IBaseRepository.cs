using System.Linq.Expressions;

namespace UniversityManagmentSystem.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> predicate);
        public Task<T> Add(T entity);
        public void Remove (T entity);
    }
}
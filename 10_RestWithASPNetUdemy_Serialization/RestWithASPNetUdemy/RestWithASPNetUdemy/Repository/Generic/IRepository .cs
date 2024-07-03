using RestWithASPNetUdemy.Model;
using RestWithASPNetUdemy.Model.Base;

namespace RestWithASPNetUdemy.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);

        T Update(T item);

        void Delete(long id);

        T FindById(long id);

        List<T> FindAll();

        bool Exists(long id);
    }
}

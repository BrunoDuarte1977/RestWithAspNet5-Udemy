using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);

        Book Update(Book person);

        void Delete(long id);

        Book FindById(long id);

        List<Book> FindAll();

        bool Exists(long id);
    }
}

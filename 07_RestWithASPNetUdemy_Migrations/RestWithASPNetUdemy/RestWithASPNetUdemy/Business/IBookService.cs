using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);

        Book FindById(long id);

        List<Book> FindAll();
    }
}

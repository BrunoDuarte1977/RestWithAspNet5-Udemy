using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);

        BookVO FindById(long id);

        List<BookVO> FindAll();
    }
}

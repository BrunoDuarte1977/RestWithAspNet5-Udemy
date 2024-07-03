using RestWithASPNetUdemy.Data.VO;
using RestWithASPNetUdemy.Model;

namespace RestWithASPNetUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);

        PersonVO Update(PersonVO person);

        void Delete(long id);

        PersonVO FindById(long id);

        List<PersonVO> FindAll();
    }
}

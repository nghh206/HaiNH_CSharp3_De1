using DomainClass;

namespace Repositories.Interface
{
    public interface IXeMayRepositories
    {
        List<XeMay> GetAll();
        List<XeMay> FindByName(string name);
        public XeMay Create(XeMay obj);
        public void Update(XeMay obj);
        public void Delete(XeMay obj);

    }
}

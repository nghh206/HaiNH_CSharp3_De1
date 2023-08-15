using DomainClass;
using Repositories.Interface;
using Repositories.Repositories;

namespace Service
{
    public class ServiceXeMay
    {
        static IXeMayRepositories xeMayRepositories;
        static ServiceXeMay()
        {
            xeMayRepositories = new XeMayRepositories();
        }
        public static List<XeMay> GetAll()
        {
            return xeMayRepositories.GetAll();
        }
        public static List<XeMay> FindByName(string name)
        {
            return xeMayRepositories.FindByName(name);
        }
        public static XeMay Create(XeMay obj)
        {
            return xeMayRepositories.Create(obj);
        }
        public static void Delete(XeMay obj)
        {
            xeMayRepositories.Delete(obj);
        }
        public static void Update(XeMay obj)
        {
            xeMayRepositories.Update(obj);
        }
    }
}

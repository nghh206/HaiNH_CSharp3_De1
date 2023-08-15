using DomainClass;
using Microsoft.EntityFrameworkCore;
using Repositories.Interface;

namespace Repositories.Repositories
{
    public class XeMayRepositories : IXeMayRepositories
    {
        public List<XeMay> GetAll()
        {
            using (var context = new Context.AppDbContext())
            {
                return context.XeMay.ToList();
            }
        }
        public List<XeMay> FindByName(string name)
        {
            using (var context = new Context.AppDbContext())
            {
                return context.XeMay.Where(x => x.TenXe.Contains(name)).ToList();
            }
        }
        public XeMay Create(XeMay obj)
        {
            using (var context = new Context.AppDbContext())
            {
                context.XeMay.Add(obj);
                context.SaveChanges();
                return obj;
            }
        }
        public void Update(XeMay obj)
        {
            if (obj != null)
            {
                using (var context = new Context.AppDbContext())
                {
                    context.XeMay.Attach(obj);
                    context.Entry(obj).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }
        public void Delete(XeMay obj)
        {
            using (var context = new Context.AppDbContext())
            {
                context.XeMay.Attach(obj);
                context.XeMay.Remove(obj);
                context.SaveChanges();
            }
        }
    }
}

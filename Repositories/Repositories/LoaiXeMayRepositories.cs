using DomainClass;
using Microsoft.EntityFrameworkCore;
using Repositories.Interface;

namespace Repositories.Repositories
{
    public class LoaiXeMayRepositories : ILoaiXeMayRepositories
    {
        public List<LoaiXM> GetAll()
        {
            using (var context = new Context.AppDbContext())
            {
                return context.LoaiXM.ToList();
            }
        }
    }
}

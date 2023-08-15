using DomainClass;
using Repositories.Interface;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceLoaiXM
    {
        static ILoaiXeMayRepositories loaiXeMayRepositories;

        static ServiceLoaiXM()
        {
            loaiXeMayRepositories = new LoaiXeMayRepositories();
        }
        public static List<LoaiXM> GetAll()
        {
            return loaiXeMayRepositories.GetAll();
        }
    }
}

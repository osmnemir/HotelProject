using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfStaffDal:GenericRepository<Staff>,IStaffDal
    {
        public EfStaffDal(Context context):base(context)
        {
                
        }

        public int GetStaffCount()
        {
            var context = new Context(); //contextten yeni nesne alındı
            var value = context.Staffs.Count(); // staffın sayısını getir
            return value;
        }

        public List<Staff> Last4Staff()
        {
            var context = new Context(); //contextten yeni nesne alındı
            var value = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList(); // staffın sayısını getir
            return value;
        }
    }
}

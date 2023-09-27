using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelProject.EntityLayer.Concrete;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staff();
    }
}
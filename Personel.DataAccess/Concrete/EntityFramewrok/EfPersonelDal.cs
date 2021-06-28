using Personel.DataAccess.Abstract;
using Personel.DataAccess.Concrete.EntityFramewrok;
using Personel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Personel.DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personell,PersonelContext>,IPersonelDal
    {
       
       
    }
}

using Personel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.DataAccess.Concrete.EntityFramework
{
    public class PersonelContext:DbContext
    {
        public DbSet<Personell> Personells { get; set; }
    }
}

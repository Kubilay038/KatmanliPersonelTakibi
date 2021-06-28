using Personel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Business.Abstract
{
    public interface IPersonelService
    {
        List<Personell> GetAll();  
        List<Personell> GetPersonelsByİsim(string isim);
        void Add(Personell personell);
        void Update(Personell personell);
        void Delete(Personell personell);
    }
}

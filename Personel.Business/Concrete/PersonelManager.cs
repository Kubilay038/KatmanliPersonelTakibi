using Personel.Business.Abstract;
using Personel.DataAccess.Abstract;
using Personel.DataAccess.Concrete;
using Personel.DataAccess.Concrete.EntityFramework;
using Personel.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Business.Concrete
{
    public class PersonelManager:IPersonelService
    {
        private IPersonelDal _personelDal;

        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public void Add(Personell personell)
        {
            _personelDal.Add(personell);
        }

        public void Delete(Personell personell)
        {
            _personelDal.Delete(personell);
        }

        public List<Personell> GetAll()
        {
            
            return _personelDal.GetAll();
        }

        public object GetPersonelsByİsim(object text)
        {
            throw new NotImplementedException();
        }

        public List<Personell> GetPersonelsByİsim(string isim)
        {
            return _personelDal.GetAll(p => p.İsim.ToLower().Contains(isim.ToLower()));
        }

        public void Update(Personell personell)
        {
            _personelDal.Update(personell);
        }
    }
}

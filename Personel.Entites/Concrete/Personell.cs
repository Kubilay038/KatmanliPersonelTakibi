using Personel.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel.Entites.Concrete
{
    public class Personell:IEntity
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }
        public int Yaş { get; set; }
        public int TelefonNumarası { get; set; }
    }
}

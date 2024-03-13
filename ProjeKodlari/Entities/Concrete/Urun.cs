
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urun : IEntity
    {
        public int UrunId { get; set; }
        public string UrunResim { get; set; }
        public string UrunAd { get; set; }
        public int UrunAded { get; set; }

        public string UrunCesit { get; set; }
        public decimal UrunFiyat { get; set; }

    }
}

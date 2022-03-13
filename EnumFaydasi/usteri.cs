using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFaydasi
{
    public class musteri
    {

        public int id { get; set; }
        public string isim { get; set; }
        public string soyIsim { get; set; }
        public string Cinsiyet { get; set; }
        public string EmailAdres { get; set; }

        public musteri(int _id,string _isim,string _soyisim,string _cinsiyet,string _emailAdres)
        {
            this.id = _id;
            this.isim = _isim;
            this.soyIsim = _soyisim;
            this.Cinsiyet = _cinsiyet;
            this.EmailAdres = _emailAdres;
        }
        

        public static ArrayList musteriler = new ArrayList();

        public musteriDurum musteriEkle(musteri m1)
        {
            musteriler.Add(m1);
            return musteriDurum.kayitBasarili;
            
        }
    }
}

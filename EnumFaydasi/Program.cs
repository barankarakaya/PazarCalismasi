using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumFaydasi
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri musteri = new musteri(1,"baran","karakaya","erkek","bkarakaya0707@gmail.com");
            musteriDurum donenDurum = musteri.musteriEkle(musteri);
            if (donenDurum==musteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir sekilde eklenmiştir.");
            }
            Console.ReadLine();
           /* musteri.id = 1;
            musteri.isim = "baran";
            musteri.soyIsim = "karakaya";
            musteri.Cinsiyet = "erkek";
            musteri.EmailAdres = "bkarakaya0707@gmail.com";*/
        }
    }
}

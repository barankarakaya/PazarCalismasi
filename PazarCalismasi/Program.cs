using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarCalismasi
{
    class Program
    {
        static void Main(string[] args)
        {
           gunler gun = gunler.pazartesi;
            if (gun==gunler.pazartesi)
            {
                Console.WriteLine("Günlerden pazartesidir.");
            }
            else if (gun==gunler.salı)
            {
                Console.WriteLine("Günlerden salıdır.");
            }
            else if (gun == gunler.çarşamba)
            {
                Console.WriteLine("Günlerden çarşambadır.");
            }
            else if (gun == gunler.perşembe)
            {
                Console.WriteLine("Günlerden perşembedir..");
            }
            else if (gun == gunler.cuma)
            {
                Console.WriteLine("Günlerden cuma'dır.");
            }
            else if (gun == gunler.cumartesi)
            {
                Console.WriteLine("Günlerden Cumartesidir..");
            }
            else if (gun == gunler.pazar)
            {
                Console.WriteLine("Günlerden Pazardır..");
            }
            else
            {
                Console.WriteLine("Haftanın Günleri bitti.");
            }
            Console.ReadKey();
        }
    }
}

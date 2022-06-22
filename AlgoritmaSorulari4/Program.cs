using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorulari4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen harf ve kelime sayısını öğrenmek istediğiniz cümleyi giriniz.");
            string cumle = Console.ReadLine();
            cumle = cumle.ToLower();
            int sayac = 1;
            string liste = " ";

            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            int kelimeSayisi = sayac;

            string liste2 = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";

            int sayac2 = 0;

            for (int i = 0; i < cumle.Length; i++)
            {
                if (liste2.Contains(cumle[i]))
                {
                    sayac2++;
                }
            }
            int harfSayisi = sayac2;

            Console.WriteLine("Cümlede bulunan kelime sayısı: {0}", kelimeSayisi);
            Console.WriteLine("Cümlede bulunan harf sayısı: {0}", harfSayisi);
            Console.ReadLine();
        }
    }
}

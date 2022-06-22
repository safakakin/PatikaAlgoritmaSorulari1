using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorulari3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı giriniz:");

            int pozitifSayi = Convert.ToInt32(Console.ReadLine());

            List<string> list = new List<string>();

            Console.WriteLine("Lütfen girmiş olduğunuz pozitif sayı kadar kelime giriniz");

            for (int i = 0; i < pozitifSayi; i++)
            {
                string x = Console.ReadLine();
                list.Add(x);
            }
            list.Reverse();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorulari1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen pozitif bir sayı giriniz:");

            int pozitifSayi = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();

            Console.WriteLine("Lütfen girmiş olduğunuz pozitif sayı kadar pozitif sayı giriniz");

            for (int i = 0; i < pozitifSayi; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }

            List<int> list2 = new List<int>();

            foreach (var item in list)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}

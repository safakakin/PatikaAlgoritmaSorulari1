using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmaSorulari2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki adet pozitif sayı giriniz(n,m):");

            int n = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();

            Console.WriteLine("Lütfen girmiş olduğunuz ilk pozitif sayı (n) kadar pozitif sayı giriniz");

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
            }

            List<int> list2 = new List<int>();

            foreach (var item in list)
            {
                if (item % m == 0 || item == m)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}

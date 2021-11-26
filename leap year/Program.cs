using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan tahun awal: ");
            int pertama = int.Parse(Console.ReadLine());
            Console.Write("Masukan tahun akhir: ");
            int terakhir = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = pertama+1; i <= terakhir; i++)
            {
                sum = sum + i;
                if (i % 4 == 0)
                {
                    Console.Write(i + ", ");         
                } 
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoctin1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const int tuoi = 18;
            //Console.WriteLine("So tuoi cua toi la: " + tuoi);
            //int tuoi1namsau = 19;
            //Console.WriteLine("Nam sau toi duoc {0}", tuoi1namsau); // Corrected string interpolation
            //int tuoi10namsau = tuoi + 10;
            //Console.WriteLine("10 Nam sau toi duoc {0}", tuoi10namsau); // Corrected string interpolation

            //Console.ReadKey();

            //const float PI = 3.14f;

            Console.Write(" Nhap ban kinh hinh tron r = ");

            float r = float.Parse(Console.ReadLine());

            Console.WriteLine(" Gia tri cua r {0}", r);

            Console.WriteLine(" Chu vi hinh tron ban kinh r vua nhap la {0}", 2 * 3.14f * r);

            Console.Write(" Dien tich hinh tron ban kinh r vua nhap la {0}", 3.14f * r * r);

            Console.ReadKey();
        }
    }
}

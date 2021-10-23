using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Zadanie20
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            double R;
            MyDelegate myDelegate1=OkruS;
            myDelegate1(R=5);

            MyDelegate myDelegate2 = OkruL;
            myDelegate2(R = 5);

            MyDelegate myDelegate3 = SharV;
            myDelegate3(R = 5);
        }

    static double OkruS(double R)
        {
            Console.WriteLine("Введите радиус окружности:");
            
            return Math.PI * R * R;
        }

    static double OkruL(double R)
        {
            Console.WriteLine("Введите радиус окружности:");
            
            return 2*Math.PI * R;
        }

    static double SharV(double R)
        {
            Console.WriteLine("Введите радиус шара:");
            
            return (4/3)*Math.PI * Math.Pow(R,3);
        }

    }

}

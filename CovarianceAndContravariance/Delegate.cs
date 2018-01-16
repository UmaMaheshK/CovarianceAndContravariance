using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    class Delegate
    {
        class Small
        {

        }

        class Big : Small
        {

        }

        class Bigger : Big
        {

        }

        delegate Small Del(Big b);

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");
            return new Big();
        }

        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");
            return new Small();
        }

        static Small Method3(Small sm)
        {
            Console.WriteLine("Method3");
            return new Small();
        }

        static Big Method4(Small sm)
        {
            Console.WriteLine("Method4");
            return new Big();
        }

        static void Main(string[] args)
        {
            Example2();
        }

        private static void Example2()
        {
            //
            Del d = Method1;
            d += Method2;
            d += Method3;
            d += Method4;
            Small sm = d(new Big());
        }
    }
}

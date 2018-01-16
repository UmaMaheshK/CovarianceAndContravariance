using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance.Enum
{
    enum WeekDays { SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY };
    class EnumDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            EnumExp1();
            Console.WriteLine();
            EnumExp2();
            Console.WriteLine();
            EnumExp3();
            Console.WriteLine();
            EnumExp4();
            Console.WriteLine();
        }

        private static void EnumExp1()
        {
            WeekDays day = WeekDays.MONDAY;

            //Get Day name
            Console.WriteLine("Day name {0}", day);//MONDAY

            //Get Day value of name
            Console.WriteLine("Day value {0}", (int)day);//1
        }

        private static void EnumExp2()
        {
            //Get day value
            int dayValue = (int)WeekDays.WEDNESDAY;
            //Get Day name

            //G or g is Format type used to displaying enum names
            string dayName = string.Format("{0:G}", WeekDays.WEDNESDAY);//WEDNESDAY

            //D or d is Format type used to displaying enum name's value
            string strDayValue = string.Format("{0:D}", WeekDays.WEDNESDAY);//3
            Console.WriteLine("Day value {0}", dayValue);//3
        }

        private static void EnumExp3()
        {
            //Get all enum names
            string[] dayNames = System.Enum.GetNames(typeof(WeekDays));
            Array.ForEach(dayNames, Console.WriteLine);
            /*
                OUTPUT

                SUNDAY
                MONDAY
                TUESDAY
                WEDNESDAY
                THURSDAY
                FRIDAY
                SATURDAY                
            */
        }

        private static void EnumExp4()
        {
            //Get all values of enum
            Console.WriteLine("----Values are ---------");
            int[] values = (int[])System.Enum.GetValues(typeof(WeekDays));
            Array.ForEach(values, Console.WriteLine);
            foreach (int item in System.Enum.GetValues(typeof(WeekDays)))
                Console.WriteLine(item);

            /* OUTPUT 
                0
                1
                2
                3
                4
                5
                6            
            */
        }
    }
}

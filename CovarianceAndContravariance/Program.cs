namespace CovarianceAndContravariance
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

    class Program
    {
        private static void Example1()
        {
            //Covariance : an instance of more derived type object/class to be assign to less derived type object or class.
            //Pass derive type where base type expected
            Small sm1 = new Small();
            Small sm2 = new Big();
            Small sm3 = new Bigger();

            Big b1 = new Big();
            Big b2 = new Bigger();
            //Contravarience
            //Big b3 = new Small();
        }
    }
}
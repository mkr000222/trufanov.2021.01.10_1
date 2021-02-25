using System;

namespace trufanov._2021._01._10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortNumber = 100;

            int number = 156146581;

            long longNumber = 1456156156156;

            byte numberByte = 120;

            float floatNumber = 10.04454f;
            double doubleNumber = 10.45456456456464;
            decimal decimalNumber = 10.145646M;


            string str = "";
            bool status = true;

            sbyte sbyteNumber = -1;
            byte byteNumber = (byte)sbyteNumber;


            Console.WriteLine(byteNumber);

            Console.WriteLine(100 + 10);
            Console.WriteLine(100 - 10);
            Console.WriteLine(100 / 3D);
            Console.WriteLine(100 * 10);
            Console.WriteLine(101 % 10);
            Console.WriteLine(100 + 1);
            Console.WriteLine(100 + 2);

            Console.WriteLine("_______________________");

            bool status1 = true;
            bool status2 = false;
            bool status3 = false;

            Console.WriteLine(status1 ^ status2);
        }
    }
}

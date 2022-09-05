using System;

namespace Lesson2Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //סעיף1 
            Console.WriteLine("-------------- 1------------------");
            Console.WriteLine("enter a number :");
            string stringNumberFromUser1 = Console.ReadLine();
            int NumberFromUser1 = Convert.ToInt32(stringNumberFromUser1);
            Console.WriteLine("NumberFromUser1 {0}", NumberFromUser1);
            Console.WriteLine("--------------------------------");

            //סעיף 2
            Console.WriteLine("--------------- 2-----------------");
            Console.WriteLine("enter a number :");
            int NumberFromUser2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NumberFromUser2 {0}", NumberFromUser2);
            Console.WriteLine("--------------------------------");

            //סעיף 3
            Console.WriteLine("---------------- 3------------");
            bool isLive = true;
            string stringIsLive = isLive.ToString();
            Console.WriteLine("bool is {0} string is {1}", isLive, stringIsLive);
            Console.WriteLine("---------------------------------");

            //סעיף 4 
            //t4
            Console.WriteLine("--------------4--------------");
            int numm1 = 72;
            double numm2 = numm1;
            Console.WriteLine(numm2);
            Console.WriteLine("--------------------------------");

            //סעיף 5
            Console.WriteLine("---------------5--------------");
            Console.WriteLine("problem 5. enter a number:");
            float num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("float value: {0}", num3);
            int intVar = (int)num3;
            Console.WriteLine("Int value: {0}", intVar);
            Console.WriteLine("----------------------------------");

            //סעיף 5.2
            //t5
            Console.WriteLine("insert a number with a decimal");
            string insNum = Console.ReadLine();
            float insNum1 = float.Parse(insNum);
            Console.WriteLine(insNum1);
            int insNum2 = (int)insNum1;
            Console.WriteLine(insNum2);

        }
    }
}

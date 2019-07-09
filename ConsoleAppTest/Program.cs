using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputFirstNumber;
            int inputSecondNumber;
            int dayOfTheWeek;
            string inputdayOfTheWeek;
            string myFirstNumber;
            string mySecondNumber;
           
            string myName;
            Console.WriteLine("Enter Your Name: ");
            myName = Console.ReadLine();
            Console.WriteLine("Enter First Number: ");
            myFirstNumber = Console.ReadLine();
            Console.WriteLine("Enter Second Number: ");
            mySecondNumber = Console.ReadLine();
            Int32.TryParse(myFirstNumber, out inputFirstNumber);
            Int32.TryParse(mySecondNumber, out inputSecondNumber);
            SayHi(myName);
            Console.WriteLine("The Sum Is: ");
            DoMath(inputFirstNumber, inputSecondNumber);
            MyNumbers(inputFirstNumber, inputSecondNumber);
            Console.WriteLine();
            Console.WriteLine("Enter A Number For Day Of The Week");
            inputdayOfTheWeek = Console.ReadLine();
            Int32.TryParse(inputdayOfTheWeek, out dayOfTheWeek);
            DayOfTheWeek(dayOfTheWeek);
            


        }



       public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name + "!");

        }


        public static void DoMath(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);

        }


        public static void MyNumbers(int myThirdNum, int myForthNum)
        {



            if (myThirdNum > myForthNum)
            {
                Console.WriteLine("The First Number Is Greater Than The Second Number!");
            }

            else
                Console.WriteLine("The Second Number Is Greater Than The First Number");

        }


        public static void DayOfTheWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 0:
                    Console.WriteLine("It's Mon");
                    break;

                case 1:
                    Console.WriteLine("It's Tue");
                    break;

                case 2:
                    Console.WriteLine("It's Wed");
                    break;

                case 3:
                    Console.WriteLine("It's Thur");
                    break;

                case 4:
                    Console.WriteLine("It's Fri");
                    break;

                case 5:
                    Console.WriteLine("It's Sat");
                    break;

                case 6:
                    Console.WriteLine("It's Sun");
                    break;

                default:
                    Console.WriteLine("Invalid Entry!");
                    break;



            }


        }


    }
}

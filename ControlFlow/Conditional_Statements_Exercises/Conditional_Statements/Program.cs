using System;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //IF-ELSE


           // bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            
            
            //TERNARY OPERATOR
            
            /*
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);


            //Switch-Case
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("We've got promotion");
                    break;

                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
                    

            }*/

            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }


        /// <summary>
        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>

        public static void Exercise1()
        {
            Console.WriteLine("\n\n---- Exercise 1 -----");


            Console.WriteLine("Insert a number: ");
            var number = int.Parse(Console.ReadLine());

            var validNumber = (number >= 1 && number <= 10) ? "Valid" : "Invalid";
            Console.WriteLine(validNumber);
        }


        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>

        static void Exercise2()
        {
            Console.WriteLine("---- Exercise 2 -----");

            int[] arrayNumbers = new int[2];

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                arrayNumbers[i] = int.Parse(Console.ReadLine());
            }

            var max = (arrayNumbers[0] > arrayNumbers[1]) ? arrayNumbers[0] : arrayNumbers[1];
            Console.WriteLine($"Max is: {max}");

            Console.ReadLine();


        }


        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        static void Exercise3()
        {
            float width, height;

            Console.WriteLine("---- Exercise 3 ----");

            Console.WriteLine("Insert image width: ");
            width = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert image height: ");
            height = float.Parse(Console.ReadLine());

            var orientation = width > height ? VerifyOrientation.Landscape : VerifyOrientation.Portrait;
            Console.WriteLine("Image is " + orientation);
            

        }

        public enum VerifyOrientation
        {
            Landscape,
            Portrait
        }

        ///<sumary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.
        /// </sumary>

        static void Exercise4()
        {
            Console.WriteLine("---- Exercise 4 ----");

            Console.WriteLine("Insert the speed limit: ");
            var speed = float.Parse(Console.ReadLine());

            Console.Write("Insert the speed of your car: ");
            var speedCar = float.Parse(Console.ReadLine());

            if (speedCar <= speed)
            {
                Console.WriteLine("Ok!");
            }
            else
            {
                const int demeritPoint = 5;

                var calcDemeritPoints = (speedCar - speed) / demeritPoint;
                if (calcDemeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine($"Demerit Points: {calcDemeritPoints}");
                }
            }



        }
    }
}

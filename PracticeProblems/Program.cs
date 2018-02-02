using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your full name?");
            //string fullName =
            //fullName = "Nicole Torres";
            //Console.WriteLine(fullName);

            //Console.WriteLine("What is your favorite car?");
            //string car =
            //car = "Toyota Tacoma";
            //Console.WriteLine(car);

            //Console.WriteLine("Who is your comic book hero?");
            //string comicBookHero =
            //comicBookHero = "Hot Stuff";
            //Console.WriteLine(comicBookHero);

            //HomeWork 1/17/2018
            //int cupsSugarOne = 7;
            //int cupsSugarTwo = 2;
            //int cupsSugarOne = 7;
            //int cupsSugarTwo = 2;

            //int people = 4;
            //int costEach = 13;

            //int totalCost = 40;
            //int itemCost = 8;

            //int trevonStart = 29;
            //int trevonEnd = 41;

            //int juliaTotalMiles = 47;
            //int juliaExtraMiles = 30;
            //Console.WriteLine(cupsSugarOne - cupsSugarTwo);
            //cupsSugarOne = 4;
            //cupsSugarTwo = 13;
            ////Console.WriteLine(cupsSugarOne * cupsSugarTwo);
            //cupsSugarOne = 40;
            //cupsSugarTwo = 8;
            //Console.WriteLine(cupsSugarOne / cupsSugarTwo);
            //cupsSugarOne = 29;
            //cupsSugarTwo = 41;
            //Console.WriteLine(cupsSugarTwo - cupsSugarOne);
            //cupsSugarOne = 47;
            //cupsSugarTwo = 30;
            //Console.WriteLine(cupsSugarOne - cupsSugarTwo);
            //cupsSugarOne = 12;
            //cupsSugarTwo = 3;
            //Console.WriteLine(cupsSugarOne / cupsSugarTwo);
            //cupsSugarOne = 5.12;
            //cupsSugarTwo = 27.10;
            //Console.WriteLine(cupsSugarOne + cupsSugarTwo);
            //Console.WriteLine(people * costEach);
            //Console.WriteLine(totalCost / itemCost);
            //Console.WriteLine(trevonEnd - trevonStart);
            //Console.WriteLine(juliaTotalMiles - juliaExtraMiles);
            //totalCost = 12;
            //itemCost = 3;
            //Console.WriteLine(totalCost / itemCost);
            //double amountPaid = 5.12;
            //double amountEnd = 27.10;
            //Console.WriteLine(amountPaid + amountEnd);



            ////01/18/2018 Homework
            //// Muffin Assignment - indexes
            //int sugarNeeded = (cupsSugarOne - cupsSugarTwo);//cupsSugarOne = total sugar needed, cupsSugarTwo = sugar aready added
            //Console.WriteLine("Muffin Assignment");
            //Console.WriteLine("Please enter your name.");
            //string nameResponse = Console.ReadLine();
            //Console.WriteLine("{0}, Please add {1} additional cups of sugar to the muffin mix.", nameResponse, sugarNeeded);
            //Console.WriteLine(" ");

            ////Restaurant Bill - Concatenation
            //int totalBill = (people * costEach);//people = number of people in dinner party, costEach = cost per diner
            //Console.WriteLine("Restaurant Assignment");
            //Console.WriteLine("Please list the names of the four people in the dinner party.");
            //string diners = Console.ReadLine();
            //Console.WriteLine("The total dinner bill for " + diners + " was $" + totalBill + ".");
            //Console.WriteLine(" ");

            ////Diaper Assignment - Indexes
            //int number = (totalCost / itemCost);//totalCost = total amount paid, itemCost = cost of each item
            //Console.WriteLine("Diaper Assignment");
            //Console.WriteLine("What is your favorite brand of diapers?");
            //string brand = Console.ReadLine();
            //Console.WriteLine("If you have ${0}, you can purchase {1} bags of {2} diapers at ${3} per bag. ", totalCost, number, brand, itemCost);
            //Console.WriteLine(" ");

            ////Trevon/Employee Assignment - Indexes           
            //Console.WriteLine("Emloyee Assignment");
            //Console.WriteLine("Who received payment for services rendered?");
            //string name = Console.ReadLine();
            //Console.WriteLine("How much money did employee start with?");
            ////string start = Console.ReadLine();
            ////int startAmount = Convert.ToInt32(start);// use Parse or triParse instead
            //int startAmount = int.Parse(Console.ReadLine());

            //Console.WriteLine("What was the total amount of money the employee had after being paid?");
            ////string end = Console.ReadLine();
            ////int endAmount = Convert.ToInt32(end);
            //int endAmount = int.Parse(Console.ReadLine());

            //int received = (endAmount - startAmount);

            //Console.WriteLine("{0} was paid ${1} for services rendered.", name, received);
            //Console.WriteLine(" ");



            ////01 / 23 / 2018 Homework Working with for loops
            ////Array 1:  Array with 25 elements
            //int[] numberArrayOne = new int[25];
            //for (int i = 0; i <= numberArrayOne.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("");


            ////Array 2: 25 element array, print every other element
            //int[] numberArrayTwo = new int[25];
            //for (int j = 0; j <= numberArrayTwo.Length; j++)
            //{
            //    if ((j % 2) == 0)
            //    {
            //        Console.WriteLine(j);
            //    }

            //}
            //Console.WriteLine("");


            ////Array 3:  Array with 25 elements, printing every other element
            //string[] petName = new string[25];
            //petName[0] = "Emmalani";
            //petName[1] = "Kilo";
            //petName[2] = "Mana"; //means power in Hawaiian
            //petName[3] = "Bina";
            //petName[4] = "Malia"; //means calm waters in Hawaiian
            //petName[5] = "Runty";
            //petName[6] = "Impy";
            //petName[7] = "Milo"; //tree indigenous to Hawaii
            //petName[8] = "Koa"; //tree indigenous to Hawaii
            //petName[9] = "Girlie";
            //petName[10] = "Oscarella";
            //petName[11] = "Oscar";
            //petName[12] = "Mara";
            //petName[12] = "Tamara";
            //petName[13] = "Buddy";
            //petName[14] = "Ele"; //means black in Hawaiian
            //petName[15] = "Kolohe"; //means rascal in Hawaiian
            //petName[16] = "Makani"; //means wind in Hawaiian
            //petName[17] = "Pupule"; //means crazy in Hawaiian
            //petName[18] = "Lani";  //means sky in Hawaiian
            //petName[19] = "Kuuipo"; //means sweetheart in Hawaiian
            //petName[20] = "Hoku"; //means Star in Hawaiian
            //petName[21] = "Niele"; //means curious in Hawaiian
            //petName[22] = "Mardi";
            //petName[23] = "Tremont";
            //petName[24] = "Timmy";

            //int[] numberArray = new int[25];
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    //Console.WriteLine("Please enter a numerical value for the name " + petName[i] + ".");
            //    Console.WriteLine("Please enter a numerical value.");//create int array without a string array
            //    numberArray[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("");
            //}

            //for (int i = 0; i < numberArray.Length; i++)
            //    if ((i % 2) == 0)
            //    {
            //        Console.Write((i) + ", ");
            //    }

            //Console.WriteLine("");
            //Console.WriteLine("");


            //01/24/2018 In class work project
            //Team 1: display first 10 natural numbers using a loop and array
            //        sum first 10 numbers then subtract 4 from the total
            //        Expected result: 1 2 3 4 5 6 7 8 9 10

            //int[] numberArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ////int totalArray = numberArray[0] + numberArray[1] + numberArray[2] + numberArray[3] + numberArray[4] + numberArray[5] + numberArray[6] + numberArray[7] + numberArray[8] + numberArray[9] + numberArray[10];
            //int minusNumber = 4;
            //int sum = 0;
            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    Console.WriteLine(numberArray[i]);
            //}

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    int result = minusNumber;

            //    sum = sum + numberArray[i];
            //    Console.WriteLine(sum);
            //}
            //Console.WriteLine(sum - minusNumber);

            ////Team 2 Loop Assignment ........................................ TEAM 2
            //int[] userNumbers = new int[10];
            //int sum = 0;
            //for (int i = 0; i < userNumbers.Length; i++)
            //{
            //    Console.WriteLine("Please enter a whole number for index " + i);
            //    userNumbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < userNumbers.Length; i++)
            //{
            //    sum += userNumbers[i];
            //}
            //Console.WriteLine("The sum of your numbers is " + sum);
            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("The sum is even");
            //}
            //else
            //{
            //    Console.WriteLine("The sum is odd");
            //}


            ////Team 3
            //Console.WriteLine("How many numbers would you like me to add");
            //int input = int.Parse(Console.ReadLine());
            //int[] numbers = new int[input];
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum = (sum + (i + 1));
            //}
            //Console.WriteLine("The sum of every sequential number to " + input + " is " + sum);


            ////Team 4 write a program C# to read 10 numbers and find their SUM AND AVERAGE.
            //int arrayLength;
            //double sum = 0;
            //double average;
            //Console.WriteLine("Enter the array length");
            //arrayLength = int.Parse(Console.ReadLine());
            //int[] myNumbers = new int[arrayLength];
            //Console.WriteLine("Enter the " + arrayLength + "number");
            //for (int i = 0; i < myNumbers.Length; i++)
            //{

            //    myNumbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < myNumbers.Length; i++)
            //{
            //    sum = sum + myNumbers[i];
            //}
            //Console.WriteLine("Sum of " + arrayLength + " numbers is " + sum);
            //average = sum / myNumbers.Length;
            //Console.WriteLine("Average of " + arrayLength + " numbers is " + average);

        }
    }
}

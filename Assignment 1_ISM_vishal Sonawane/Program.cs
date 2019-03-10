using System;

using System.Diagnostics;



namespace Assignment1

{

    class Program

    {

        static void Main(string[] args)

        {

            int a = 5;
            int b = 25;

            //Below method call is  'printPrimeNumbers' to compute prime number between two variables a and b.
            printPrimeNumbers(a, b);

            int n1 = 5;

            //Below method call is  'getSeriesResult' to generate the series 1/2 -2!/3 + 3!/4...n

            double r1 = getSeriesResult(n1);

            Console.WriteLine("The sum of the series is: " + r1);


            int t1= 5;

            //Below method ' printTriangle' prints triangle using *

            printTriangle(t1);



            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };

            //This method computes the frequency of each element in the array

            computeFrequency(arr);


        }


        /*     The below method computes and prints the prime number 
         *     Example, x=5, y= 25, will print all the prime numbers between 5 and 25  
         *    
         */



        public static void printPrimeNumbers(int a, int b)

        {
            try

            {
                Console.WriteLine("Computing prime between " + a + " and " + b);

                for (int i = a; i <= b; i++)

                {

                    if (!isPrime(i))

                    {

                        Console.WriteLine(i + " is prime");

                    }

                }



            }

            catch (Exception e)

            {

                Debug.WriteLine("Exception :" + e.Message);

            }

        }


        // This method is to findout whether the number is prime or not

        public static bool isPrime(int num)

        {

            bool flag = false;

            for (int i = 2; i <= num / 2; ++i)

            {

                // condition for nonprime number, checking the MOD

                if (num % i == 0)

                {

                    flag = true;

                    break;

                }

            }

            return flag;

        }

        /*
    * para    n - number of terms of the series, integer (int)
    * 
    * summary        : This method computes the series 1/2 - 2!/3 + 3!/4 - 4!/5 --- n     * where ! means factorial, i.e., 4! = 4*3*2*1 = 24. Round off the results to 
    * three decimal places. 
    * Hint: Odd terms are all positive whereas even terms are all negative.
    * Tip: Write a method to compute factorial of n, call it whenever required.
    *
    * returns        : result
    * return type    : double
    */


        public static double getSeriesResult(int n)

        {

            double output = 0.0;

            try

            {

                int StartNum = 1;

                while (StartNum <= n)

                {

                    if (StartNum % 2 != 0)

                    {

                        output = output + (computeFactorial(StartNum) / (StartNum + 1.0));

                    }

                    else

                    {

                        output = output - (computeFactorial(StartNum) / (StartNum + 1.0));

                    }

                    StartNum++;

                }

            }

            catch

            {

                Console.WriteLine("Exception occured while computing getSeriesResult()");

            }



            return output;

        }



        public static int computeFactorial(int n)

        {

            if (n == 0)

                return 1;

            else

                return (n * computeFactorial(n - 1));

        }

        /*
        * n - number of lines for the pattern, integer (int)
        * 
        * summary      : This method prints a triangle using *
        * For example n = 5 will display the output as: 

                  *
                 ***
                *****
               *******
              *********

        
        * returns      : N/A
        * return type  : void
        */


        public static void printTriangle(int x)

        {
            Console.WriteLine("Printing the * triangle with level " + x);

            for (int i = 1; i <= x; i++)

            {
                try {
                    //loop to print spaces

                    for (int j = 1; j <= (x - i); j++)

                        Console.Write(" ");



                    //loop to print stars

                    for (int t = 1; t < i * 2; t++)

                        Console.Write("*");

                    Console.WriteLine();

                }

                catch
                {
                    Console.WriteLine("Exception occured while computing printTriangle()");
                }

           // Console.ReadLine();

            }
        }

        /*
        * a - array of elements, integer (int)
        * 
        * summary      : This method computes the frequency of each element in the array
        * For example a = {1,2,3,2,2,1,3,2} will display the output as: 

        Number	Frequency
        1	2
        2	4
        3	2

        * returns      : N/A
        * return type  : void
        */

        public static void computeFrequency(int[] arr)

        {
            Console.WriteLine("Computing frequency for numbers in following array "+ string.Join("", arr));

            try
            {
                int i = 0;

                int n = arr.Length;

                while (i < n)

                {

                    if (arr[i] <= 0)

                    {

                        i++;

                        continue;

                    }



                    int elementIndex = arr[i] - 1;



                    if (arr[elementIndex] > 0)

                    {

                        arr[i] = arr[elementIndex];

                        arr[elementIndex] = -1;

                    }

                    else

                    {

                        arr[elementIndex]--;

                        arr[i] = 0;

                        i++;

                    }

                }



                Console.Write("\nNumber         Frequency" + "\n");

                for (int j = 0; j < n; j++)
                {

                    if (Math.Abs(arr[j]) != 0)

                        Console.Write(j + 1 + "         " + Math.Abs(arr[j]) + "\n");

                }

              Console.ReadLine();


            }

            catch

            {
                Console.WriteLine("Exception occured while computing computeFrequency()");

            }

        }



    }

}




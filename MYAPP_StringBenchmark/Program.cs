using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {


        long test1result = 0;
        long test2result = 0;
        long test3result = 0;
        Console.WriteLine("For best Visual Studio expirience the results must be below 15000.\n");
        Console.WriteLine("Please press 1 for Benchmark or 2 to see Results Database.\n");

        int userSelection = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (userSelection == 1)
        {
            Console.WriteLine("Benchmarking... Plese wait!");


            for (int i = 0; i < 3; i++)
            {
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                string text = string.Empty;


                Console.WriteLine();

                for (int j = 0; j < 300000; j++)
                {
                    text += i;
                }
                stopwatch.Stop();

                long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                switch (i)
                {
                    case 0:
                        test1result = elapsedMilliseconds;
                        Console.WriteLine($"TEST 1: {test1result}");
                        break;

                    case 1:
                        test2result = elapsedMilliseconds;
                        Console.WriteLine($"TEST 2: {test2result}");
                        break;

                    case 2:
                        test3result = elapsedMilliseconds;
                        Console.WriteLine($"TEST 3: {test2result}");
                        break;
                }
            }




            Console.WriteLine();
            Console.WriteLine($"Average time taken from 3 tests: {(test1result + test2result + test3result) / 3} milliseconds\n");

            Console.WriteLine("Results interpretations: Under Construction!\n");

            Console.WriteLine("\nPress any key to exit the benchmark!");
            Console.ReadKey();
        }

        else if (userSelection == 2)
        {
            SeeResults();
        }
        else
        {
            Console.WriteLine("Invalid input. Program will now exit. Next time press 1 or 2...");
      
        }




    }

    static void SeeResults()
    {
        //ADD YOUR SCORE BY REPLACING "Add HERE" STARTING WITH MOBILE OR DESKTOP ACORDING TO YOUR TYPE OF CPU. 
        //ДОБАВЕТЕ ТУК ВАШИЯТ РЕЗУЛТАТ ЧРЕЗ ПРОМЯНА НА ТЕКСТА "Add HERE" според шаблона.
        //ШАБЛОН: "{Вид процесор - Mobile или Desktop} - {Резултат от теста} ms\n"
        
        Console.WriteLine("Test Results:\n" +
           "Mobile Ryzen 5 5600H - 7800 ms\n" +
           "Mobile AMD A10 PRO 8700B - 42000 ms\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n" +
           "Add HERE\n"
           );


        Console.WriteLine("\nPress any key to exit the benchmark!");
        Console.ReadKey();
    }
}

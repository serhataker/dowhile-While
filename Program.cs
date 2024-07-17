    using System;
    using System.Diagnostics.Metrics;

    namespace dowhile_While
    {
   

    class do_while
    {
    static void Main (string [] args)
    {
            Console.WriteLine("Please give the number please");
            int number=Convert.ToInt32(Console.ReadLine());
            int counters = 0;
    do
    {
               
        Console.WriteLine("i am a of patika");

        counters++;
    } while (counters <= number);

    int i=0; while (i <= 10)
    {
                i++;
                Console.WriteLine("i am a of patika+");
                

    }
            //definitly return value is equal but when we use thw do-while first the program handle the do state before control the while so it is already calculate program if we use the while first it is first control the variable and counter so may not working any code.
        }
    }

    }
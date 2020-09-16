using System;

namespace _9nk2ny
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float accbalance = 50000;
            float goals = 100000;
            float rate = 3;

            
            for(int years = 1; accbalance <= goals; years++ )
            {
                
                if(accbalance <= goals)
                {
                    accbalance = accbalance * (1 + rate/100);
                    Console.WriteLine($"på {years} år så har du {accbalance} på kontot.");
                }
            }
            
            

            

        }
    }
}

using System; 

namespace P09Operators
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            // Step 1: Ask for user input
            Console.WriteLine("Give me a number of seconds:"); 

           
            int totalSeconds = int.Parse(Console.ReadLine()); 

           
            int days = totalSeconds / 86400; 

            
            int hours = (totalSeconds % 86400) / 3600; 

           
            int minutes = (totalSeconds % 3600) / 60; 

           
            int seconds = totalSeconds % 60; 

            
            Console.WriteLine($"Seconds: {seconds}"); 
            Console.WriteLine($"Minutes: {minutes}"); 
            Console.WriteLine($"Hours: {hours}"); 
            Console.WriteLine($"Days: {days}"); 

            
            Console.WriteLine($"{days}.{hours:D2}:{minutes:D2}:{seconds:D2}");

            
            double totalDays = totalSeconds / 86400.0; 
            Console.WriteLine($"In total, that's {totalDays} Days."); 
        }
    }
}
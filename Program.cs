using System;

namespace ConvertToWorkds
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number less than 100 crores");
            long n = Convert.ToInt64(Console.ReadLine());                   
            Console.WriteLine(ConvertNumToWords.convertToWords(n));
            Console.Read();
        }      
       
    }
}

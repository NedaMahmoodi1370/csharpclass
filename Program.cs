using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace session1
{
    class Program
    {

          static void Main(string[] args)
        {
        
           int Total1=0;
           Console.WriteLine("Enter a Number");
           int Number=Convert.ToInt32(Console.ReadLine());
           

           for (int i = 1; i <= Number ; i++)
           {
            if(i%2==1)
             {
               Total1=Total1+i; 
                 
             } 
               
             
           }
           Console.WriteLine($"Total is:{Total1}");

        }       
    }
}
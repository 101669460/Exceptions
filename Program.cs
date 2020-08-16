using System;

namespace Exceptions
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //Initialising variables
            string RoomNum;
            string Name;
            DateTime Entered = new DateTime(1, 01, 01);
            int TimeStayed = 0;

            //User input variable values
            RoomNum = Console.ReadLine();
            Name = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            
            //Handling Exceptions
             try {
                Entered = Convert.ToDateTime(input1);
            } catch(Exception ex) {
                Console.WriteLine($"Please enter a valid Date - {ex.Message}");
            }

            try {
                TimeStayed = int.Parse(input2);
            } catch(Exception ex) {
                Console.WriteLine($"Please enter an integer - {ex.Message}");
            }
           
            //Write variable values
            Console.Write(RoomNum + ", " + Name + ", " + Entered + ", " + TimeStayed);
        }

    }   

}

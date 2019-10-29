using System;

namespace ConsoleExercisesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assigment number ( or -1 to exit )\nSelect: ");
                    int selectionNumber = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;

                    switch (selectionNumber)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            // Call your assigment method here!
                            RunExerciseTre();
                            break;

                        // Add new cases as you progress with your exercises
                        case 4:
                           
                            RunExerciseFour();
                            break;

                        case 5:

                            RunExerciseFive();
                            break;


                        case -1:
                            keepAlive = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not a valid assigment number!");
                            break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A exception has occurred!\nIt can be that you inputed somthing other then a number in the menu or the assigment you were running has a flaw");
                }

                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        private static void RunExerciseOne()
        {
            
           
            Console.WriteLine(" Hello !");
            
                
            Console.WriteLine(" firstname ");
            
                 string name = Console.ReadLine();
           

            Console.WriteLine(" lastname ");
                 string lastName = Console.ReadLine();


            string fullName = name + " " + lastName;

            Console.WriteLine($" Hello !{fullName}");

          Console.Write(" I´m glad to inform you that you are the test subject of my very first assignment ");

        }

        private static void RunExerciseTwo()
        {

            DateTime timeNow = DateTime.Now;
           
            Console.WriteLine("todays date is:" + timeNow.ToShortDateString());

            Console.WriteLine("tomorrows date is: " + timeNow.AddDays(1).ToShortDateString());
  
            Console.WriteLine("Yesterdays date is :" + timeNow.AddDays(-1).ToShortDateString());
        }


        // Cerate your exercise methods here


       private static void RunExerciseTre()
        {
           

            Console.Write("Please enter your first name :");
            string name =  Console.ReadLine();
            

            Console.Write("Please enter your last name :");

            string lastName = Console.ReadLine();

           
        }

       private static void RunExerciseFour()

        {
            

            String str = "The quick fox Jumped Ower the DOG";
            
            Console.WriteLine("String:  {0} ", str.Trim().ToLower());
         

        }
        
        private static void RunExerciseFive()

        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            //string numbers = new string ( 1, 2, 3, 4, 5 );
            // int i = Convert.ToInt32(numbers); 
            //Console.WriteLine(i);

            int index = Array.IndexOf(numbers, 2);
            Console.WriteLine("Index of 2: " + index);
            //;
        }
    }// end of program
    // no code here plz
}




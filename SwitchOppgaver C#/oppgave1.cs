using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOppgaver_C_
{
    internal class Oppgave1
    {
        public void Run()
        {
            Console.WriteLine("Hvilken dag er nummer 5?");
            var input = Console.ReadLine();
            int number = 5;

            switch(input)
            {
                case "1":
                    Console.WriteLine("1 is Monday");

                    break;


                case "2":
                    Console.WriteLine("2 is tuesday");
                    
                    break;



                case "3":
                    Console.WriteLine("3 is wednesday");
                    break;


                case "4":
                    Console.WriteLine("4 is thirsday");

                    break;


                case "5":
                    Console.WriteLine("5 is friday");

                    break;


                case "6":
                    Console.WriteLine("6 is saturday");

                    break;


                case "7":
                    Console.WriteLine("7 is sunday");

                    break;
                


            }

        }
    
    
    }
}

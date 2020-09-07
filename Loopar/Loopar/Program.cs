using System;

namespace Loopar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello big papa, welcome to the biggest question in the universe. \n");

            

            while (true)
            {
                Console.WriteLine("Press (1) for the Question");

                Console.WriteLine("Press (2) if you want to Exit");

                int caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Who do you like the most? Rick or Morty? \n Press (1) for Rick \n Press (2) for Morty");


                        break;

                    case 2:
                        Console.WriteLine("You have Quit");
                        Environment.Exit(0);
                        break;

                    default:

                        break;

                }

                var wabbaLubbaDubDub = Convert.ToInt32(Console.ReadLine());

                if (wabbaLubbaDubDub == 1)
                {
                    Console.WriteLine("i MaDe A bOmB MoRtY **Buurp** (I also like Rick) \n");

                }

                else if (wabbaLubbaDubDub == 2)
                {
                    Console.Write("Ahhh");

                    for(var i = 0; i<3 ; i++)
                    {
                        Console.Write(" .");
                        System.Threading.Thread.Sleep(700);


                    }
                    Console.Write(" Geez\n \n");

                }
            }

        }
    }
}

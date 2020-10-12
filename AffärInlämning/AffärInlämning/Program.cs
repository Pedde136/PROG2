using System;
using System.Collections.Generic;

namespace AffärInlämning
{
    class Program
    {
        private static List<Produkt> kundvagn = new List<Produkt>();
        static void Main(string[] args)
        {
 
            MenuText();

            Produkt pölse = new Produkt();
            pölse.Name = "Pölse";
            pölse.Price = 15;

            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:

                    Console.WriteLine("Whats your name?");

                    Kund kund = new Kund();
                    
                    kund.Name = Console.ReadLine();
                    
                    Console.WriteLine("Whats you age?");
                    
                    kund.Age = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Hey, my name is " + kund.Name + " and I'm " + kund.Age + " years old. Let's shop. \n");

                    kundvagnAdd(pölse);
                    
                    viewKundvagn();

                    break;

                case 2:
                    Console.WriteLine("Exit");
                    Environment.Exit(1);
                    break;
            }

        }
        public static void MenuText()
        {
            Console.WriteLine("Hello and welcome to my shop. Please select an alternative: \n");

            Console.WriteLine("Press (1) to Start Shopping");

            Console.WriteLine("Press (2) to Exit");
        }

        public static void kundvagnAdd(Produkt pölse)
        {
            Console.WriteLine("Press (1) to add ¨Pölse¨ to cart. \n");
            if (Console.ReadLine() == "1")
            {
                kundvagn.Add(pölse);
                Console.WriteLine("'Pölse' has been added to cart! \n");
            }
        }

        public static void viewKundvagn()
        {
            Console.WriteLine("Press (2) to view cart.");
            if(Console.ReadLine() == "2")
            {
                for (int i = 0; i < kundvagn.Count; i++)
                {
                    Console.WriteLine(kundvagn[i].Name + " , " + kundvagn[i].Price + "kr");
                }
            }
        }
    }
}

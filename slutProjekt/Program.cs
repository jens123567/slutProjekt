using System;

namespace slutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            //programet presenteras
            Console.WriteLine("Hej och välkommen till detta berättelse spel");

            string spelaAvsluta = "";
            //loop som allt ligger i
            while (spelaAvsluta != "2")
            {
                //deklarera variabler
                string tillScen3 = "";
                string tillSlutscen = "";

                //muvudmeny visas
                huvudMeny();
                spelaAvsluta = Console.ReadLine();

                //scen 1 presenteras med två val
                Console.WriteLine("text för scen 1");
                Console.WriteLine("1. alternativ 1");
                Console.WriteLine("2. alternativ 2");
                string tillScen2 = Console.ReadLine();

                // scen 2
                switch (tillScen2)
                {
                    //scen 2.1 presenteras med ytterligare fyra val
                    case "1":
                        Console.WriteLine("text för scen 2.1");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        Console.WriteLine("3. alternativ 2");
                        Console.WriteLine("4. alternativ 2");
                        tillScen3 = Console.ReadLine();
                        break;

                    //scen 2.2 presenteras med ytterligare fyra val
                    case "2":
                        Console.WriteLine("text för scen 2.2");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        Console.WriteLine("3. alternativ 2");
                        Console.WriteLine("4. alternativ 2");
                        tillScen3 = Console.ReadLine();
                        break;

                    default:
                        break;
                }

                switch (tillScen3)
                {
                    //scen 3.1 presenteras med ytterligare två val
                    case "1":
                        Console.WriteLine("text för scen 3.1");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        tillSlutscen = Console.ReadLine();
                        break;

                    //scen 3.2 presenteras med ytterligare två val
                    case "2":
                        Console.WriteLine("text för scen 3.2");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        tillSlutscen = Console.ReadLine();
                        break;

                    //scen 3.3 presenteras med ytterligare två val
                    case "3":
                        Console.WriteLine("text för scen 3.3");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        tillSlutscen = Console.ReadLine();
                        break;

                    //scen 3.4 presenteras med ytterligare två val
                    case "4":
                        Console.WriteLine("text för scen 3.4");
                        Console.WriteLine("1. alternativ 1");
                        Console.WriteLine("2. alternativ 2");
                        tillSlutscen = Console.ReadLine();
                        break;

                    default:
                        break;
                }


                //alternativen leder tillbaka till en avslutande händelse och sammanfattning
                switch (tillSlutscen)
                {
                    //du lyckades
                    case "1":
                        break;

                    //du misslyckades
                    case "2":
                        break;

                    default:
                        break;
                }

                //huvudmeny igen val att börja om eller stänga programmet
                Console.WriteLine("spelet är slut vill du spela igen?");
                huvudMeny();
                spelaAvsluta = Console.ReadLine();
            }
        }
        static void huvudMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Starta spelet");
            Console.WriteLine("2. Avsluta");
        }
    }
}

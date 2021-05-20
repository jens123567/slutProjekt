using System;

namespace slutProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            //programet presenteras med en nedräkning
            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hej och välkommen till detta berättelse spel");

            string spelaAvsluta = "";


            //huvudmeny visas
            huvudMeny();
            spelaAvsluta = kontrolleraSvar(2);
            Console.WriteLine("");

            //loop som allt ligger i
            while (spelaAvsluta != "2")
            {
                //deklarera variabler
                string tillScen3 = "";
                string tillSlutscen = "";
                string dittNamn = "";
                string föremål = "";
                string plats = "";
                int antalSvar = 2;

                //fyll i namn
                Console.WriteLine("Skriv in ditt namn");
                dittNamn = Console.ReadLine();
                Console.WriteLine("");

                //scen 1 presenteras med två val
                scen1();
                string tillScen2 = kontrolleraSvar(antalSvar);
                Console.WriteLine("");
                antalSvar = 4;

                // scen 2
                switch (tillScen2)
                {
                    //scen 2.1 presenteras med ytterligare tre val
                    case "1":
                        scen21();
                        tillScen3 = kontrolleraSvar(antalSvar);
                        break;

                    //scen 2.2 presenteras med ytterligare fyra val
                    case "2":
                        scen22(dittNamn);
                        tillScen3 = kontrolleraSvar(antalSvar);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("");
                antalSvar = 2;


                //scen 3
                switch (tillScen3)
                {
                    //scen 3.1 presenteras med ytterligare två val
                    case "1":
                        föremål = scen31();
                        tillSlutscen = kontrolleraSvar(antalSvar);

                        plats = "rektorns rum";
                        break;

                    //scen 3.2 presenteras med ytterligare två val
                    case "2":
                        föremål = scen32();
                        tillSlutscen = kontrolleraSvar(antalSvar);

                        plats = "person 1s lägenhet";
                        break;

                    //scen 3.3 presenteras med ytterligare två val
                    case "3":
                        föremål = scen33();
                        tillSlutscen = kontrolleraSvar(antalSvar);

                        plats = "polishuset";
                        break;

                    //scen 3.4 presenteras med ytterligare två val
                    case "4":
                        föremål = scen34();
                        tillSlutscen = kontrolleraSvar(antalSvar);

                        plats = "Internationella brottsdomstolen i haag";
                        break;

                    default:
                        break;
                }
                Console.WriteLine("");

                //alternativen leder tillbaka till en avslutande händelse och sammanfattning
                switch (tillSlutscen)
                {
                    //du lyckades
                    case "1":
                        slutScen1(dittNamn, föremål);
                        break;

                    //du misslyckades
                    case "2":
                        slutScen2(dittNamn, föremål, plats);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("");

                //huvudmeny igen val att börja om eller stänga programmet
                Console.WriteLine("spelet är slut vill du spela igen?");
                huvudMeny();
                spelaAvsluta = kontrolleraSvar(antalSvar);
            }
        }
        //huvudmenyn
        static void huvudMeny()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Starta spelet");
            Console.WriteLine("2. Avsluta");
        }

        //kontrollerar svar
        static string kontrolleraSvar(int antalSvarIn)
        {
            string svar = "";
            string rättEllerFel = "";
            string antalSvar = antalSvarIn.ToString();

            while (rättEllerFel != "1")
            {
                svar = Console.ReadLine();
                if (antalSvar == "2")
                {
                    if (svar == "1" || svar == "2")
                    {
                        rättEllerFel = "1";
                    }
                    else
                    {
                        Console.WriteLine("felaktigt alternativ, försök igen");
                    }
                }
                else if (antalSvar == "4")
                {
                    if (svar == "1" || svar == "2" || svar == "3" || svar == "4")
                    {
                        rättEllerFel = "1";
                    }
                    else
                    {
                        Console.WriteLine("felaktigt alternativ, försök igen");
                    }
                }
            }
            return svar;

        }

        //scen 1
        static void scen1()
        {
            Console.WriteLine("Person 1: Då är det dags");
            Console.WriteLine("Du: Dags för vad?");
            Console.WriteLine("Person 1: Presentationen");
            Console.WriteLine("*Du inser att du inte har gjort presentationen*");
            Console.WriteLine("1. Du försöker förhandla för att göra presentationen en annan dag");
            Console.WriteLine("2. Du försöker snabbt slänga ihop en presentation");
        }

        //scen 2.1
        static void scen21()
        {
            Console.WriteLine("Du: Så jag tänkte att vi kanske kunde flytta min presentation till en annan dag?");
            Console.WriteLine("Person 1: Flytta?! Nej kommer inte på fråga");
            Console.WriteLine("1. Du bryter ihop och börjar gråta");
            Console.WriteLine("2. Du accepterar svaret och försöker göra en presentation");
            Console.WriteLine("3. Du lämnar rummer");
        }

        //scen 2.2
        static void scen22(string dittNamn)
        {
            Console.WriteLine("Du sitter stressad och gör din presentation, det börjar närma sig din tur");
            Console.WriteLine($"Person 1: {dittNamn} då är det dags för din presentation");
            Console.WriteLine("Du är inte redo än");
            Console.WriteLine("1. Du klarar inte längre stressen och bryter ihop i tårar");
            Console.WriteLine("2. Du gör ditt bästa och går upp och presenterar");
            Console.WriteLine("3. Arg över att det blev din tur trots att du inte var klar väljer du att lämna rummet");
            Console.WriteLine("4. Du begår ett krigsbrott");
        }

        //scen 3.1
        static string scen31()
        {
            Console.WriteLine("Person 1: Hej, det är ingen fara");
            Console.WriteLine("Person 1: Du kan göra presentationen en annan gång");
            Console.WriteLine("Du tar upp och använder en...");
            Console.WriteLine("'skriv in vad du använder'");
            string föremål = Console.ReadLine();
            Console.WriteLine($"Person 1: Varför använde du en {föremål}");
            Console.WriteLine($"1. För att tacka för att jag kan göra presentationen en annan dag, du erbjuder att bjuda på {föremål}");
            Console.WriteLine("2. För att jag hatar dig");

            return föremål;
        }

        //scen 3.2
        static string scen32()
        {
            Console.WriteLine("Du står och presenterar du gör ditt bästa");
            Console.WriteLine("Du inser att du kan illustrera vad du pratar om bättre om du använder en...");
            Console.WriteLine("'skriv in vad du använder'");
            string föremål = Console.ReadLine();
            Console.WriteLine($"Person 1: Hur tänkte du när du använde en {föremål}");
            Console.WriteLine("1. Jag tyckte att den skulle hjälpa till att illustrera vad jag menar");
            Console.WriteLine($"2. Att använda en {föremål} gjorde min presentation bättre än någon av dina presentationer");

            return föremål;
        }

        //scen 3.3
        static string scen33()
        {
            Console.WriteLine("*Du lämnar rummet*");
            Console.WriteLine("*Du stöter på din kompis*");
            Console.WriteLine("Kompis: har du mina grejer?");
            Console.WriteLine("Du: ja det har jag");
            Console.WriteLine("*Du ger honom en...");
            Console.WriteLine("'skriv in vad du ger'");
            string föremål = Console.ReadLine();
            Console.WriteLine($"Kompis: Tack för att jag fick en {föremål}");
            Console.WriteLine($"1. Du inser ditt misstag och ger en {föremål} till din lärare");
            Console.WriteLine($"2. Du väljer att ge en {föremål} til fel person");

            return föremål;
        }

        //scen 3.4
        static string scen34()
        {
            Console.WriteLine("Alla är i skräck när dom ser dig dra fram en...");
            Console.WriteLine("'skriv in vad du drar fram'");
            string föremål = Console.ReadLine();
            Console.WriteLine($"Din {föremål} får alla att försöka lämna rummet");
            Console.WriteLine("1. Du låter folk lämna rummet");
            Console.WriteLine($"2. Du använder din {föremål} för att stoppa folk från att fly");

            return föremål;
        }

        //slutscenen scenario 1, gick bra
        static void slutScen1(string dittNamn, string föremål)
        {
            Console.WriteLine($"Person 1: {dittNamn}, tack vare att du använde en {föremål} så ger jag dig högsta betyg på din presentation");
        }

        //slutscen scenario 2, gick dåligr
        static void slutScen2(string dittNamn, string föremål, string plats)
        {
            Console.WriteLine($"*Du sitter i {plats}*, pågrund av att du använde {föremål} så kan du inte längre få hålla presentationen");
            Console.WriteLine($"Person 1: {dittNamn}, du får härmed underkänt på presentationen");
            Console.WriteLine("");
            Console.WriteLine("*Du misslyckades*");
        }

    }
}

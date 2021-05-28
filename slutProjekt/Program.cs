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

            //Deklarera variabel för spela eller avsluta för whileloopen
            string spelaAvsluta = "";


            //huvudmeny visas
            huvudMeny();
            //läser in svar
            spelaAvsluta = kontrolleraSvar(2);
            //blankrad
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

                //ber användaren om en onödig siffra som kontrolleras med tryparese
                användTryParse();

                //fyll i namn
                //ber om namn
                Console.WriteLine("Skriv in ditt namn");
                //läser in namn
                dittNamn = Console.ReadLine();
                //blankrad
                Console.WriteLine("");

                //scen 1 presenteras med två val
                scen1();
                //läser in svar
                string tillScen2 = kontrolleraSvar(antalSvar);
                //blankrad
                Console.WriteLine("");

                //scen2
                tillScen3 = scen2Swtich(tillScen2, dittNamn);
                //blankrad
                Console.WriteLine("");
                //sätter antalsvar till 2
                antalSvar = 2;


                //scen 3
                //tar tillbaka en array med data från scen 3
                string[] scenTreData = scen3Switch(tillScen3);
                // plockar ut varje variabel ur arrayen
                föremål = scenTreData[0];
                tillSlutscen = scenTreData[1];
                plats = scenTreData[2];
                //blankrad
                Console.WriteLine("");

                //slutscen
                slutScenSwitch(tillSlutscen, dittNamn, föremål, plats);
                //blankrad
                Console.WriteLine("");

                //huvudmeny igen val att börja om eller stänga programmet
                Console.WriteLine("spelet är slut vill du spela igen?");
                huvudMeny();
                //läser in svaret
                spelaAvsluta = kontrolleraSvar(antalSvar);
            }
        }

        //använd tryparse
        static void användTryParse()
        {
            //ber om siffra
            Console.WriteLine("skriv en siffra");
            //variabel för siffran
            int siffra;
            //kontrollerar så att det är en siffra
            while (int.TryParse(Console.ReadLine(), out siffra) == false)
            {
                Console.WriteLine("du skrev ingen siffra skriv en siffra");
            }
            //förklarar vad som skett
            Console.WriteLine($"din siffra är {siffra}");
            Console.WriteLine("denna siffra spelar ingen roll framöver");
            Console.WriteLine("tack för att du spelar");
        }

        //huvudmenyn
        static void huvudMeny()
        {
            //aray med de olika alternativen
            string[] huvudmeny = new string[] { "Välj ett alternativ", "1. Starta spelet", "2. Avsluta" };

            //loopar igenom dem och skriver ut dem efter varandra
            foreach (string item in huvudmeny)
            {
                Console.WriteLine(item);
            }
        }

        //switch för scen 2
        /// <summary>
        /// switch för scen 2
        /// </summary>
        /// <param name="tillScen2">till switchen i scen 2</param>
        /// <param name="dittNamn">användarens namn </param>
        /// <returns></returns>
        static string scen2Swtich(string tillScen2, string dittNamn)
        {
            //deklarerar variabel för senare användning
            string tillScen3 = "";

            // scen 2
            switch (tillScen2)
            {
                //scen 2.1 presenteras med ytterligare fyra val
                case "1":
                    scen21();
                    tillScen3 = kontrolleraSvar(4);
                    break;

                //scen 2.2 presenteras med ytterligare fyra val
                case "2":
                    scen22(dittNamn);
                    tillScen3 = kontrolleraSvar(4);
                    break;

                default:
                    break;

            }
            //returnerar svaret till switchen i nästa scenario
            return tillScen3;

        }

        //scen 3 switch
        /// <summary>
        /// switch för scen 3
        /// </summary>
        /// <param name="tillScen3">används i switchen för scen 3</param>
        /// <returns></returns>
        static string[] scen3Switch(string tillScen3)
        {
            //deklarera variabler
            string tillSlutscen = "";
            string föremål = "";
            string plats = "";

            //switchen
            switch (tillScen3)
            {
                //scen 3.1 presenteras med ytterligare två val
                case "1":
                    föremål = scen31();
                    tillSlutscen = kontrolleraSvar(2);

                    //olika platser för varje val
                    plats = "rektorns rum";
                    break;

                //scen 3.2 presenteras med ytterligare två val
                case "2":
                    föremål = scen32();
                    tillSlutscen = kontrolleraSvar(2);

                    //olika platser för varje val
                    plats = "person 1s lägenhet";
                    break;

                //scen 3.3 presenteras med ytterligare två val
                case "3":
                    föremål = scen33();
                    tillSlutscen = kontrolleraSvar(2);

                    //olika platser för varje val
                    plats = "polishuset";
                    break;

                //scen 3.4 presenteras med ytterligare två val
                case "4":
                    föremål = scen34();
                    tillSlutscen = kontrolleraSvar(2);

                    //olika platser för varje val
                    plats = "Internationella brottsdomstolen i haag";
                    break;

                default:
                    break;
            }

            //gör en array som kan returneras
            string[] array = new string[] { föremål, tillSlutscen, plats };

            //returnerar array
            return array;

        }

        //slutscen
        /// <summary>
        /// slutscenen
        /// </summary>
        /// <param name="tillSlutscen">används i switchen</param>
        /// <param name="dittNamn">användarens namn</param>
        /// <param name="föremål">ett föremål som användaren har skrivit in</param>
        /// <param name="plats">platsen där handlingen sker</param>
        static void slutScenSwitch(string tillSlutscen, string dittNamn, string föremål, string plats)
        {
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
        }

        //kontrollerar svar
        static string kontrolleraSvar(int antalSvarIn)
        {

            //deklarerar variabler
            string svar = "";
            string rättEllerFel = "";
            //typkonvertering
            string antalSvar = antalSvarIn.ToString();

            while (rättEllerFel != "1")
            {
                //läser in användarens svar
                svar = Console.ReadLine();
                //om det finns två svar
                if (antalSvar == "2")
                {
                    if (svar == "1" || svar == "2")
                    {
                        rättEllerFel = "1";
                    }
                    else
                    {
                        Console.WriteLine("felaktigt alternativ, tryck på antingen '1' eller '2' på tangentbordet");
                    }
                }
                //om det finns fyra svar
                else if (antalSvar == "4")
                {
                    if (svar == "1" || svar == "2" || svar == "3" || svar == "4")
                    {
                        rättEllerFel = "1";
                    }
                    else
                    {
                        Console.WriteLine("felaktigt alternativ, tryck på antingen '1', '2', '3' eller '4' på tangentbordet");
                    }
                }
            }
            //returnerar svar
            return svar;

        }

        //scen 1
        static void scen1()
        {

            string[] scen = new string[] { "Person 1: Då är det dags", "Du: Dags för vad?", "Person 1: Presentationen", "*Du inser att du inte har gjort presentationen*", "1. Du försöker förhandla för att göra presentationen en annan dag", "2. Du försöker snabbt slänga ihop en presentation" };

            foreach (string item in scen)
            {
                Console.WriteLine(item);
            }

        }

        //scen 2.1
        static void scen21()
        {
            Console.WriteLine("Du: Så jag tänkte att vi kanske kunde flytta min presentation till en annan dag?");
            Console.WriteLine("Person 1: Flytta?! Nej kommer inte på fråga");
            Console.WriteLine("1. Du bryter ihop och börjar gråta");
            Console.WriteLine("2. Du accepterar svaret och försöker göra en presentation");
            Console.WriteLine("3. Du lämnar rummer");
            Console.WriteLine("4. Du begår ett krigsbrott");
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

        //slutscen scenario 2, gick dåligt
        static void slutScen2(string dittNamn, string föremål, string plats)
        {
            Console.WriteLine($"*Du sitter i {plats}*, pågrund av att du använde {föremål} så kan du inte längre få hålla presentationen");
            Console.WriteLine($"Person 1: {dittNamn}, du får härmed underkänt på presentationen");
            Console.WriteLine("");
            Console.WriteLine("*Du misslyckades*");
        }

    }
}
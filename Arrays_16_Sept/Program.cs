

using System;
using System.Threading.Channels;

namespace Array_16_Sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GothamsHjaltar();
            TextNums();
            ReverseWordsOrder();
            AllChars();
            NameAndAge();
            TenRandoms();
        }

        static void GothamsHjaltar()
        {
            // Övning 1
            string[] gothamHeroes = new string[]
            {
                "Batman",
                "Alfred Pennyworth",
                "Robin",
                "Nightwing",
                "The Red Hood",
                "Red Robin",
                "Batgirl",
                "Batwoman",
                "Black cat",
                "Batwing",
                "Blue bird",
                "The Huntress",
                "Ghost-Maker",
                "Jarro",
                "Oracle",
                "James Gordon"
            };
            for (int counterTwo = 0; counterTwo < gothamHeroes.Length; counterTwo++) // En loop som går från 0 av arrayen till längden av arrayen
            {
                Console.WriteLine(gothamHeroes[counterTwo]); // Skriver ut vår array "gothamHeroes" så många gånger counterTwo har gått (alltså längden av vår array)
            }

            // Övning 2
            string[] gothamVillans = new string[]
            {
                "Catwoman",
                "Bane",
                "The Joker",
                "Hugo Strange",
                "Harley Quinn",
                "Killer Croc",
                "Two face",
                "Joe Chill",
                "Mr.Freeze",
                "Poison Ivy",
                "Deadshot",
                "Ra's al Gul",
                "Scarecrow",
                "The Riddler",
                "Penguin"
            };
            Array.Sort(gothamVillans); // Sorterar i bokstavsordning
            for (int counterT = 0; counterT < gothamVillans.Length; counterT++) // En loop som går från 0 av arrayen till längden av arrayen
            {
                Console.WriteLine(gothamVillans[counterT]); // Skriver ut vår array "gothamVillans" så många gånger counterT har gått (alltså längden av vår array)
            }
        }

        // Övning 3
        static void TextNums()
        {
            string[] nummer = new string[]
            {
                "Ett",
                "Två",
                "Tre",
                "Fyra",
                "Fem",
                "Sex",
                "Sju",
                "Åtta",
                "Nio",
                "Tio",
                "Elva",
                "Tolv",
                "Tretton",
                "Fjorton",
                "Femton",
                "Sexton",
                "Sjutton",
                "Arton",
                "Nitton",
                "Tjugo"
            };

            Console.Write("Skriv en siffra mellan 1 och 20: ");
            int mittSvar = Convert.ToInt32(Console.ReadLine()); // Vi gör om vårt tal till en siffra istället för en string
            Console.WriteLine(nummer[mittSvar - 1]); // Vi skriver ut vår array "nummer" från det vi skrivit in - 1
        }

        // Övning 4

        static void ReverseWordsOrder()
        {
            string[] ord = new string[3]; // Efersom vi angett storleken på arrayen så skriver man ; efter iställer för måsvingar
            Console.WriteLine("Ange tre ord:");
            Console.Write("> ");
            ord[0] = Console.ReadLine();
            Console.Write("> ");
            ord[1] = Console.ReadLine();
            Console.Write("> ");
            ord[2] = Console.ReadLine();
            Console.WriteLine($"{ord[2]} {ord[1]} {ord[0]}");
        }

        // Övning 5

        static void AllChars()
        {
            Console.Write("Skriv ett ord: ");
            string word = Console.ReadLine();
            foreach (char xxx in word) // För varje bokstav (char) inom vår string
            {
                Console.WriteLine("> " + xxx); // skall detta skrivas ut + vår bokstav (char)
            }

        }

        // Övning 6

        static void NameAndAge()
        {
            string[] nameHeroes = new string[]
            {
                "Batman",
                "Robin",
                "Batgirl",
                "Oracle",
                "James Gordon"
            };

            int[] ageHeroes = new int[] // Här gör vi en array med nummer (int istället)
            {
                35,
                15,
                15,
                35,
                55
            };
            for (int i = 0; i < nameHeroes.Length; i++) // Vi gör en for loop som går ignom hela vår array och vi kan nu kalla på i och få fram något ur vår array
            {
                Console.WriteLine($"{nameHeroes[i]} är {ageHeroes[i]} år gammal"); // Här skriver vi alltså ut namn index och vår ålder index. Loopen går då så många gånger som värdet av nameHeroes.Length
            }
        }

        // Övning 7 

        static void TenRandoms()
        {
            int[] randomTal = new int[10]; // Vi skapar en int array med 10 tal
            int summa = 0; // Vi skapar en variabel summa och sätter den = 0
            Random slumpTal = new Random(); // Vi skapar en variabel "slumpTal" som har förmågan att slumpa fram ett tal
            for (int counterX = 0; counterX < 10; counterX++) // Vi skapar en for loop som går igenom vår array 10 gånger. Nu kan vi kalla på vår array med vår nya index "counterX"
            {
                randomTal[counterX] = slumpTal.Next(101); // Vi kör vår array randomTal 10 gånger (counterX) och använder oss av vårt slumpTal.Next(101) som tar fram ett värde från 0-100
            }

            for (int counterX = 0; counterX < 10; counterX++) // Vi gör en ny loop som är identisk med den ovan
            {
                summa += randomTal[counterX]; // Nu använder vi oss av vår variabel vi skapade i början som är = alla våra 10 arrays som vi plussar ihop
                Console.WriteLine(randomTal[counterX]); // Här skriver vi ut alla våra tal som vi får fram i konsolen
            }

            Console.WriteLine($"Summan är {summa} "); // Här skriver vi ut vårdet av alla arrays tillsammans
        }
    }
}
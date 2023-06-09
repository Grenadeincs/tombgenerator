using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the dead person's first name?  > ");
            string deadname = Console.ReadLine();
            Console.Write("What's the dead person's last name?  > ");
            string deadsurname = Console.ReadLine();
            Console.Write("What was the dead person's age at the time of death?  > ");
            string deadage = Console.ReadLine();
            Console.Write("What's the dead person's sex?  > ");
            string deadgender = Console.ReadLine();
            Console.Write("Who's the dead person's father?  > ");
            string deadfather = Console.ReadLine();
            Console.Write("Who's the dead person's mother?  > ");
            string deadmother = Console.ReadLine();
            Console.Write("When was the dead person born (year only)?  > ");
            string birthdate = Console.ReadLine();
            Console.Write("What did the dead person leave in heritage?  > ");
            string heritage = Console.ReadLine();
            Console.Write("Any comment on the dead person?  > ");
            string deadcomment = Console.ReadLine();
            int result = 0;
            bool check1 = false;
            bool check2 = false;
            if((deadcomment.ToLower()) == "no" || (deadcomment.ToLower()) == "none" || (deadcomment.ToLower()) == "negative.")
            {
                deadcomment = "";
            }
            try
            {
                check1 = true;
                result = result + Convert.ToInt32(deadage);
            }
            catch (FormatException)
            {
                check1 = false;
            }
            try
            {
                check2 = true;
                result = result + Convert.ToInt32(birthdate);
            }
            catch (FormatException)
            {
                check2 = false;
            }
            if (check1 != true || check2 != true)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\nUnable to calculate the dead person's date of death. Defaulting to zero.");
                result = 0;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            string[] pronouns = new string[4];
            deadgender.ToLower();
            if ((deadgender.ToLower()) == "male" || (deadgender.ToLower()) == "man" || (deadgender.ToLower()) == "masculine" || (deadgender.ToLower()) == "boy")
            {
                pronouns[0] = "He";
                pronouns[1] = "Him";
                pronouns[2] = "His";
                pronouns[3] = "was";
            }
            else if ((deadgender.ToLower()) == "female" || (deadgender.ToLower()) == "woman" || (deadgender.ToLower()) == "feminine" || (deadgender.ToLower()) == "girl")
            {
                pronouns[0] = "She";
                pronouns[1] = "Her";
                pronouns[2] = "Her";
                pronouns[3] = "was";
            }
            else
            {
                pronouns[0] = "They";
                pronouns[1] = "Them";
                pronouns[2] = "Their";
                pronouns[3] = "were";
            }
            Console.WriteLine("Great! The tomb was generated. Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"                                                R.I.P. {deadname} {deadsurname}. {deadcomment}");
            Console.WriteLine($"                                                {pronouns[0]} {pronouns[3]} born in {birthdate} and died in {result}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"                                                {pronouns[2]} mother was {deadmother} and {pronouns[2]} father was {deadfather}         ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"                                                {pronouns[0]} left {heritage} in heritage. ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
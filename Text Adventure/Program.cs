using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Text_Adventure
{
    struct PlayerData
    {
        public string name;
        public bool isAlive;
        public DateTime whenCreated;
        public DateTime whenUpdated;
    }
    internal class Program
    {
        enum DomainType
        {
            
        }
        public static PlayerData player;

        static void Name()
        {

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Insert Character Name");
            player.name = Console.ReadLine();
            StartGame();

            Console.ReadKey();
        }

        static void StartGame()
        {
            player.isAlive = true;
            player.whenCreated = DateTime.Now;
            player.whenUpdated = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Domain Expansion");
            Thread.Sleep(300);
            Console.WriteLine("World of Programming");
            Thread.Sleep(300);
            Console.WriteLine("(^>=<^)");
            Thread.Sleep(300);
            Console.WriteLine("}:[");
            Thread.Sleep(300);
            Console.WriteLine("You can't escape The Code");
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Domain Clash | Try to Run | Give Up");
            Thread.Sleep(300);

            string input = Console.ReadLine().ToUpper();
            if (input == "DOMAIN CLASH")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Alright Lets Do This");
                Thread.Sleep(300);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Clash of Clans | Infinite Coding | Super Mario World");
                Thread.Sleep(300);

                // Make sure to type Domain Clash before typing these V
                input = Console.ReadLine().ToUpper();
                if (input == "CLASH OF CLANS")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Why are you playing a game in the middle of a fight");
                    Thread.Sleep(300);
                    Console.WriteLine();
                    Console.WriteLine(player.name + " died");
                    Thread.Sleep(4000);
                }
                else if (input == "INFINITE CODING")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Domain Expansion");
                    Thread.Sleep(300);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Infinite Coding");
                    Thread.Sleep(300);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("(Your Destroying Him)");
                    Thread.Sleep(300);
                    Console.WriteLine("\nWinner");
                    Thread.Sleep(300);
                    Console.WriteLine("Good Job " + player.name + "\n");
                    Thread.Sleep(4000);
                }
                else if (input == "SUPER MARIO WORLD")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Domain Expansion");
                    Thread.Sleep(300);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Super Mario World");
                    Thread.Sleep(300);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Wow...");
                    Thread.Sleep(300);
                    Console.WriteLine("Didn't expect that");
                    Thread.Sleep(300);
                    Console.WriteLine("He Didn't stand a chance...");
                    Thread.Sleep(300);
                    Console.WriteLine("\nGood Job " + player.name + " you Win\n");
                    Thread.Sleep(4000);
                }
                // Secrets V
                else if (input == "EIGHT HANDLED SWORD DIVERGENT SILA DIVINE GENERAL MAHORAGA")
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("With this treasure I summon...");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Maharaga has hulk smashed you into the ground then lauches you into the roof of the domain");
                    Thread.Sleep(800);
                    Console.WriteLine();
                    Console.WriteLine(player.name + " has been offically obliterated");
                    Thread.Sleep(4000);

                }
                else if (input == "DIDDY KONG")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("...");
                    Thread.Sleep(800);
                    Console.WriteLine("Your a monkey");
                    Thread.Sleep(600);
                    Console.WriteLine("Good Job");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("You Win " + player.name);
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Have Banana...");
                    Thread.Sleep(4000);
                }
                else if (input == "SKIBIDI TOILET")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("      ._____.       ");
                    Console.WriteLine("      / _ _ `       ");
                    Console.WriteLine("      | 0 0 |       ");
                    Console.WriteLine("      |`._./|       ");
                    Console.WriteLine(" `.`.  `___/   / /  ");
                    Console.WriteLine("  | ~~~~~~~~~~~ |   ");
                    Console.WriteLine("  `_____________/   ");
                    Thread.Sleep(800);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("His brain starts rotting away");
                    Thread.Sleep(600);
                    Console.WriteLine("Good Job");
                    Thread.Sleep(1000);
                    Console.WriteLine();
                    Console.WriteLine("You Win " + player.name);
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Oh and you are a Skibidi Toilet now");
                    Thread.Sleep(4000);
                }

                if (input == "DEREK")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Derek Mode Activated");
                    Thread.Sleep(800);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Derek HeadButt | Professional Coder | Derek Dollar Rain");
                    input = Console.ReadLine().ToUpper();

                    if (input == "DEREK HEADBUTT")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Here it Comes");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" |   |     |   ");
                        Thread.Sleep(500);
                        Console.WriteLine(" |   |     |   ");
                        Thread.Sleep(500);
                        Console.WriteLine("   ________     ");
                        Console.WriteLine("  /        `    ");
                        Console.WriteLine(" |  l___./  |   ");
                        Console.WriteLine(" |  o-||-o  |   ");
                        Console.WriteLine(" |  .;  ;.  |   ");
                        Console.WriteLine(" `_{0|//___/    \n");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("(They almighty Head of Coding Justice comes crash down like Meteor)");
                        Thread.Sleep(600);
                        Console.WriteLine("(The Impact causes a shockwave that shattered his Domain and smushed him like an ant)");
                        Thread.Sleep(500);
                        Console.WriteLine("(Just a splattered pubble of him remains)");
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("You Win " + player.name);
                        Thread.Sleep(400);
                        Console.WriteLine("Good Job");
                        Thread.Sleep(4000);
                    }
                    if (input == "PROFESSIONAL CODER")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("You Coded his Domain out of existance");
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("     /`````````.    ");
                        Console.WriteLine("    |           |    ");
                        Console.WriteLine("    |  |  |  |  |    ");
                        Console.WriteLine("    |  |  |  |  |`.  ");
                        Console.WriteLine("    |__|__|__|__| |  ");
                        Console.WriteLine("          `------'   ");
                        Thread.Sleep(400);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("He ran up to you and punch you in your face");
                        Thread.Sleep(900);
                        Console.WriteLine("Your Head Exploded");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine(player.name + " died");
                        Thread.Sleep(4000);
                    }
                    if (input == "DEREK DOLLAR RAIN")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("    |    |    | |    |");
                        Thread.Sleep(100);
                        Console.WriteLine("    |    |    | |   //");
                        Thread.Sleep(100);
                        Console.WriteLine("    |   //    | |     ");
                        Thread.Sleep(100);
                        Console.WriteLine("    |        // |     ");
                        Thread.Sleep(100);
                        Console.WriteLine("   //           |     ");
                        Thread.Sleep(100);
                        Console.WriteLine("               //     ");
                        Thread.Sleep(100);
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("He can't stop your rain");
                        Thread.Sleep(1000);
                        Console.WriteLine();
                        Console.WriteLine("You Win " + player.name);
                        Thread.Sleep(500);
                        Console.WriteLine("Good Job");
                        Thread.Sleep(4000);
                    }
                }
                if (input == "THANOS")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("The Gods have given you the Infinity Gauntlet");
                    Console.WriteLine("Space | Reality | Power | Mind | Time | Soul");
                    input = Console.ReadLine().ToUpper();
                    if (input == "SPACE")
                    {
                        Console.WriteLine("You create a blackhole and shoot it towards his direction");
                        Thread.Sleep(500);
                        Console.WriteLine("  .    .  .......     .  .    ");
                        Thread.Sleep(100);
                        Console.WriteLine(" .  .   ./.-----.`.    .  .   ");
                        Thread.Sleep(100);
                        Console.WriteLine("    .  // /o` o0``.`.  .. ..  ");
                        Console.WriteLine(" .    {{ 0`p o0`o0 }}    .   .");
                        Console.WriteLine("  . . `.`.`0o`0./ //   .   .  ");
                        Thread.Sleep(100);
                        Console.WriteLine("   .  ``.`.-----/`.`  .      .");
                        Thread.Sleep(100);
                        Console.WriteLine(" .  .     ```````    .   .    ");
                        Thread.Sleep(500);
                        Console.WriteLine("Good Job " + player.name);
                        Console.WriteLine("You Win");
                    }
                    if (input == "REALITY")
                    {

                    }
                    if (input == "POWER")
                    {

                    }
                    if (input == "MIND")
                    {

                    }
                    if (input == "TIME")
                    {

                    }
                    if (input == "SOUL")
                    {

                    }
                    else
                    {
                        Console.WriteLine("You decide to snap... just because");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("You tried and failed");
                    Thread.Sleep(800);
                    Console.WriteLine();
                    Console.WriteLine(player.name + " died");
                    Thread.Sleep(4000);
                }


            }
            else if (input == "GIVE UP")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("You beg him not to kill you");
                Thread.Sleep(800);
                Console.WriteLine("He doesn't care");
                Thread.Sleep(600);
                Console.WriteLine();
                Console.WriteLine(player.name + " died");
                Thread.Sleep(4000);
            }
            else if (input == "TRY TO RUN")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("You try to run outside the Domain before it closes");
                Thread.Sleep(1000);
                Console.WriteLine("You were to late");
                Thread.Sleep(600);
                Console.WriteLine("You fell to your knees");
                Thread.Sleep(1500);
                Console.WriteLine("You turned around");
                Thread.Sleep(1200);
                Console.WriteLine("Just to see");
                Thread.Sleep(1200);
                Console.WriteLine("Your final moments");
                Thread.Sleep(600);
                Console.WriteLine();
                Console.WriteLine(player.name + " died");
                Thread.Sleep(4000);
            }

            // Players Opinion based on 1-10 of Game V
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("How do you like this short game " + player.name + "?");
            Thread.Sleep(300);
            Console.WriteLine("Give 1-10 of how you this");
            Thread.Sleep(300);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("1 | 2 | 3 | 4 | 5 | 7 | 8 | 9 | 10");
            Thread.Sleep(300);

            input = Console.ReadLine();
            if (input == "1")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("That's sad, sorry you didn't like it");
                Thread.Sleep(1000);
                Console.WriteLine("(;-;)");
            }
            else if (input == "2")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("At least it's not 1");
                Thread.Sleep(1000);
                Console.WriteLine("(:-;)");
            }
            else if (input == "3")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Better than nothing");
                Thread.Sleep(3000);
                Console.WriteLine("I guess");
                Thread.Sleep(2000);
                Console.WriteLine("I'll try better");
            }
            else if (input == "4")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Ok");
                Thread.Sleep(600);
                Console.WriteLine("I'll do better");
            }
            else if (input == "5")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Right in the middle");
                Thread.Sleep(1000);
                Console.WriteLine("Not that good but I like the advice");
                Thread.Sleep(800);
                Console.WriteLine("I'll do better");
            }
            else if (input == "6")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Not bad, Thanks");
                Thread.Sleep(3000);
                Console.WriteLine("I'll do better to hopefully, up that number");
            }
            else if (input == "7")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Thanks, Glad it wasn't bad");
                Thread.Sleep(800);
                Console.WriteLine("But I must get a 10");
                Thread.Sleep(400);
                Console.WriteLine("I'll do better");
            }
            else if (input == "8")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Great, I'm glad you liked it enough");
                Thread.Sleep(2000);
                Console.WriteLine("Honestly I expected a 6");
                Thread.Sleep(1000);
                Console.WriteLine("I must do better");
            }
            else if (input == "9")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Not perfect but good, Thanks");
                Thread.Sleep(2000);
                Console.WriteLine("I'll keep getting better");
            }
            else if (input == "10")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(800);
                Console.WriteLine("Wow 0_0");
                Thread.Sleep(4000);
                Console.WriteLine("I expected 6");
                Thread.Sleep(600);
                Console.WriteLine("but Wow");
                Thread.Sleep(400);
                Console.WriteLine("Thanks");
                Thread.Sleep(500);
                Console.WriteLine("alot");
                Thread.Sleep(1000);
                Console.WriteLine("Very happy you thought of it as that good");
                Thread.Sleep(2000);
                Console.WriteLine("I don't think I can do better with that score but I'll try");
                Console.WriteLine("     |])");
                Console.WriteLine("     / |_");
                Console.WriteLine(" /```    _)");
                Console.WriteLine("|         _)");
                Console.WriteLine("|         _)");
                Console.WriteLine("`_________)");
                Thread.Sleep(800);
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Black;
        }
}   }

    

 

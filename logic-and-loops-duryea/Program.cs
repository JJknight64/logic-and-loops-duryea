// Jacob Duryea
// 10/3/2024
// Interactive Des. and Alg. Prob. Sol. III
// Logic and Loops

namespace logic_and_loops_duryea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "adventurer";
            string userChoice = "NONE";

            // intro text
            Console.Write("Welcome to the jungle \nWe got fun and games \nWe got everything you want \nHoney, we know the names \n \n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            // enter your name
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle, " + playerName + "!");

            // continue the story
            Console.WriteLine(
                "We approach a clearing in the jungle " +
                "\nThere appears to be an trail to the left... " +
                "\nAnd a cave entrance to the right."
                );

            // narrator talking
            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to walk the trail, or 'right' to enter the cave.");
            // take the user input
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            // your choices DO matter, actually!!
            if (userChoice == "left")
            {
                // trail dialogue
                Console.Write(
                    "As you walk along the trail, you notice the vines and greenery start to thin out.\n" +
                    "The sun begins to shine through the tops of the trees more and more as you trudge along this muddy path.\n" +
                    "Eventually, you trip over an inconvenient rock stuck in the mud and then..." +
                    "You look up to notice that the jungle is behind you! Congratulations, " + playerName + ", you've escaped!\n");
            }
            else if(userChoice == "right")
            {
                // cave dialogue
                Console.Write(
                    "You steel yourself as you decide to brave the dark and dreary cave to your right.\n" +
                    "The further along you progress, the more you think that this might've been a bad idea...\n" +
                    "A swarm of bats suddenly startles awake at your presence and scrambles out of the cave all at once, temporarily obscuring your vision completely.\n" +
                    "When you uncover your eyes, you notice something shiny in the darkness...\n" +
                    "By gosh, it seems you've found it! The lost treasure of the jungle! Congratulations, " + playerName + "!\n");
            }
            else if(userChoice == "back")
            {
                //easter egg
                Console.Write(
                    "Cool! You decided to walk back the way you came! Rad!\nThat will totally help you get out of this jungle! 100%!\n... Blockhead.\n");
            }
            else
            {
                // you done messed up!
                // this is so it keeps asking you for an answer when you put in stupid ones
                userChoice = "NONE";
                while (userChoice != "left" && userChoice != "right" && userChoice != "back")
                {
                    Console.Write(
                        "Two choices, bub. Maybe pick one of them?.\n");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }
                if (userChoice == "left")
                {
                    // trail dialogue
                    Console.Write(
                        "As you walk along the trail, you notice the vines and greenery start to thin out.\n" +
                        "The sun begins to shine through the tops of the trees more and more as you trudge along this muddy path.\n" +
                        "Eventually, you trip over an inconvenient rock stuck in the mud and then..." +
                        "You look up to notice that the jungle is behind you! Congratulations, " + playerName + ", you've escaped!\n");
                }
                else if (userChoice == "right")
                {
                    // cave dialogue
                    Console.Write(
                        "You steel yourself as you decide to brave the dark and dreary cave to your right.\n" +
                        "The further along you progress, the more you think that this might've been a bad idea...\n" +
                        "A swarm of bats suddenly startles awake at your presence and scrambles out of the cave all at once, temporarily obscuring your vision completely.\n" +
                        "When you uncover your eyes, you notice something shiny in the darkness...\n" +
                        "By gosh, it seems you've found it! The lost treasure of the jungle! Congratulations, " + playerName + "!\n");
                }
                else if (userChoice == "back")
                {
                    //easter egg
                    Console.Write(
                        "Cool! You decided to walk back the way you came! Rad!\nThat will totally help you get out of this jungle! 100%!\n... Blockhead.\n");
                }
                else
                {
                    // i don't think there's any normal way to see this text???
                    Console.Write("If you're reading this then... well I really don't know how.");
                }
            }
        }
    }
}

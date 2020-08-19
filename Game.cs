using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
        Spawn:
            Console.Clear();
            //This variable stores health, the .0f helps store decimal values
            float health = 100.0f;
            double money = 420.0f;
            double justbought = 0;
            //Im going to want to be able to alter this value
            // I can take the food poisoning level and multiply it by the damage
            float foodpoisoning = 20;
            bool maxLevelReached = false;
            int maxLevel = 100;
            //I think it would be funny for levels to be severity of the food poisoning maybe an RNG system?
            int level = 1;
            bool ready = true;
            string food = "Nothing";

            //POV you're at a bad mcdonalds
            Console.WriteLine("Cashier: Hello and welcome to Mcdonald what is your name?");
            //Using Console.Readline() works as a wait command
            string name = Console.ReadLine();
            OrderHere:
            Console.WriteLine("Cashier: Alright " + name + " what you want to eat?");
            Console.WriteLine("Options Below  \nPress 1 for Burger  \nPress 2 for FrenchFry   \nPress 3 for Nuggies \nPress 4 for a bug");
            
            //char is used to hold the placeholder of a character not a value, 1-9 can have the # value but in this case it is used as the key itself
            //it is possible to use a letter but they may be case sensitive
            char foodinput = Console.ReadKey().KeyChar;
            if (foodinput == '1')
            {
                food = "Burger";
                foodpoisoning = 5;
                justbought = 2.30;                
            }
            else if (foodinput == '2')
            {
                food = "FrenchFry";
                foodpoisoning = 3;
                justbought = .50;
            }
            else if (foodinput == '3')
            {
                food = "Nuggies";
                foodpoisoning = 100;
                justbought = 5;
            }
            else if (foodinput == '4')
            {
                food = "bug";
                foodpoisoning = 30;
                justbought = 1;
            }
            else
            {
                Console.WriteLine("Bro did I Stutter???");
                goto OrderHere;
            }
            money -= justbought;
            Console.WriteLine("Cashier: Aight I gotchu one " + food + " give me a minute, read this while you wait.");
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine(name + "'s health is currently " + health + " don't ask why you have health");            
            Console.WriteLine("You ordered " + food);
            Console.WriteLine("You are now $" + justbought + " lighter for a total of " + money);
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.WriteLine("Here's your " + food);
            Console.WriteLine("press ENTER key to eat");
            Console.ReadLine();
            Console.WriteLine("You have learned a new level of foodpoisoning");
            Console.WriteLine(name + " is now level " + level + " of food poisoning");
            Console.WriteLine("You took " + foodpoisoning + " damage!");
            health -= foodpoisoning;
            if (health == 70)
            {
                Console.WriteLine("Distant Voice: Why would you eat the bug?");
            }
            Console.WriteLine("You and Cashier are now enemies");
            Console.ReadLine();
            //BRAND NEW SCREEN
            Console.Clear();
            Console.WriteLine(name + "'s Stats");
            Console.WriteLine(name + "'s health is now " + health);
            Console.WriteLine(name + "'s Food Poisoning is level " + level);
            Console.WriteLine(name + " has $" + money + " to his name");
            Console.ReadLine();
            Console.Clear();
            //BRAND NEW SCREEN
            Console.WriteLine("Thoughts: You're here with only a few options, tummy hurts and shit, just wasted $" + justbought + " and nothing really to do about it.");
            Console.WriteLine("1 for Well actually I think im gonna sue \n2 for Well Actually I think im gonna assault the cashier \n3 for Well Actually I think im gonna go home");
            char thoughtprocessone = Console.ReadKey().KeyChar;
            if (thoughtprocessone == '1')
            {
                Console.Clear();
                Console.WriteLine("You decided to challenge McDonalds in a law suit \nMcDonalds splashes scolding hot coffee at you in court \nYou have taken 15 Damage from Coffee");
                health -= 15;
                Console.ReadKey();
                Console.WriteLine("You now have " + health + " health");
                Console.WriteLine("You lose the lawsuit and now everything you own has been McStolen");
                Console.ReadKey();
                Console.WriteLine("Even your McLife,\nYou Perish");
                Console.ReadKey();
                goto Spawn;

            }
            else if (thoughtprocessone == '2')
            {
                Console.WriteLine("You assault the Cashier in a blind rage, but as you're already sick from food poisoning the cashier wins.");
                Console.WriteLine("Now you owe the cashier $50 or he will take your lunch money daily \nDo You Pay? \n1 For im so sorry here \n2 For Nah");
                char thoughtprocessesonedotone = Console.ReadKey().KeyChar;
                if (thoughtprocessesonedotone == '1')
                {
                    money -= 50;
                    Console.WriteLine("You now have $" + money + "left.");
                    Console.WriteLine("You run home out of embarrassment.");
                    Console.WriteLine("Unfortunately you fall on the way home and scrape your knee \n You Took 8 damage");
                    health -= 8;
                    Console.WriteLine("You now have " + health + "health");                     
                    goto phase2;
                }
                else if (thoughtprocessesonedotone == '2')
                {
                    Console.WriteLine("The cashier executes you on the spot \n You Took All The Damage");
                    Console.ReadKey();
                    Console.WriteLine("You see the light fade away from your vision");
                    Console.ReadKey();
                    goto Spawn;                                      
                }
                
            }
            else if (thoughtprocessone == '3')
            {
                Console.WriteLine("You decided to gome home");
                Console.WriteLine("You are well rested and back to full health.");
                    health = 100;
                Console.WriteLine("You are back to " + health + " health");
                goto phase2;
            }
        phase2:
            Console.ReadLine();

        }
    }
}

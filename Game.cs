using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //This variable stores health, the .0f helps store decimal values
            float health = 100.0f;  
            //Im going to want to be able to alter this value
            float foodpoisoning = 20;
            bool maxLevelReached = false;
            int maxLevel = 100;
            //I think it would be funny for levels to be severity of the food poisoning maybe an RNG system?
            int level = 1;
            bool ready = true;
            //POV you're at a bad mcdonalds
            Console.WriteLine("Cashier: Hello and welcome to Mcdonald what is your name?");
            //Using Console.Readline() works as a wait command
            string name = Console.ReadLine();
            Console.WriteLine("Cashier: Alright " + name + "what you want to eat?");
            string food = Console.ReadLine();
            Console.WriteLine("Cashier: Aight I gotchu one " + food + "give me a minute, read this while you wait.");
            Console.WriteLine("Press any key");
            Console.ReadLine();
            Console.WriteLine(name + "'s health is currently " + health + " don't ask why you have health");            
            Console.WriteLine("You ordered" + food);
            Console.WriteLine("You are now $4.56 lighter");
            Console.ReadLine();
            Console.WriteLine("Here's your" + food);
            Console.ReadLine();
            Console.WriteLine("press any key to eat");
            Console.ReadLine();
            Console.WriteLine("You took " + foodpoisoning + " damage!");
            Console.WriteLine("WARNING: You have food poisoning");
            Console.ReadLine();


        }
    }
}

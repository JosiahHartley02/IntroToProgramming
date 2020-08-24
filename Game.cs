using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool GameOver = false;
            while (GameOver != true)
            {
                string role = "Undefined";
                string PreferredCombat = "UNDEFINED";
                float health = 100.0f;
                float stamina = 100.0f;
                bool melee = false;
                bool strategy = false;
                bool ranged = false;
                bool BluntForce = false;
                bool Dead = false;




                Console.WriteLine();
                Console.WriteLine("                                      WELCOME TO HOMIEGANG ZOMBIETEXTGAME");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("First a lil backstory, you are just some guy that magically exists in the middle of an apocalypse");
                Console.WriteLine();
                Console.WriteLine("Majority of all life has turned undead and nothing just has immunities or whatever, there are zombie\n plants but there are still things that are un-undead like you");
                Console.WriteLine();
                Console.WriteLine("You're gonna start off answering some simple questions and then you're on your own.");
                Console.WriteLine();
                Console.WriteLine("Oh and for the sake of convienience you will enter all inputs with the numbpad or number keys unless\n specified");
                Console.WriteLine();
                Console.WriteLine("Here's one of those special specifications now");

                for (int i = 0; i <= 12; i++)
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            Naming:
                Console.Clear();
                Console.WriteLine("                  Please Type Your Name below this can not be changed later, or maybe it can we'll see");
                string name = Console.ReadLine();
                Console.WriteLine("        You have entered " + name + "!");
                Console.WriteLine("        Are there any typos?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
            Inbetween:
                char namecheck = Console.ReadKey().KeyChar;
                if (namecheck == '1')
                {
                    Console.WriteLine("Well then write it right next time");
                    Console.ReadKey();
                    goto Naming;
                }
                else if (namecheck == '2')
                {
                    goto NamingDone;
                }
                else
                {
                    Console.WriteLine("ERROR PLEASE SELECT A VALID OPTION");
                    goto Inbetween;
                }
            NamingDone:
                Console.Clear();
                Console.WriteLine("                                              SELECT A KIT FROM BELOW");
                Console.WriteLine("                  OPTION 1          OPTION 2             OPTION 3            OPTION 4");
                Console.WriteLine("                  INSANE            LOGICAL              DUMB AS DIRT        GIFTED");
                Console.WriteLine("                  strong            smart                dumb                lucky   ");
                Console.WriteLine("                  irrational        rational             ignorant        quick thoughts");
                Console.WriteLine("                  Instigator        Cautious          Accident Prone         Deescalator ");
                Console.WriteLine("                  130 Health        100 Health           200 Health         80 Health");
                Console.WriteLine("                  200 Stamina       150 Stamina          300 Stamina        100 Stamina");
                Console.WriteLine("                 Prefer Melee       Prefer Strat         Prefer BluntForce  Prefer Ranged ");
            RoleFuckUp:
                char roleinput = Console.ReadKey().KeyChar;

                if (roleinput == '1')
                {
                    role = "Insane";
                    health = 130.0f;
                    stamina = 200.0f;
                    melee = true;
                    PreferredCombat = "melee weapons";
                    goto RoleDone
                        ;
                }
                else if (roleinput == '2')
                {
                    role = "Logical";
                    health = 100.0f;
                    stamina = 150.0f;
                    strategy = true;
                    PreferredCombat = "Outsmarting the enemy";
                    goto RoleDone;
                }
                else if (roleinput == '3')
                {
                    role = "Dumb As Dirt";
                    health = 200.0f;
                    stamina = 300.0f;
                    BluntForce = true;
                    PreferredCombat = "Blunt Force Trauma";
                    goto RoleDone;
                }
                else if (roleinput == '4')
                {
                    role = "Gifted";
                    health = 80.0f;
                    stamina = 100.0f;
                    ranged = true;
                    PreferredCombat = "ranged weapons";
                    goto RoleDone;
                }
                else
                {
                    Console.WriteLine("ERROR PLEASE SELECT A VALID OPTION");
                    goto RoleFuckUp;
                }
            RoleDone:
                Console.Clear();
                //I want to add an if bool(role) = true then string rolestring = bool(role) for player convienience
                Console.WriteLine("You have selected " + role + "!\nYour stats are\n" + health + " Health\n" + stamina + " Stamina");
                Console.WriteLine("Your preferred method of combat is " + PreferredCombat + "!");
                Console.WriteLine("Are You happy with your choices?");
                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("1 for you are happy with your choice");
                Console.WriteLine("2 For I am very bad at this pls go back");
            rolefucky:
                char rolefuckywucky = Console.ReadKey().KeyChar;
                if (rolefuckywucky == '1')
                {
                    goto level1Start;
                }
                else if (rolefuckywucky == '2')
                {
                    goto NamingDone;
                }
                else
                {
                    Console.WriteLine("ERROR PLEASE SELECT A VALID OPTION");
                    goto rolefucky;
                }
            level1Start:
                Console.Clear();
                Console.WriteLine("Alright now that you have everything that you need done selected and what not.");
                Console.WriteLine("It's time to drop you into the waste land that is whats left of the world");
                Console.WriteLine("But ill let you press the button yourself");
                Console.WriteLine();
                Console.WriteLine("Press Any Key to get launched to your doom");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Perspective: You open your eyes and see you are no longer in the comfort and safety of the console overlord.");
                Console.WriteLine("Perspective: While looking around you happen to notice a few things");
                Console.WriteLine("Findings: You appear to be in a run down hotel");

                //fix above





            }
        }
    }
}
//If you delete the last bracket and retype it it realigns whole document.

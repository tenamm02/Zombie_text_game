using System;

namespace tenam_TextBasedAdventureGame
{
    class Globals
    {
        public static string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title();
        }

        static void Title() //Title 
        {
            string gameTitle = @"
████████╗██╗░░██╗███████╗  ██████╗░███████╗░██████╗██╗░██████╗████████╗░█████╗░███╗░░██╗░█████╗░███████╗
╚══██╔══╝██║░░██║██╔════╝  ██╔══██╗██╔════╝██╔════╝██║██╔════╝╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔════╝
░░░██║░░░███████║█████╗░░  ██████╔╝█████╗░░╚█████╗░██║╚█████╗░░░░██║░░░███████║██╔██╗██║██║░░╚═╝█████╗░░
░░░██║░░░██╔══██║██╔══╝░░  ██╔══██╗██╔══╝░░░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══██║██║╚████║██║░░██╗██╔══╝░░
░░░██║░░░██║░░██║███████╗  ██║░░██║███████╗██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░╚███║╚█████╔╝███████╗
░░░╚═╝░░░╚═╝░░╚═╝╚══════╝  ╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚══════╝";
            Console.WriteLine(gameTitle);
            Console.WriteLine("Press 1 to begin");
            int choice0 = Convert.ToInt32(Console.ReadLine());

            if (choice0 == 1)
            {
                Console.Clear();
                Intro();
            }
            else
            {
                Title();
            }
        }

        static void Intro() //Beginning
        {
            Console.WriteLine("Wake up...");
            Console.WriteLine(" ");
            Console.WriteLine("I said wake up!");
            Console.WriteLine(" ");
            Console.WriteLine("Good you're awake");
            Console.WriteLine(" ");
            Console.WriteLine("We're pinned down here");
            Console.WriteLine(" ");
            Player();
        }

        static void Player() //Establish Player

        {
            int playerHP = Convert.ToInt32(100);
            Console.WriteLine("What is your name: \n");
            Globals.name = Console.ReadLine();
            Console.WriteLine("\nWhat is your age: \n");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSo your name is {0}", Globals.name + " and your " + age);
            Console.WriteLine(" ");
            Room1();
        }

        static void Room1() //Get the pistol
        {
            Console.Clear();
            Console.WriteLine("Look out here comes one");
            Console.WriteLine(" ");
            Console.WriteLine("Here take this pistol, youll need");
            Console.WriteLine(" ");
            Console.WriteLine("Do you accept the pistol? (1 for yes): ");
            Console.WriteLine(" ");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            if (choice1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Ok, now shoot that zombie");
                Room2();
            }

            else
            {
                Console.WriteLine("Wrong choice");
                Console.WriteLine(" ");
                Console.WriteLine("Would you like to try again? (1 for yes or 2 for no)");
      

                int restart = Convert.ToInt32(Console.ReadLine());
                if (restart == 1)
                {
                    Console.Clear();
                    Intro();
                }

                else if (restart == 2)
                {
                    return;
                }


            }


        }
         
        static void Room2() //First battle
        {
            int playerHP = 100;
            int runnerHP = 75;
            int ammoCount = 10;
            Console.WriteLine("Battle Begin");
            while (playerHP > 0 && runnerHP > 0)
            {
                Console.WriteLine("Choose:\n1: Shoot\n2: Block\n3: Punch");
                Console.WriteLine(" ");
                Console.WriteLine("Player: " + playerHP + " HP");
                Console.WriteLine("Ammo: " + ammoCount);
                Console.WriteLine("Enemy: " + runnerHP + " HP");

                int choice2 = Convert.ToInt32(Console.ReadLine());
                int pistolDamage = 25;
                int runnerDamage = 10;
                int punch = 5;
                if (choice2 == 1 && ammoCount > 0) //shoot 
                {
                    runnerHP = runnerHP - pistolDamage;
                    playerHP = playerHP - runnerDamage;
                    ammoCount = --ammoCount;
                    continue;
                }

                else if (choice2 == 2) //block
                {
                    playerHP = playerHP - (runnerDamage / 2);
                }

                else if (choice2 == 3) // punch
                {
                    runnerHP = runnerHP - punch;
                    playerHP = playerHP - runnerDamage;
                }

                else if (choice2 == 1 && ammoCount == 0)
                {
                    Console.WriteLine("Out of Ammo");
                    return;
                }


            }
            if (playerHP == 0)
            {
                Console.WriteLine("You Lose!");
                Console.Clear();
                playerDeath();
            }
            if (runnerHP == 0)
            {
                Console.WriteLine("You win!");
                Console.Clear();
                Room3();
            }

        }

        static void Room3() //Choose Path 
        {
            Console.Clear();
            Console.WriteLine("Ok, it looks like were in the clear ... for now at least");
            Console.WriteLine(" ");
            Console.WriteLine("So, " + Globals.name + " what are you doing over here anyways?");
            Console.WriteLine(" ");
            Console.WriteLine("You have the cure you say?");
            Console.WriteLine(" ");
            Console.WriteLine("Thats impossible, no one has been able to cure this virus");
            Console.WriteLine(" ");
            Console.WriteLine("Ill see it when I believe it");
            Console.WriteLine(" ");
            Console.WriteLine("Do you show him the cure?\n1: yes\n2: no ");
            Console.WriteLine(" ");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            if (choice3 == 1)
            {
                Console.WriteLine("Is that it?");
                Console.WriteLine("Theres no way");
                Console.WriteLine("It really is?");
                Console.WriteLine("Then we need to get you out of here as fast as possible");
                Console.WriteLine("Take this route to my contact, they will help you get out of the city.");
                Console.WriteLine("*You take the map*");
                Room4B();
            }

            if (choice3 == 2)
            {
                Console.WriteLine("Well in any case, you should probably get out of this place");
                Console.WriteLine("If you take a left at the end of this hall way, you should find an exit");
                Console.WriteLine("Good out luck out there");
                Console.Clear();
                Room4A();
            }

        }

        static void Room4A() //Get the shotgun
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("Taking the man's instructions you find yourself out the open. ");
            Console.WriteLine(" ");
            Console.WriteLine("You quickly find your way into another building in order to not be seen");
            Console.WriteLine(" ");
            Console.WriteLine("As you're walking around you hear something big nearby.");
            Console.WriteLine(" ");
            Console.WriteLine("You notice something in the distance, and start to approach it");
            Console.WriteLine(" ");
            Console.WriteLine("As you get closer, you notice that its a box, when you pick it up the box feels heavy");
            Console.WriteLine(" ");
            Console.WriteLine("Do you open it?\n1: yes\n2: no");
            Console.WriteLine(" ");
            int choice4 = Convert.ToInt32(Console.ReadLine());

            if (choice4 == 1)
            {
                Console.WriteLine("Good Choice, you might need this soon");
                Console.WriteLine("*You recieved a shotgun*");
                Console.Clear();
                Room5A();
            }

            if (choice4 == 2)
            {
                Console.WriteLine("Are you sure it's pretty cool");
                Console.WriteLine(" ");
                Console.WriteLine("Press 1 to open the box");
                int choice5 = Convert.ToInt32(Console.ReadLine());

                if (choice5 == 1)
                {
                    Console.WriteLine("Ok, thats what I thought");
                    Console.WriteLine("*You recieved a shotgun*");
                    Room5A();
                }
                else
                {
                    Console.WriteLine("Just take the damn gun");
                    Console.WriteLine("*You recieved a shotgun*");
                    Room5A();
                }
                
            }
            else
            {
                return;
            }
        }

        static void Room4B() //Dialogue plus choice
        {
            Console.Clear();
            Console.WriteLine("Using the map provided by the man, you find your self\nat small underground hideout");
            Console.WriteLine(" ");
            Console.WriteLine("*kock knock*");
            Console.WriteLine(" ");
            Console.WriteLine("*A small window on the door opens up*");
            Console.WriteLine("Ahh you must be " + Globals.name + ", I've heard about you ");
            Console.WriteLine("Come in, come in");
            Console.WriteLine(" ");
            Console.WriteLine("So, it must be true that you have the cure if you're here");
            Console.WriteLine(" ");
            Console.WriteLine("Oh its ok, I dont need to see it, just make sure you keep it safe");
            Console.WriteLine(" ");
            Console.WriteLine("Here take this bike, it'll get you out of the city");
            Console.WriteLine(" ");
            Console.WriteLine("Be careful though, there are bandits everywhere");
            Console.WriteLine(" ");
            Console.WriteLine("You exit the base, suddenly as you're walking away you hear a woman scream");
            Console.WriteLine(" ");
            Console.WriteLine("Do you go back?\n1:yes\n2: no");
            int choice5 = Convert.ToInt32(Console.ReadLine());

            if (choice5 == 1) //Establishes battle 
            {
                Console.WriteLine("*You go back in*");
                Console.WriteLine("Suddenly you see 2 men in the room ");
                Console.WriteLine("You're able to shoot one of them\nbut now you've gotten yourself in a standoff with the other");
                Room5B(); //battle with evil dude 
            }

            else if (choice5 == 2) //"Wrong" Choice; establishes battle with brute, ends in death 
            {
                Console.WriteLine("You leave... ");
                Console.WriteLine(" ");
                Console.WriteLine("You hear gun shots in the distance as you get farther away");
                Room5C();//Bossfight = death 

            }

        }

        static void Room5A() //Player choice based on 4A 
        {
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine("*You hear a revving in the distance*");
            Console.WriteLine(" ");
            Console.WriteLine("As you're hiding you notice a guy get off of a motorcycle nearby");
            Console.WriteLine(" ");
            Console.WriteLine("Do you steal the bike?\n1: yes\n2: no");
            Console.WriteLine(" ");
            int choice6 = Convert.ToInt32(Console.ReadLine());
            if (choice6 == 1)
            {
                Console.WriteLine("*You rev the engine*");
                Console.WriteLine(" ");
                Console.WriteLine("*You hear a voice in the distance*");
                Console.WriteLine(" ");
                Console.WriteLine("*You quickly get away on the bike as you hear gun shots going past you*");
                Console.WriteLine(" ");
                Room6();
            }

            if (choice6 == 2)
            {
                Console.WriteLine("*You hear a voice in the distance*");
                Console.WriteLine(" ");
                Console.WriteLine("Hey, what are you doing by my bike");
                Console.WriteLine(" ");
                Console.WriteLine("*He pulls out a gun*");
                Console.WriteLine(" ");
                Console.WriteLine("With no time to react he shoots you straight in the head");
                Console.WriteLine(" ");
                Console.WriteLine("You died");
                playerDeath();

            }

            else
            {
                Console.WriteLine("Pick a real choice");
            }

        }

        static void Room5B() //Battle following 4B
        {
            int playerHP = 100;
            int enemyHP = 100;
            int ammoCount = 7;
            Console.WriteLine("Battle Begin");
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.WriteLine("Choose:\n1: Shoot\n2: Block\n3: Punch");
                Console.WriteLine(" ");
                Console.WriteLine("Player: " + playerHP + " HP");
                Console.WriteLine("Ammo: " + ammoCount);
                Console.WriteLine("Enemy: " + enemyHP + " HP");

                int choice7 = Convert.ToInt32(Console.ReadLine());
                int pistolDamage = 15;
                int enemyDamage = 10;
                int punch = 5;
                if (choice7 == 1 && ammoCount > 0) //shoot 
                {
                    enemyHP = enemyHP - pistolDamage;
                    playerHP = playerHP - enemyDamage;
                    ammoCount = --ammoCount;
                    continue;
                }

                else if (choice7 == 2) //block
                {
                    playerHP = playerHP - (enemyDamage / 2);
                }

                else if (choice7 == 3) // punch
                {
                    enemyHP = enemyHP - punch;
                    playerHP = playerHP - enemyDamage;
                }

                else if (choice7 == 1 && ammoCount <= 0)
                {
                    Console.WriteLine("Out of Ammo");
                    return;
                }


            }
            if (playerHP <= 0)
            {
                Console.WriteLine("You Lose!");
                playerDeath();
            }
            else if (enemyHP <= 0)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("Oh you saved me, thank you so much\n Here take this motorcycle\n It was my husbands before his untimely demise\n " +
                    "It'll probably benefit you more than me");
                Room6();

            }
        }

        static void Room5C() //Battle following 4B(Death)
        {
            Console.Clear();
            Console.WriteLine("You finally reach the border of the city \n\nSuddenly you hear a huge crash and feel a rumble in the area \n\n" +
                "You look up and see a huge hulk like zombie rampaging through the area \n\nYou have to face it in order to get out the city. ");

            int playerHP = 100;
            int bruteHP = 200;
            int ammoCount = 7;
            Console.WriteLine("Battle Begin");
            while (playerHP > 0 && bruteHP > 0)
            {
                Console.WriteLine("Choose:\n1: Shoot\n2: Block\n3: Punch");
                Console.WriteLine(" ");
                Console.WriteLine("Player: " + playerHP + " HP");
                Console.WriteLine("Ammo: " + ammoCount);
                Console.WriteLine("Enemy: " + bruteHP + " HP");

                int choice7 = Convert.ToInt32(Console.ReadLine());
                int pistolDamage = 10;
                int enemyDamage = 15;
                int punch = 5;
                if (choice7 == 1 && ammoCount > 0) //shoot 
                {
                    bruteHP = bruteHP - pistolDamage;
                    playerHP = playerHP - enemyDamage;
                    ammoCount = --ammoCount;
                    continue;
                }

                else if (choice7 == 2) //block
                {
                    playerHP = playerHP - enemyDamage;
                }

                else if (choice7 == 3) // punch
                {
                    bruteHP = bruteHP - punch;
                    playerHP = playerHP - enemyDamage;
                }

                else if (choice7 == 1 && ammoCount <= 0)
                {
                    Console.WriteLine("Out of Ammo");
                    return;
                }


            }
            if (playerHP <= 0)
            {
                Console.WriteLine("You Lose!");
                playerDeath();
            }
        }

        static void Room6() //Final boss fight
        {

            Console.WriteLine("You finally reach the border of the city \n\nSuddenly you hear a huge crash and feel a rumble in the area \n\n" +
                "You look up and see a huge hulk like zombie rampaging through the area \n\nYou have to face it in order to get out the city. " +
                "Do you face it or do you run:\n 1: Face it\n 2: Run");
            int choice8 = Convert.ToInt32(Console.ReadLine());

            if (choice8 == 1)
            {
                Console.Clear();
                Console.WriteLine("You decide to fight");
                int playerHP = 100;
                int bruteHP = 200;
                int ammoCount = 6;
                Console.WriteLine("Battle Begin");

                while (playerHP > 0 && bruteHP > 0)
                {
                    Console.WriteLine("Choose:\n1: Shoot\n2: Block\n3: Punch");
                    Console.WriteLine(" ");
                    Console.WriteLine("Player: " + playerHP + " HP");
                    Console.WriteLine("Ammo: " + ammoCount);
                    Console.WriteLine("Enemy: " + bruteHP + " HP");

                    int choice7 = Convert.ToInt32(Console.ReadLine());
                    int shotgunDamage = 50;
                    int enemyDamage = 15;
                    int punch = 5;
                    if (choice7 == 1 && ammoCount > 0) //shoot 
                    {
                        bruteHP = bruteHP - shotgunDamage;
                        playerHP = playerHP - enemyDamage;
                        ammoCount = --ammoCount;
                        continue;
                    }

                    else if (choice7 == 2) //block
                    {
                        playerHP = playerHP - enemyDamage;
                    }

                    else if (choice7 == 3) // punch
                    {
                        bruteHP = bruteHP - punch;
                        playerHP = playerHP - enemyDamage;
                    }

                    else if (choice7 == 1 && ammoCount == 0)
                    {
                        Console.WriteLine("Out of Ammo");
                        return;
                    }


                }
                if (playerHP <= 0)
                {
                    Console.WriteLine("You Lose!\n\n");
                    playerDeath();
                }
                if (bruteHP <= 0)
                {
                    Console.WriteLine("You win!\n\n");
                    End();
                }
            }

            else if (choice8 == 2)
            {
                Console.WriteLine("You decide to run\n\n");
                End2();
            }

        }

        static void End() //Player won 
        {
            Console.Clear();
            Console.WriteLine("You finally beat the monster \n\nAs you walk out of the city, you notice a convy camped out on the side of the road" +
                "\n\nThey were waitng for you \nYou get in the vehicle and you're off \n\nYou've successfully saved the world \n\nCongratulations are in order!!!!!");
            Console.WriteLine("Would you like to try again?\n 1: yes\n 2: no");
            int choice11 = Convert.ToInt32(Console.ReadLine());

            if (choice11 == 1)
            {
                Console.WriteLine("Good luck");
                Title();
            }
        }

        static void End2() //Player chose to run 
        {
            Console.Clear();
            Console.WriteLine("You run as fast as you can trying to outrun the monster.\n\nUnfortunately it doesnt take long for the beast to notice you " +
                "\n\nHe takes you down with swing from behind you\n\nThe cure is done for\n\nHumanity is doomed");
            playerDeath();
        }

        static void playerDeath() //Activates whenever player dies
        {
            Console.Clear();
            Console.WriteLine("You have died.\nWould you like to restart?\n1: yes\n2: no");
            int choice10 = Convert.ToInt32(Console.ReadLine());

            if (choice10 == 1)
            {
                Console.WriteLine("Good luck");
                Title();
            }

            else if (choice10 == 2)
                Console.Clear();
            else
            {
                Console.WriteLine("Please select");
            }
        }
    }
}
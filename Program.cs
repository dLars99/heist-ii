using System;
using System.Collections.Generic;

namespace HeistII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<IRobber> rolodex = new List<IRobber>()
            {
                new Hacker
                {
                Name = "Brian",
                SkillLevel = 27,
                PercentageCut = 15
                },
                new Muscle
                {
                Name = "Skor",
                SkillLevel = 62,
                PercentageCut = 50
                },
                new LockSpecialist
                {
                Name = "The Cracken",
                SkillLevel = 48,
                PercentageCut = 33
                },
                new Hacker
                {
                Name = "H4xx0rz1337",
                SkillLevel = 73,
                PercentageCut = 65
                },
                new Muscle
                {
                Name = "Tommy",
                SkillLevel = 42,
                PercentageCut = 30
                },
                new LockSpecialist
                {
                Name = "Sticky Pete",
                SkillLevel = 35,
                PercentageCut = 20
                }
            };
            Console.WriteLine("The Rolodex");
            Console.WriteLine("-----------");
            Console.WriteLine($"There are {rolodex.Count} unsavory fellas in the Rolodex.");
            Console.WriteLine("I know you got your own guys. Let's add them.");
            Console.WriteLine("What's the name of your crony?  ");
            string newGuyName = Console.ReadLine();
            while (newGuyName != "")
            {
                IRobber newGoon = CreateNewGoon();
                rolodex.Add(newGoon);
                Console.WriteLine($"That brings the Rolodex up to {rolodex.Count} distinguished gentlemen.");
                Console.WriteLine("If ya got another guy, give me a name now. ");
                newGuyName = Console.ReadLine();
            }
        }

        static void TitleScreen()
        {
            Console.WriteLine("Heist II:");
            Console.WriteLine("iRobbing");
        }

        static IRobber CreateNewGoon()
        {
            Console.WriteLine("What kinda goon ya bringin' in?");
            Console.WriteLine(" (H)acker (Disables alarms)");
            Console.WriteLine(" (M)uscle (Disarms guards)");
            Console.WriteLine(" (L)ock Specialist (Cracks the vault)");
            bool specialtySelected = false;
            // Set a default in the current scope, which will change below
            IRobber newGoon = new Hacker();
            while (!specialtySelected)
            {
                string newGuySpecialty = Console.ReadLine();
                switch (newGuySpecialty.ToLower())
                {
                    case "h":
                    case "hacker":
                        newGoon = new Hacker()
                        {
                            Name = newGuyName
                        };
                        specialtySelected = true;
                        break;
                    case "m":
                    case "muscle":
                        newGoon = new Muscle()
                        {
                            Name = newGuyName
                        };
                        specialtySelected = true;
                        break;
                    case "l":
                    case "lock":
                    case "lock specialist":
                        newGoon = new LockSpecialist()
                        {
                            Name = newGuyName
                        };
                        specialtySelected = true;
                        break;
                    default:
                        Console.WriteLine("Quit messin' around! What's this creep do for a livin'?");
                        break;
                }
            }
            Console.WriteLine("And how good is this guy, on a scale from 0-100?  ");
            newGoon.SkillLevel = GetNumber();

            Console.WriteLine($"Alright. And what percentage does the distinguished {newGuyName} want for his 'services'?")
            newGoon.PercentageCut = GetNumber();

            return newGoon;

        }

        static int GetNumber()
        {
            int num = -1;
            bool validAnswer = false;
            while (!validAnswer)
            {
                string numStr = Console.ReadLine();
                bool isNumber = int.TryParse(numStr, out num);
                if (!isNumber || num < 0 || num > 100)
                {
                    Console.WriteLine("Look, pal, I ain't got all day. Gimme a number from 0 to 100. ");
                }
                else
                {
                    validAnswer = true;
                }
            }

            return num;

        }
    }
}
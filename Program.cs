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
        }

        static void TitleScreen()
        {
            Console.WriteLine("Heist II:");
            Console.WriteLine("iRobbing");
        }
    }
}
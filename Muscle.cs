using System;

namespace HeistII
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is taking care of the security guard. Decreased security {SkillLevel} points.");
            if (bank.SecurityGuardScore < 1)
            {
                Console.WriteLine($"{Name} has knocked out the security guard!");
            }

        }

    }
}
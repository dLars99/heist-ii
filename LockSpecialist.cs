using System;

namespace HeistII
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is picking the vault lock. Decreased security {SkillLevel} points.");
            if (bank.VaultScore < 1)
            {
                Console.WriteLine($"{Name} has unlocked the vault!");
            }

        }

    }
}
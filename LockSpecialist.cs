using System;

namespace BankHeist2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is cracking the vaults. Decreased security by {SkillLevel} points");
            if (bank.VaultScore <= 0)
                Console.WriteLine($"{Name} has released the Kraken!");
        }
    }
}
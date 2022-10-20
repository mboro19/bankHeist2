using System;

namespace BankHeist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} is taking down security guards. Decreased security by {SkillLevel} points");
            if (bank.SecurityGuardScore <= 0)
                Console.WriteLine($"{Name} has taken down all the guards!");
        }
    }
}
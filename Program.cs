using System;
using System.Collections.Generic;

namespace BankHeist2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRobber> rolodex = new List<IRobber>();

            {
                rolodex.Add(new Hacker { Name = "David", SkillLevel = 1, PercentageCut = 2 });
                rolodex.Add(new Hacker { Name = "Seth", SkillLevel = 9, PercentageCut = 11 });
                rolodex.Add(new Muscle { Name = "Zach", SkillLevel = 6, PercentageCut = 10 });
                rolodex.Add(new Muscle { Name = "Suth", SkillLevel = 3, PercentageCut = 15 });
                rolodex.Add(new LockSpecialist { Name = "Noah", SkillLevel = 5, PercentageCut = 10 });
                rolodex.Add(new LockSpecialist { Name = "Josh", SkillLevel = 1, PercentageCut = 3 });

            }
            while (true)
            {
                int robbers = rolodex.Count;
                Console.WriteLine("**------------------------**");
                Console.WriteLine($"Number of heist operatives: {robbers}");
                Console.WriteLine("**------------------------**");
                Console.WriteLine("What is the new crew members name?");
                Console.WriteLine("Answer: "); string newCrewMemberName = Console.ReadLine();
                if (string.IsNullOrEmpty(newCrewMemberName))
                {
                    break;
                }

                Console.WriteLine("**------------------------**");
                Console.WriteLine("What is this crew members specialty?");
                Console.WriteLine("1 - Hacker (Disables Alarms)");
                Console.WriteLine("2 - Muscle (Disarms Guards)");
                Console.WriteLine("3 - Lock Specialist (Cracks Vault)");
                Console.WriteLine("Answer: "); int newCrewMemberSpecialty = int.Parse(Console.ReadLine());
                Console.WriteLine("**------------------------**");
                Console.WriteLine("What is their skill level in their specialty (1-100)?");
                Console.WriteLine("Answer: "); int newCrewMemberSpecialtySkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("**------------------------**");
                Console.WriteLine("What is the new crew members cut in % ?");
                Console.WriteLine("Answer: "); int newCrewMembersCutPercentage = int.Parse(Console.ReadLine());
                Console.WriteLine("**------------------------**");

                if (newCrewMemberSpecialty == 1)
                {
                    rolodex.Add(new Hacker { Name = newCrewMemberName, SkillLevel = newCrewMemberSpecialtySkillLevel, PercentageCut = newCrewMembersCutPercentage });
                }
                else if (newCrewMemberSpecialty == 2)
                {
                    rolodex.Add(new Muscle { Name = newCrewMemberName, SkillLevel = newCrewMemberSpecialtySkillLevel, PercentageCut = newCrewMembersCutPercentage });
                }
                else if (newCrewMemberSpecialty == 3)
                {
                    rolodex.Add(new LockSpecialist { Name = newCrewMemberName, SkillLevel = newCrewMemberSpecialtySkillLevel, PercentageCut = newCrewMembersCutPercentage });
                }
                foreach (IRobber robber in rolodex)
                {Console.WriteLine($"{robber.Name}");}
                

            }
        }
    }
}

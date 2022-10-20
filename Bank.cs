using System;

namespace BankHeist2
{
    public class Bank
    {
        private int _allScores = 0;
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            get
            {
                return _allScores > 0;
            }
        }
    }
}

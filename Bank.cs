namespace HeistII
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure
        {
            get
            {
                return AlarmScore < 1 && VaultScore < 1 && SecurityGuardScore < 1;
            }
        }

    }
}
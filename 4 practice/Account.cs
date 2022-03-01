namespace _4_practice
{
    class Account
    {

        public string Name { get; set; }
        private decimal balance;
      

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }








        /*
        public void SetName(string accountName)
        {
            name = accountName;
        }

        public string GetName()
        {
            return name;
        }
        */
    }
}
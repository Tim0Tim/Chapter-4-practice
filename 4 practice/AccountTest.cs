using System;

namespace _4_practice
{
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green");
            Account account2 = new Account("John Blue");

            Console.WriteLine($"account 1 name is: {account1.Name}");
            Console.WriteLine($"account 2 name is: {account2.Name}");
        }
    }
}

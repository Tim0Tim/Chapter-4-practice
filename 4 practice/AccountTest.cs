using System;

namespace _4_practice
{
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            Console.WriteLine($"{account1.Name}'s balance : {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance : {account2.Balance:c}");

            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:c} to account1 valance\n");
            account1.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:c} to account2's balance");
            account2.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:c}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
        }
    }
}

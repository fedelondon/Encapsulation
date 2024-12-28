// Encapsulation

using Encapsulation.src;

// Bad Bank Account
BadBankAccount badAccount = new BadBankAccount();

badAccount.balance = 100;

Console.WriteLine(badAccount.balance);

// Bank Account
BankAccount account = new BankAccount(100);

account.Deposit(50);
Console.WriteLine(account.GetBalance());

account.Withdraw(25);
Console.WriteLine(account.GetBalance());

account.Withdraw(200);
Console.WriteLine(account.GetBalance());

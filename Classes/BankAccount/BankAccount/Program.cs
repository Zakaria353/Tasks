namespace Classes;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("Zak", 15);
        Console.WriteLine($"account {account.Number} was created for {account.Owner} with {account.Balance}" +
            $" initial balance ");
        account.MakeDeposit(11, DateTime.Now, "test dep");
        Console.WriteLine(account.Balance);
        account.MakeWithdrawal(12, DateTime.Now, "test withdr");
        Console.WriteLine(account.Balance);
        try
        {
            BankAccount account1 = new BankAccount("Zake", 15);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
        }
        try
        {
            account.MakeWithdrawal(1, DateTime.Now, "take one");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught trying to overdraw");
            Console.WriteLine(e.ToString());
        }
        Console.WriteLine(account.GetAccountHistory());

        Console.WriteLine("----------Gift----------");
        var giftCard = new GiftCardAccount("gift card", 100, 50);
        giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
        giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
        giftCard.PerformMonthEndTransactions();
        giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
        Console.WriteLine(giftCard.GetAccountHistory());

        Console.WriteLine("----------Interest----------");
        var savings = new InterestEarningAccount("savings account", 10000);
        savings.MakeDeposit(750, DateTime.Now, "save some money");
        savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
        savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
        savings.PerformMonthEndTransactions();
        Console.WriteLine(savings.GetAccountHistory());
        
        Console.WriteLine("----------Credit----------");
        var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
        // How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(999m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeWithdrawal(999m, DateTime.Now, "Take out monthly advance2");
        lineOfCredit.MakeWithdrawal(3m, DateTime.Now, "Take out monthly advance3");
        lineOfCredit.MakeWithdrawal(3m, DateTime.Now, "Take out monthly advance3");
        //lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        //lineOfCredit.MakeWithdrawal(900m, DateTime.Now, "Emergency funds for repairs");
        //lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        //lineOfCredit.MakeWithdrawal(900m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.PerformMonthEndTransactions();
        Console.WriteLine(lineOfCredit.GetAccountHistory());

    }
}

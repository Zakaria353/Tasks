using System.Text;

namespace Classes;

public class BankAccount
{

    private List<Transaction> allTransactions = new List<Transaction>();

    public string Number { get; }
    public string? Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;

        }

    }
    private static int accountNumberSeed = 1234567890;

    private readonly decimal _minimumBalance ;

    public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

    public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
    {
        Number = accountNumberSeed.ToString();
        accountNumberSeed++;
        Owner = name;
        _minimumBalance = minimumBalance;
        if (initialBalance > 0)
        MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

    }

    public virtual decimal PerformMonthEndTransactions() 
    {
        return 0;
    }

    public void MakeDeposit(decimal amount, DateTime date, string notes)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("0 or non positive deposit not allowed");
        }
        var deposit = new Transaction(amount, date, notes);
        allTransactions.Add(deposit);

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        }
        Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
        Transaction? withdrawal = new(-amount, date, note);
        allTransactions.Add(withdrawal);
        if (overdraftTransaction != null)
            allTransactions.Add(overdraftTransaction);
    }

    protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn)
    {
        if (isOverdrawn)
        {
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        }
        else
        {
            return default;
        }
    }

    public string GetAccountHistory()
    {
        var report = new StringBuilder();
        decimal balance = 0;
        report.AppendLine("Date\t\tAmount\tBalance\tNote");
        foreach (var item in allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance} {item.Notes}");
        }
        return report.ToString();
    }
}

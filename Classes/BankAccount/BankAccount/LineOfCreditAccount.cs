namespace Classes;

public class LineOfCreditAccount : BankAccount
{
    public decimal result;
    public LineOfCreditAccount(string name, decimal initialBalance, decimal creditLimit)
        : base(name, initialBalance, -creditLimit)
    {

    }

    public override decimal PerformMonthEndTransactions()
    {   

        if (Balance < 0)
        {
            decimal interest = -Balance * 0.07m;
            result= interest;
            MakeWithdrawal(interest, DateTime.Now, "Monthly interest charge");
           
        }

        return 0;
    }
    protected override Transaction? CheckWithdrawalLimit(bool isOverdrawn) =>

        (isOverdrawn && result == 0) ? new Transaction(-20, DateTime.Now, "Apply overdraft fee")
        : default;
}
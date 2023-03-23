using System;
namespace Classes;


public class InterestEarningAccount : BankAccount
{
    public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
    {

    }

    public override decimal PerformMonthEndTransactions()
    {
        if(Balance > 13m)
        {
            decimal interest = Balance * 0.02m;
            MakeDeposit(interest, DateTime.Now, "Earned interest");
        }
        return 0;
    }   
}

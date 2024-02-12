namespace POO.Heranca
{
    public class BusinessAccount : Account //especialização
    {
        public double LoanLimit { get; set; } //limite de emprestimo
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
                : base(number, holder, balance) 
        {
            LoanLimit = loanLimit;
        }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void WithDraw(double amount)
        {
            throw new NotImplementedException();
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit) Balance += amount;
        }
    }
}
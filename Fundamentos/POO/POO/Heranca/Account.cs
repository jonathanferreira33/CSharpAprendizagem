namespace POO.Heranca
{
    public class Account //generalização
    {
        public int Number { get; set; }
        public string Holder { get; set; } //titular
        public double Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, double balance) 
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount) //saque | virtual = pode ser subrescrito ou sobreposto
        { 
            Balance -= amount + 5.0;
        } 
        public void Deposit(double amount)
        {
            Balance += amount;
        } 

    }
}
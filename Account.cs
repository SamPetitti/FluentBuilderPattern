namespace FluentBuilderPattern
{
    public interface IAccount
    {
        decimal Balance { get; set; }

        void Deposit(decimal amount);
        void WithDrawl(decimal amount);
    }

    public class Account : IAccount
    {
        public decimal Balance { get; set; }

        public void WithDrawl(decimal amount)
        {
            this.Balance = this.Balance - amount;
        }

        public void Deposit(decimal amount)
        {
            this.Balance = this.Balance += amount; 
        }
    }
}
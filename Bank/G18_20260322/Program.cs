namespace G18_20260322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VisaCard card1 = new VisaCard(
                "1234567812345678", 
                "John Doe", 
                DateTime.Now.AddYears(1), 
                "123");
            VisaCard card2 = new VisaCard(
                "8765432187654321", 
                "Jane Smith", 
                DateTime.Now.AddYears(2), 
                "456");

            BankProcessing.Deposit(card1, 1000m);
            BankProcessing.Withdraw(card1, 200m);
            BankProcessing.Transfer(card1, card2, 300m);
        }
    }
}

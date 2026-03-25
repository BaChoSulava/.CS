namespace G18_20260322;

public static class BankProcessing
{
    public static void Deposit(VisaCard card, decimal amount)
    {
        if (card == null)
            throw new ArgumentNullException(nameof(card));
        card.Deposit(amount);
        Log($"Deposited {amount:C} to card {card.CardNumber}. New balance: {card.Balance:C}", ConsoleColor.Green);
    }

    public static void Withdraw(VisaCard card, decimal amount)
    {
        if (card == null)
            throw new ArgumentNullException(nameof(card));
        card.Withdraw(amount);
        Log($"Withdrew {amount:C} from card {card.CardNumber}. New balance: {card.Balance:C}", ConsoleColor.Red);
    }

    public static void Transfer(VisaCard fromCard, VisaCard toCard, decimal amount)
    {
        if (fromCard == null)
            throw new ArgumentNullException(nameof(fromCard));
        if (toCard == null)
            throw new ArgumentNullException(nameof(toCard));
        fromCard.Withdraw(amount);
        toCard.Deposit(amount);
        Log($"Transferred {amount:C} from card {fromCard.CardNumber} to card {toCard.CardNumber}. New balances: {fromCard.Balance:C} (from), {toCard.Balance:C} (to)", ConsoleColor.Yellow);
    }

    private static void Log(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
namespace G18_20260322;

public class VisaCard
{
    public VisaCard(string cardNumber, string cardHolderName, DateTime expireDate, string cvv)
    {
        ValidateCardData(cardNumber, cardHolderName, expireDate, cvv);
        CardNumber = cardNumber;
        CardHolderName = cardHolderName;
        ExpireDate = expireDate;
        CVV = cvv;
    }

    public string CardNumber { get; }
    public string CardHolderName { get; }
    public DateTime ExpireDate { get; }
    public string CVV { get; }
    public decimal Balance { get; private set; }
    public decimal WithdrawalTaxRate => 0.02m; // 2% tax on withdrawals
                                               //TODO: Implement functionality for tax calculation while withdraw.

    internal void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        Balance += amount;
    }

    internal void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }

        decimal tax = amount * WithdrawalTaxRate;   // TODO
        decimal amountPlusTax = amount + tax;   // TODO
        if (amountPlusTax > Balance)      // TODO
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Balance -= amountPlusTax;      // TODO
    }

    private static void ValidateCardData(string cardNumber, string cardHolderName, DateTime expireDate, string cvv)
    {
        if (string.IsNullOrWhiteSpace(cardNumber) ||
            cardNumber.Length != 16 ||
            cardNumber.Any(c => !char.IsDigit(c)))
        {
            throw new ArgumentException("Invalid card number.");
        }

        if (string.IsNullOrWhiteSpace(cardHolderName))
        {
            throw new ArgumentException("Card holder name cannot be empty.");
        }

        if (expireDate <= DateTime.Now)
        {
            throw new ArgumentException("Card has expired.");
        }

        if (string.IsNullOrWhiteSpace(cvv) ||
            cvv.Length != 3 ||
            cvv.Any(c => !char.IsDigit(c)))
        {
            throw new ArgumentException("Invalid CVV.");
        }
    }
}

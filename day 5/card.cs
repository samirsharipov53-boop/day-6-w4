public class PaymentCard
{
    private double balance;

    public PaymentCard(double openingBalance)
    {
        balance = openingBalance;
    }

    public double Balance()
    {
        return balance;
    }

    public void AddMoney(double increase)
    {
        balance += increase;
    }

    public bool TakeMoney(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            return true;
        }

        return false;
    }
}
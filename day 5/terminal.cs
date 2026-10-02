public class PaymentTerminal
{
    private double cashRegister;

    public PaymentTerminal()
    {
        cashRegister = 0;
    }

    public double EatLunch(double payment)
    {
        double lunchPrice = 2.50;

        if (payment >= lunchPrice)
        {
            cashRegister += lunchPrice;
            return payment - lunchPrice;
        }

        return payment;
    }

    public bool EatLunch(PaymentCard card)
    {
        double lunchPrice = 2.50;

        return card.TakeMoney(lunchPrice);
    }

    public double AddMoneyToCard(PaymentCard card, double amount)
    {
        card.AddMoney(amount);
        cashRegister += amount;

        return amount;
    }
}
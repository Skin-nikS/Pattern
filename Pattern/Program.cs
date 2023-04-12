public interface ICalculator
{
    void CalculateInterest(Account account);
}

public class Calculator : ICalculator
{
    public void CalculateInterest(Account account)
    {
        if (account.Type == "Обычный")
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000 && account.Balance < 50000)
                account.Interest += account.Balance * 0.02;

            if (account.Balance >= 50000)
                account.Interest += account.Balance * 0.04;
        }
        else if (account.Type == "Зарплатный")
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;
        }
    }
}

public interface IAccount
{
    string Type { get; set; }
    double Balance { get; set; }
    double Interest { get; set; }
}

public class Account : IAccount
{
    public string Type { get; set; }
    public double Balance { get; set; }
    public double Interest { get; set; }
}
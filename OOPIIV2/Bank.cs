public class Bank
{
    private double balance;
    private double accountNumber;


    public Bank()
    {
        balance = 987654329763646747;
        accountNumber = 1223348545490;
    }

    public double Withdrew(int amount)
    {
        if(amount > 0)
            balance-=amount;
        
        return amount;
    }

}
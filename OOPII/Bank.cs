public class Bank
{
    private int pin;
    private double accountNumber;
    private double balance;



    public Bank()
    {
        pin = -1;
        accountNumber = -1;
        balance = 0;
    }

    public void SetBalance(double _balance)
    {
        if(_balance >= 0){
            balance = _balance;
        }
        
    }

    public double GetBalance()
    {
        return balance;
    }
}
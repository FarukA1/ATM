using System;

public class cardHolder
{
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public String getCardNunber()
    {
        return cardNumber;
    }

    public void setCardNumbber(String cardNumber)
    {
        this.cardNumber = cardNumber;
    }


    public int getPin()
    {
        return pin;
    }

    public void setPin(int pin)
    {
        this.pin = pin;
    }


    public String getFirstName()
    {
        return firstName;
    }

    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }


    public String getLastName()
    {
        return lastName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }


    public double getBalance()
    {
        return balance;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }


    public cardHolder(String cardNumber, int pin, String firstName, String lastName,
        double balance)
    {
        this.cardNumber = cardNumber;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }
}


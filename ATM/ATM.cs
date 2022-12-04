using System;

public class ATM
{
    public static void Main(String[] args)
    {
        void printOPtions()
        {
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much ££ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you, your deposit is successful and your new balance is:  " + currentUser.getBalance());
        }


        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much ££ would you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());

            if(currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance!");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Thank you, your withdrawal is successful and your new balance is:  " + currentUser.getBalance());
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current Balance: " + currentUser.getBalance());
        }


        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("87258934240987", 1234, "Will", "Smith", 150.55));
        cardHolders.Add(new cardHolder("09869327097090", 1234, "John", "Carter", 350.01));
        cardHolders.Add(new cardHolder("65628792778921", 1234, "Alex", "Morgan", 25.44));
        cardHolders.Add(new cardHolder("78219781090783", 1234, "Mark", "Dicken", 478.92));
        cardHolders.Add(new cardHolder("76832891278992", 1234, "Oliver", "Adan", 345.89));


        Console.WriteLine("Welcome to ATM");
        Console.WriteLine("Please insert your debit card");
        String debitNum = "";
        cardHolder currentUser;

        while (true)
        {
            try
            {
                debitNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.getCardNunber() == debitNum);
                if(currentUser != null) { break; }
                else
                {
                    Console.WriteLine("Card not recognised. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Card not recognised. Please try again");
            }
        }

        Console.WriteLine("Please enter your pin: ");
        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());
                if (currentUser.getPin() == userPin) { break; }
                else
                {
                    Console.WriteLine("Incorrect Pin. Please try again");
                }
            }
            catch
            {
                Console.WriteLine("Incorrect Pin. Please try again");
            }
        }

        Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");
        int option = 0;
        do
        {
            printOPtions();
            try
            {
                option = int.Parse(Console.ReadLine());
            }catch { }

            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4); 
        Console.WriteLine("Thank you! have a nice day");

    }
}



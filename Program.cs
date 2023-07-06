class Atm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Dıtdıt Bank");
        Random rnd = new Random();
        int amount = rnd.Next(100000);

        Console.WriteLine("Your current balance: " + amount);
        Console.WriteLine("To add money, enter 1. To withdraw money, enter 2. To exit, enter 3.");

        int choice;
        bool validChoice = int.TryParse(Console.ReadLine(), out choice);

        if (!validChoice || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Exiting the program.");
            return;
        }

        if (choice == 1)
        {
            Console.WriteLine("Enter the amount to add: ");
            int add;
            bool validAmount = int.TryParse(Console.ReadLine(), out add);

            if (!validAmount || add <= 0)
            {
                Console.WriteLine("Invalid amount. Operation canceled.");
            }
            else
            {
                int newBalance = AddMoney(amount, add);
                Console.WriteLine("New balance: " + newBalance);
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter the amount to withdraw: ");
            int withdraw;
            bool validAmount = int.TryParse(Console.ReadLine(), out withdraw);

            if (!validAmount || withdraw <= 0)
            {
                Console.WriteLine("Invalid amount. Operation canceled.");
            }
            else
            {
                int newBalance = WithdrawMoney(amount, withdraw);
                if (newBalance == -1)
                {
                    Console.WriteLine("Insufficient balance. Withdrawal canceled.");
                }
                else
                {
                    Console.WriteLine("New balance: " + newBalance);
                }
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Thank you for choosing our bank. Have a nice day!");
        }

    }

    public static int AddMoney(int balance, int amount)
    {
        return balance + amount;
    }

    public static int WithdrawMoney(int balance, int amount)
    {
        if (balance >= amount)
        {
            return balance - amount;
        }
        else
        {
            return -1;
        }
    }
}
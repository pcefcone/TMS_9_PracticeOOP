using System;
using TMS_9_PracticeOOP.Bank;
using TMS_9_PracticeOOP.Cars;

internal class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Put your balance: ");
            string balance = Console.ReadLine();
            Console.WriteLine("Put bank rate: ");
            string interestRate = Console.ReadLine();
            Console.WriteLine("How many years you will save your deposit?");
            string years = Console.ReadLine();
            if (double.TryParse(balance, out double balanceResult) &&
                double.TryParse(interestRate, out double interestRateResult) && int.TryParse(years, out int yearsResult))
            {
                Debit amount = new Debit(balanceResult, interestRateResult);
                amount.PrintBalance();
                amount.WaitOneYear();
                amount.Credit(yearsResult);

                Car car = new Car(0);
                car.Drive();
                car.Refuel(40);
                car.Drive();

                car = new Truck(0);
                car.Drive();
                car.Refuel(50);
                car.Drive();

                car = new SportCar(0);
                car.Drive();
                car.Refuel(44);
                car.Drive();
            }
            Console.WriteLine("Input data must be numbers, please try again");
        }
        Console.WriteLine("Press any key to exit programm");
        Console.ReadKey();
    }



}
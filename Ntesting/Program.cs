namespace Ntesting
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Y= years to pay off a P=principal loan amount at R= percent interest ");
            int Y = Convert.ToInt32(Console.ReadLine());
            int P = Convert.ToInt32(Console.ReadLine());
            int R = Convert.ToInt32(Console.ReadLine());
            MonthlyPay.PaymentOfMonth(Y, P, R);

            Console.WriteLine("enter the temp");
            int temp = Convert.ToInt32(Console.ReadLine());
            TemperatureConversion.TemperatureConversionFahrenheit_To_Celsius(temp);
            TemperatureConversion.TemperatureConversionCelsius_To_Fahrenheit(temp);


            VendingMachine vendingMachine = new VendingMachine();
            int ammount = Convert.ToInt32(Console.ReadLine());
            vendingMachine.ChangeAmmount(ammount);
            vendingMachine.Print();


            Console.WriteLine("Welcome to the weekly Calendar");

            Console.WriteLine("Enter the date of the month 1-30");
            int d = Convert.ToInt32(Console.ReadLine()); //date
            Console.WriteLine("For month ,select 1-January,2-february,3-march,4-april,5-may,6-june,7-july,8-august,9-september,10-october,11-november,12-december");
            int m = Convert.ToInt32(Console.ReadLine()); //month
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine()); //year

            WeekCalander.Week(d, m, y);

        }
    }
}
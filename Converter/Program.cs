class Program
{
    static void Main()
    {
        // Create an instance of the Converter class with conversion rates
        Converter converter = new Converter(27.0, 32.5, 7.8);

        // Convert from UAH to USD
        double amountInUah = 1000;
        double amountInUsd = converter.ConvertToUsd(amountInUah);
        Console.WriteLine($"{amountInUah} UAH is approximately {amountInUsd:F2} USD");

        // Convert from USD to UAH
        double convertedBackToUah = converter.ConvertFromUsd(amountInUsd);
        Console.WriteLine($"{amountInUsd:F2} USD is approximately {convertedBackToUah:F2} UAH");
    }
}

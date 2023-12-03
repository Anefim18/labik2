using System;

class Converter
{
    private double usdRate;
    private double eurRate;
    private double plnRate;

    // Constructor to initialize conversion rates
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    // Convert from UAH to USD
    public double ConvertToUsd(double amountInUah)
    {
        return amountInUah / usdRate;
    }

    // Convert from UAH to EUR
    public double ConvertToEur(double amountInUah)
    {
        return amountInUah / eurRate;
    }

    // Convert from UAH to PLN
    public double ConvertToPln(double amountInUah)
    {
        return amountInUah / plnRate;
    }

    // Convert from USD to UAH
    public double ConvertFromUsd(double amountInUsd)
    {
        return amountInUsd * usdRate;
    }

    // Convert from EUR to UAH
    public double ConvertFromEur(double amountInEur)
    {
        return amountInEur * eurRate;
    }

    // Convert from PLN to UAH
    public double ConvertFromPln(double amountInPln)
    {
        return amountInPln * plnRate;
    }
}

namespace CurrencyExchangeCalculator.Model;

public class DayRate
{
    public string table { get; set; }
    public string no { get; set; }
    public string effectiveDate { get; set; }
    public Rate[] rates { get; set; }
}

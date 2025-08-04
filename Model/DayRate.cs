namespace CurrencyExchangeCalculator.Model;

public class DayRate
{
    public string table { get; set; }
    public string no { get; set; }
    public DateTime effectiveDate { get; set; }
    public Rate[] rates { get; set; }
}

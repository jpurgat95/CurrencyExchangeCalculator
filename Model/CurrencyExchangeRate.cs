namespace CurrencyExchangeCalculator.Model;

public class CurrencyExchangeRate
{
    public int Id { get; set; }
    public string CurrencyName {  get; set; }
    public string CurrenyCode {  get; set; }
    public DateTime Date {  get; set; }
    public decimal Rate { get; set; }
}

# CurrencyExchangeCalculator
## Short description
`Currency Exchange Calculator` is a web application which connects with National Bank of Poland API to fetch data about currencies exchange rates. 
It also connects with local sql database to store the data from API. `Currency ExchangeCalculator` consists of two razor components: `Calc.razor` and `CurrenciesTable.razor`.
`CurrenciesTable.razor` is a razor page which displays `Currencies Exchange Rates from NBP` table which includes information about currencies exchange rates.
`Calc.razor` is a razor page which converts current currency amount into a currency to buy amount. It is also the home page.
`Radzen Blazor` NuGet package was used in the project.

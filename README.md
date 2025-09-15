# Kalkulator wymiany walut
## Krótki opis
`Kalkulator wymiany walut` to aplikacja webowa, która łączy się z API Narodowego Banku Polskiego, aby pobierać dane o kursach wymiany walut.  
Łączy się również z lokalną bazą danych SQL, aby przechowywać dane pobrane z API.  
`Kalkulator wymiany walut` składa się z dwóch komponentów Razor: `Calc.razor` i `CurrenciesTable.razor`.  
`CurrenciesTable.razor` to strona Razor, która wyświetla tabelę „Kursy walut z NBP” zawierającą informacje o kursach walut.  
`Calc.razor` to strona Razor, która konwertuje podaną kwotę z aktualnej waluty na walutę docelową. Jest to również strona główna aplikacji.  
W projekcie wykorzystano pakiet NuGet `Radzen Blazor`.

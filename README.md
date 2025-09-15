# Kalkulator wymiany walut
## Krótki opis
`Kalkulator wymiany walut` to aplikacja webowa, która łączy się z API Narodowego Banku Polskiego, aby pobierać dane o kursach wymiany walut.  
Łączy się również z lokalną bazą danych SQL, aby przechowywać dane pobrane z API - [`CurrencyDb`](https://github.com/user-attachments/assets/e6b7038f-4738-4927-a3e0-a59207f2703e).
`Kalkulator wymiany walut` składa się z dwóch komponentów Razor: `Calc.razor` i `CurrenciesTable.razor`.  
`CurrenciesTable.razor` to strona Razor, która wyświetla tabelę „Kursy walut z NBP” zawierającą informacje o kursach walut: [`Screenshot 1`](https://github.com/user-attachments/assets/b17e415a-e3f8-4518-bcc0-499142f132ee") , [`Screenshot 2`](https://github.com/user-attachments/assets/0338ceef-3c7f-4535-9625-23f786d87155).  
`Calc.razor` to strona Razor, która konwertuje podaną kwotę z aktualnej waluty na walutę docelową. Jest to również strona główna aplikacji: [`przed zamianą`](https://github.com/user-attachments/assets/f01ac7ee-8e0d-4f72-9c33-054c57dcdf24) , [`po zamianie`](https://github.com/user-attachments/assets/309287e6-9ba0-44fd-b003-e79a122c1d6d).  
W projekcie wykorzystano pakiet NuGet `Radzen Blazor`.

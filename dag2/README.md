   <!-- class: center, middle -->

# Fsharpskolen
## Dag 2

---

# En slags agenda
* Lister - [oppgaver](lister)
* Pattern matching - [oppgaver](pattern-matching)
* Discriminated unions - [oppgaver](discriminatedUnions)
* Records - [oppgaver](records)
* Moduler og innkapsling - [eksempler](modules)
* DDD

---

# Oppvarming
## Oppgaven intersperse-list
* Lag funksjonen 'intersperse
* Funksjonen skal ta et element 'value' og en liste av elementer av samme type
* Funksjonen skal produsere en ny liste med 'value'-elementet spredd innimellom elementene i den opprinnelige listen.

```fsharp
intersperse 0 [1 .. 5] -> [1;0;2;0;3;0;4;0;5]
```

```fsharp
intersperse "foo" [ "hello"; "dear"; "friends" ] -> [ "hello"; "foo"; "dear"; "foo"; "friends" ]
```

```fsharp
intersperse [] [ []; []; [] ] -> [ []; []; []; []; [] ]
```

---

# Discriminated unions og pattern matching

---

# Records

---

# Moduler

---

# DDD

---

# Bygge domenet ved å sette sammen typer
Eksempel fra boka

```fsharp
type PhoneNumber = PhoneNumber of int
type CardNumber = CardNumber of string
```

```fsharp
type CardType = Visa | MasterCard
```

```fsharp
type CreditCardInfo = {
    CardType: CardType
    CardNumber: CardNumber
}
```

---

# Bygge domenet del 2

```fsharp
type PaymentMethod = 
| Cash
| Vipps of PhoneNumber
| Card of CreditCardInfo
```

```fsharp
type PaymentAmount = PaymentAmount of decimal
type Currency = NOK | EUR
```

```fsharp
type Payment = {
    Amount: PaymentAmount
    Currency: Currency
    Method: PaymentMethod
}
```

```fsharp
type PayInvoice = UnpaidInvoice -> Payment -> PaidInvoice
```

---

# Patterns

* Enkle verdier
* Kombinasjoner av verdier med records
* Valg av verdier med DU
* Workflows


```fsharp
```

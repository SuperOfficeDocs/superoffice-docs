---
title: Currency
uid: crmscript_currency
SortOrder: 60
---

Currency options depend on a couple of things:

* Whether the use of currency has been enabled
* The base currency setting
* The local (own) currency setting

> [!NOTE]
> If the sale has a **quote**, you will not be able to set or change the currency of that sale.

Currency exchange rates are fixed and apply to all sales. You can change them manually in the SuperOffice Admin client (or programmatically).

## Base currency

The **base currency** is the currency with an exchange rate equal to 1. Other exchange rates are expressed relative to this.

### View base currency

```crmscript!
NSListAgent listAgent;
printLine("Base currency: " + listAgent.GetBaseCurrency().GetName());
```

> [!CAUTION]
> Make sure the currency-related preferences are set before using `GetBaseCurrency()`. Otherwise, you might end up with a default value that produces some interesting conversion results!

## List currencies and their conversion rate

### Using the SearchEngine

```crmscript!
SearchEngine se;
se.addFields("Currency", "Currency_id,name,rate,units");
print(se.executeTextTable());
```

### Using the listAgent

```crmscript!
NSListAgent listAgent;
NSCurrencyEntity[] currencyList = listAgent.GetAllCurrencies(false);
for(Integer i = 0; i < currencyList.length(); i++) {
  printLine(currencyList[i].GetCurrencyId().toString() + " | " + currencyList[i].GetName() + "\t Rate: " + currencyList[i].GetRate().toString(1) + "\t Units: " + currencyList[i].GetUnits().toString(1));
}
```

> [!TIP]
> Calling `GetCurrencies()` will give you the slim **NSCurrency** items. If you need more info than name and ID - such as the rate and units - then you need to retrieve the complex **NSCurrencyEntity**.

## How currency conversion works

1. Get the amount and **currency ID** from the sale.
2. Using the list agent, get the relevant NSCurrencyEntity and extract the rate and currency unit.
3. Do the math.

### Convert to the base currency

Divide by rate and multiply by units.

```crmscript!
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

NSCurrencyEntity currency = listAgent.GetCurrencyEntity(sale.GetCurrency().GetId());

Float amount = sale.GetAmount();
Float rate = currency.GetRate();
Float units = currency.GetUnits();

Float result = amount/rate*units;

printLine(amount.toString(1) + " in " + currency.GetName() + " equals " + result.toString(2) + " in " + listAgent.GetBaseCurrency().GetName());
```

### Convert from the base currency

Divide by units and multiply by rate.

In this case, you need to call `GetCurrencyEntity()` with the ID of the **target** currency, not the one obtained from the sale!

```crmscript
NSListAgent listAgent;
NSSaleAgent saleAgent;

NSSaleEntity sale = saleAgent.GetSaleEntity(4);

NSCurrencyEntity currency = listAgent.GetCurrencyEntity(77);

Float result = sale.GetAmount()/currency.GetUnits()*currency.GetRate();

printLine(amount.toString(1) + " in " + listAgent.GetBaseCurrency().GetName() + " equals " + convertedAmount.toString(2) + " in " + currency.GetName());
```

## Convert between any 2 currencies

You can either do a 2-step conversion via the base currency **or** calculate the relative rate between those 2 currencies and apply that directly. The latter is more efficient if you'll be doing multiple conversions

In this example, we assume we know the ID of the start and target currency and also the amount to be converted. Thus, we don't go via the sale object.

```crmscript!
Integer startCurrencyId = 76;
Integer targetCurrencyId = 27;
Float amount = 1000.0;

NSListAgent listAgent;
NSCurrencyEntity currencyA = listAgent.GetCurrencyEntity(startCurrencyId);
NSCurrencyEntity currencyB = listAgent.GetCurrencyEntity(targetCurrencyId);

Float conversionRate = (currencyA.GetRate()*currencyB.GetUnits())/(currencyA.GetUnits()*currencyB.GetRate());

Float result = amount*conversionRate;

printLine(amount.toString(2) + currencyA.GetName() + " is " + result.toString(2) + currencyB.GetName());
printLine("Relative exchange rate: " + conversionRate.toString(2));
```

> [!TIP]
> This works even if 1 of the IDs represent the base currency! Thus you could wrap it up in a reusable function:

```crmscript!

Float convertCurrency(Float amount, Integer startCurrencyId, Integer targetCurrencyId) {
  NSListAgent listAgent;
  NSCurrencyEntity currencyA = listAgent.GetCurrencyEntity(startCurrencyId);
  NSCurrencyEntity currencyB = listAgent.GetCurrencyEntity(targetCurrencyId);

  Float conversionRate = (currencyA.GetRate()*currencyB.GetUnits())/(currencyA.GetUnits()*currencyB.GetRate());

  return amount * conversionRate;
}

Float amount = 1000.0;
printLine(convertCurrency(amount, 76, 27).toString(2));
```

---
uid: crmscript_ref_NSListAgent_ChangeCurrency
title: Float ChangeCurrency(Float amount, String fromCurrency, String toCurrency)
intellisense: NSListAgent.ChangeCurrency
keywords: NSListAgent, ChangeCurrency
so.topic: reference
---

Recalculates the amount to the new currency.

**Parameters:**
 - **amount** The amount in the old currency
 - **fromCurrency** The old currency name
 - **toCurrency** The new currency name

**Returns:** Amount in new currency

```crmscript
NSListAgent agent;
Float amount;
String fromCurrency;
String toCurrency;
Float res = agent.ChangeCurrency(amount, fromCurrency, toCurrency);
```


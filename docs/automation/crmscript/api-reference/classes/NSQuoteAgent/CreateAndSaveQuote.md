---
uid: crmscript_ref_NSQuoteAgent_CreateAndSaveQuote
title: QuoteEntity CreateAndSaveQuote(Integer saleId, Integer connectionId, String firstAlternativeName)
intellisense: NSQuoteAgent.CreateAndSaveQuote
keywords: NSQuoteAgent, CreateAndSaveQuote
so.topic: reference
---

Creates a new quote on a sale.

**Parameters:**
 - **saleId** SaleId of the connected sale
 - **connectionId** ConnectionId
 - **firstAlternativeName** Name to be given to the default alternative

**Returns:** Quote carrier

```crmscript
NSQuoteAgent agent;
Integer saleId;
Integer connectionId;
String firstAlternativeName;
QuoteEntity res = agent.CreateAndSaveQuote(saleId, connectionId, firstAlternativeName);
```


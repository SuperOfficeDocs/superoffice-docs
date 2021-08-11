---
uid: crmscript_ref_NSQuoteAgent_CreateAndSaveQuote
title: NSQuoteEntity CreateAndSaveQuote(Integer saleId, Integer connectionId, String firstAlternativeName)
intellisense: NSQuoteAgent.CreateAndSaveQuote
keywords: NSQuoteAgent, CreateAndSaveQuote
so.topic: reference
---

# NSQuoteEntity CreateAndSaveQuote(Integer saleId, Integer connectionId, String firstAlternativeName)

Creates a new quote on a sale.

**Parameters:**
 - **saleId** SaleId of the connected sale
 - **connectionId** ConnectionId
 - **firstAlternativeName** Name to be given to the default alternative

**Returns:** NSQuoteEntity

```crmscript
NSQuoteAgent agent;
Integer saleId;
Integer connectionId;
String firstAlternativeName;
NSQuoteEntity res = agent.CreateAndSaveQuote(saleId, connectionId, firstAlternativeName);
```


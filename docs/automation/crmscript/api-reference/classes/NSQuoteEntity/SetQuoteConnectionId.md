---
uid: crmscript_ref_NSQuoteEntity_SetQuoteConnectionId
title: SetQuoteConnectionId(Integer quoteConnectionId)
intellisense: NSQuoteEntity.SetQuoteConnectionId
keywords: NSQuoteEntity, GetQuoteConnectionId
so.topic: reference
---

# SetQuoteConnectionId(Integer quoteConnectionId)

The connection in the CRM system to where this quote came from. Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection.

**Parameter:** 
 - **quoteConnectionId** Integer

```crmscript
NSQuoteEntity thing;
Integer quoteConnectionId;
thing.SetQuoteConnectionId(quoteConnectionId);
```


---
uid: crmscript_ref_NSQuoteEntity_GetQuoteConnectionId
title: Integer GetQuoteConnectionId()
intellisense: NSQuoteEntity.GetQuoteConnectionId
keywords: NSQuoteEntity, GetQuoteConnectionId
so.topic: reference
---

# Integer GetQuoteConnectionId()

The connection in the CRM system to where this quote came from. Identifies the ERP connection used for this quote. Each quote is bound to one and only one connection.

**Returns:** Integer

```crmscript
NSQuoteEntity thing;
Integer quoteConnectionId  = thing.GetQuoteConnectionId();
```


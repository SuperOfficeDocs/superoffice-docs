---
uid: crmscript_ref_NSSaleAgent_GetNextDueDate
title: DateTime GetNextDueDate(Integer saleId)
intellisense: NSSaleAgent.GetNextDueDate
keywords: NSSaleAgent, GetNextDueDate
so.topic: reference
---

Gets the next due date for a sale. The next due date is the next future appointment that is not completed.

**Parameters:**
 - **saleId** Sale id

**Returns:** Next due date for the given sale.

```crmscript
NSSaleAgent agent;
Integer saleId;
DateTime res = agent.GetNextDueDate(saleId);
```


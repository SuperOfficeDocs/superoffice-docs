---
uid: crmscript_ref_NSArchiveRestrictionInfo_SetInterOperator
title: SetInterOperator(Integer interOperator)
intellisense: NSArchiveRestrictionInfo.SetInterOperator
keywords: NSArchiveRestrictionInfo, GetInterOperator
so.topic: reference
---

Get or set the inter-restriction operator that describes how this restriction is related to the next one in an array. Default for new ArchiveRestrictionInfo objects is And

**Parameter:** 
 - **interOperator** Integer
     - Enum: 0 = None 
     - Enum: 1 = And 
     - Enum: 2 = Or 

```crmscript
NSArchiveRestrictionInfo thing;
Integer interOperator;
thing.SetInterOperator(interOperator);
```


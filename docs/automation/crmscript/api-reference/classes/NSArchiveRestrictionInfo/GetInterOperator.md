---
uid: crmscript_ref_NSArchiveRestrictionInfo_GetInterOperator
title: Integer GetInterOperator()
intellisense: NSArchiveRestrictionInfo.GetInterOperator
keywords: NSArchiveRestrictionInfo, GetInterOperator
so.topic: reference
---

# Integer GetInterOperator()

Get or set the inter-restriction operator that describes how this restriction is related to the next one in an array. Default for new ArchiveRestrictionInfo objects is And

**Returns:** Integer

     - Enum: 0 = None 
     - Enum: 1 = And 
     - Enum: 2 = Or 

```crmscript
NSArchiveRestrictionInfo thing;
Integer interOperator  = thing.GetInterOperator();
```


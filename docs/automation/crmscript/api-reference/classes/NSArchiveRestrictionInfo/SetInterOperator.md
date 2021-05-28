---
uid: crmscript_class_nsarchiverestrictioninfo_setinteroperator
title: SetInterOperator(Integer interOperator)
description: CRMScript method in the NSArchiveRestrictionInfo class that sets the inter-restriction operator
intellisense: NSArchiveRestrictionInfo.SetInterOperator
keywords: NSArchiveRestrictionInfo, SetInterOperator
so.topic: reference
---

# SetInterOperator()

Sets the inter-restriction operator that describes how this restriction is related to the next one in an array.

The default for new `ArchiveRestrictionInfo` objects is *And*.

## Parameter

| Parameter | Type | Description |
|---|---|---|
| interOperator | Integer | Enum:<br>0 = None<br>1 = And<br>2 = Or |

## Examples

```crmscript
NSArchiveRestrictionInfo thing;
Integer interOperator;
thing.SetInterOperator(interOperator);
```

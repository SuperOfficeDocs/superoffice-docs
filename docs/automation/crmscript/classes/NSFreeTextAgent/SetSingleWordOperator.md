---
title: crmscript_ref_NSFreeTextAgent_SetSingleWordOperator
description: Void SetSingleWordOperator(Integer freeTextOperator)
intellisense: NSFreeTextAgent.SetSingleWordOperator
keywords: NSFreeTextAgent,SetSingleWordOperator
so.topic: reference
---

Sets the operator used when matching single words

**Parameters:**
 - **freeTextOperator** The operator
     - Enum: 1 = Contains 
     - Enum: 2 = StartsWith 
     - Enum: 3 = ExactMatch 

**Returns:** This method has no return value

```crmscript
NSFreeTextAgent agent;
Integer freeTextOperator;
Void res = agent.SetSingleWordOperator(freeTextOperator);
```


---
uid: crmscript_ref_NSFreeTextAgent_SetMultiWordOperator
title: Void SetMultiWordOperator(Integer freeTextOperator)
intellisense: NSFreeTextAgent.SetMultiWordOperator
keywords: NSFreeTextAgent, SetMultiWordOperator
so.topic: reference
---

Sets the operator used when matching multiple words

**Parameters:**
 - **freeTextOperator** The operator
     - Enum: 1 = Contains 
     - Enum: 2 = StartsWith 
     - Enum: 3 = ExactMatch 

```crmscript
NSFreeTextAgent agent;
Integer freeTextOperator;
agent.SetMultiWordOperator(freeTextOperator);
```


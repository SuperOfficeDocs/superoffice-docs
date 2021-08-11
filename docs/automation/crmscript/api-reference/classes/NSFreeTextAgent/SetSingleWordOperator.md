---
uid: crmscript_ref_NSFreeTextAgent_SetSingleWordOperator
title: Void SetSingleWordOperator(Integer freeTextOperator)
intellisense: NSFreeTextAgent.SetSingleWordOperator
keywords: NSFreeTextAgent, SetSingleWordOperator
so.topic: reference
---

# Void SetSingleWordOperator(Integer freeTextOperator)

Sets the operator used when matching single words

**Parameters:**
 - **freeTextOperator** The operator
     - Enum: 1 = Contains 
     - Enum: 2 = StartsWith 
     - Enum: 3 = ExactMatch 

```crmscript
NSFreeTextAgent agent;
Integer freeTextOperator;
agent.SetSingleWordOperator(freeTextOperator);
```

---
uid: crmscript_ref_NSSaleAgent_ValidateSaleEntity
title: StringDictionary ValidateSaleEntity(NSSaleEntity saleEntity)
intellisense: NSSaleAgent.ValidateSaleEntity
keywords: NSSaleAgent, ValidateSaleEntity
so.topic: reference
---

Check that entity is ready for saving, return error messages by field.

**Parameters:**
 - **saleEntity** Entity to be checked for errors.

**Returns:** StringDictionary

```crmscript
NSSaleAgent agent;
NSSaleEntity saleEntity;
StringDictionary res = agent.ValidateSaleEntity(saleEntity);
```


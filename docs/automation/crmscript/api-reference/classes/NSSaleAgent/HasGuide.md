---
uid: crmscript_ref_NSSaleAgent_HasGuide
title: Bool HasGuide(Integer saleId)
intellisense: NSSaleAgent.HasGuide
keywords: NSSaleAgent, HasGuide
so.topic: reference
---

# Bool HasGuide(Integer saleId)

Does this sale have a sale guide associated with its sale type?

**Parameters:**
 - **saleId** Sale id

**Returns:** Bool

```crmscript
NSSaleAgent agent;
Integer saleId;
Bool res = agent.HasGuide(saleId);
```


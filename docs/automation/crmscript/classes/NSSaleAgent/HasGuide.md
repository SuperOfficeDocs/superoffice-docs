---
title: crmscript_ref_NSSaleAgent_HasGuide
description: Bool HasGuide(Integer saleId)
intellisense: NSSaleAgent.HasGuide
keywords: NSSaleAgent,HasGuide
so.topic: reference
---

Does this sale have a sale guide associated with its sale type?

**Parameters:**
 - **saleId** Sale id

**Returns:** True if the sale has a guide

```crmscript
NSSaleAgent agent;
Integer saleId;
Bool res = agent.HasGuide(saleId);
```


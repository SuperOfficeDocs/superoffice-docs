---
title: crmscript_ref_NSListAgent_GetDocumentTemplateUsedInSalesStage
description: StringArray GetDocumentTemplateUsedInSalesStage(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateUsedInSalesStage
keywords: NSListAgent,GetDocumentTemplateUsedInSalesStage
so.topic: reference
---

Get a String array of names in sales guide that this template is used in

**Parameters:**
 - **documentTemplateId** The id of the template

**Returns:** The name of the salesguides that use this template

```crmscript
NSListAgent agent;
Integer documentTemplateId;
StringArray res = agent.GetDocumentTemplateUsedInSalesStage(documentTemplateId);
```


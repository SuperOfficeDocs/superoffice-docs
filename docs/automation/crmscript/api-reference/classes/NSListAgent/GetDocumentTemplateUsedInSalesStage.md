---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateUsedInSalesStage
title: String[] GetDocumentTemplateUsedInSalesStage(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateUsedInSalesStage
keywords: NSListAgent, GetDocumentTemplateUsedInSalesStage
so.topic: reference
---

# String[] GetDocumentTemplateUsedInSalesStage(Integer documentTemplateId)

Get a String array of names in sales guide that this template is used in

**Parameters:**
 - **documentTemplateId** The id of the template

**Returns:** String[]

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String[] res = agent.GetDocumentTemplateUsedInSalesStage(documentTemplateId);
```


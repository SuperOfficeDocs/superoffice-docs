---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateUsedInProjectStage
title: String[] GetDocumentTemplateUsedInProjectStage(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateUsedInProjectStage
keywords: NSListAgent, GetDocumentTemplateUsedInProjectStage
so.topic: reference
---

Get a String array of names in project guide that this template is used in

**Parameters:**
 - **documentTemplateId** The id of the template

**Returns:** String[]

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String[] res = agent.GetDocumentTemplateUsedInProjectStage(documentTemplateId);
```


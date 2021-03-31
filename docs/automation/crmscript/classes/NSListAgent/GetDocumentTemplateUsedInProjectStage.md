---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateUsedInProjectStage
title: StringArray GetDocumentTemplateUsedInProjectStage(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateUsedInProjectStage
keywords: NSListAgent, GetDocumentTemplateUsedInProjectStage
so.topic: reference
---

Get a String array of names in project guide that this template is used in

**Parameters:**
 - **documentTemplateId** The id of the template

**Returns:** The name of the projectguides that use this template

```crmscript
NSListAgent agent;
Integer documentTemplateId;
StringArray res = agent.GetDocumentTemplateUsedInProjectStage(documentTemplateId);
```


---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateLanguages
title: String[] GetDocumentTemplateLanguages(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateLanguages
keywords: NSListAgent, GetDocumentTemplateLanguages
so.topic: reference
---

# String[] GetDocumentTemplateLanguages(Integer documentTemplateId)

Get the supported language variations for a document template

**Parameters:**
 - **documentTemplateId** The id of the document template

**Returns:** String[]

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String[] res = agent.GetDocumentTemplateLanguages(documentTemplateId);
```


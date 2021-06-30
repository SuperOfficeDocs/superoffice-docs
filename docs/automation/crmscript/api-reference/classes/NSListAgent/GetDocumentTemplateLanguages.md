---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateLanguages
title: String[] GetDocumentTemplateLanguages(Integer documentTemplateId)
intellisense: NSListAgent.GetDocumentTemplateLanguages
keywords: NSListAgent, GetDocumentTemplateLanguages
so.topic: reference
---

Get the supported language variations for a document template

**Parameters:**
 - **documentTemplateId** The id of the document template

**Returns:** Returns the list of languages as ISO cultures (en-US, no, sv, etc)

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String[] res = agent.GetDocumentTemplateLanguages(documentTemplateId);
```


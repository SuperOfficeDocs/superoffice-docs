---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateStreamFromId
title: NSStream GetDocumentTemplateStreamFromId(Integer documentTemplateId, String languageCode)
intellisense: NSListAgent.GetDocumentTemplateStreamFromId
keywords: NSListAgent, GetDocumentTemplateStreamFromId
so.topic: reference
---

Retrieve a stream to a document template based on its id

**Parameters:**
 - **documentTemplateId** Id of template to retrieve
 - **languageCode** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** NSStream

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String languageCode;
NSStream res = agent.GetDocumentTemplateStreamFromId(documentTemplateId, languageCode);
```


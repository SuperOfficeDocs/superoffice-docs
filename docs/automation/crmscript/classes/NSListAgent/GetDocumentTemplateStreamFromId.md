---
uid: crmscript_ref_NSListAgent_GetDocumentTemplateStreamFromId
title: Stream GetDocumentTemplateStreamFromId(Integer documentTemplateId, String languageCode)
intellisense: NSListAgent.GetDocumentTemplateStreamFromId
keywords: NSListAgent, GetDocumentTemplateStreamFromId
so.topic: reference
---

Retrieve a stream to a document template based on its id

**Parameters:**
 - **documentTemplateId** Id of template to retrieve
 - **languageCode** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** Open stream to the template content

```crmscript
NSListAgent agent;
Integer documentTemplateId;
String languageCode;
Stream res = agent.GetDocumentTemplateStreamFromId(documentTemplateId, languageCode);
```


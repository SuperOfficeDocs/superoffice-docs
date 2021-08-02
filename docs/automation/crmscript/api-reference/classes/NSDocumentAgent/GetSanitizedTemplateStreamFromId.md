---
uid: crmscript_ref_NSDocumentAgent_GetSanitizedTemplateStreamFromId
title: NSStream GetSanitizedTemplateStreamFromId(Integer templateId, String uiCulture)
intellisense: NSDocumentAgent.GetSanitizedTemplateStreamFromId
keywords: NSDocumentAgent, GetSanitizedTemplateStreamFromId
so.topic: reference
---

Retrieve a stream to a document template based on its id. Sanitizes the contents if possible.

**Parameters:**
 - **templateId** Id of template to retrieve
 - **uiCulture** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
Integer templateId;
String uiCulture;
NSStream res = agent.GetSanitizedTemplateStreamFromId(templateId, uiCulture);
```


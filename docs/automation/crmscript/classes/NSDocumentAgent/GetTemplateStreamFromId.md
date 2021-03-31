---
title: crmscript_ref_NSDocumentAgent_GetTemplateStreamFromId
description: Stream GetTemplateStreamFromId(Integer templateId, String uiCulture)
intellisense: NSDocumentAgent.GetTemplateStreamFromId
keywords: NSDocumentAgent,GetTemplateStreamFromId
so.topic: reference
---

Retrieve a stream to a document template based on its id

**Parameters:**
 - **templateId** Id of template to retrieve
 - **uiCulture** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** Open stream to the template

```crmscript
NSDocumentAgent agent;
Integer templateId;
String uiCulture;
Stream res = agent.GetTemplateStreamFromId(templateId, uiCulture);
```


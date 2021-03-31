---
title: crmscript_ref_NSListAgent_GetDocumentTemplateUrl
description: String GetDocumentTemplateUrl(Integer documentTemplateId, Bool writableUrl, String languageCode)
intellisense: NSListAgent.GetDocumentTemplateUrl
keywords: NSListAgent,GetDocumentTemplateUrl
so.topic: reference
---

Get a url to the document template

**Parameters:**
 - **documentTemplateId** The id of the template
 - **writableUrl** Get a writeable url to the document template?
 - **languageCode** The language code ('en-US', 'nb-NO', etc). Use empty string if not supported or used.

**Returns:** The URL to the document template

```crmscript
NSListAgent agent;
Integer documentTemplateId;
Bool writableUrl;
String languageCode;
String res = agent.GetDocumentTemplateUrl(documentTemplateId, writableUrl, languageCode);
```


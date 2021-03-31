---
title: crmscript_ref_NSDocumentAgent_SaveDocumentTemplateStream
description: TemplateInfo SaveDocumentTemplateStream(Integer documentTemplateId, Stream content, String languageCode, Integer pluginId)
intellisense: NSDocumentAgent.SaveDocumentTemplateStream
keywords: NSDocumentAgent,SaveDocumentTemplateStream
so.topic: reference
---

Saves content in stream to document template file

**Parameters:**
 - **documentTemplateId** Identifier for document template
 - **content** Stream containing content to be saved to document template file
 - **languageCode** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
 - **pluginId** Plugin id. Use -1 to use the plugin specified in the template.

**Returns:** Template info

```crmscript
NSDocumentAgent agent;
Integer documentTemplateId;
Stream content;
String languageCode;
Integer pluginId;
TemplateInfo res = agent.SaveDocumentTemplateStream(documentTemplateId, content, languageCode, pluginId);
```


---
uid: crmscript_ref_NSDocumentAgent_SaveDocumentTemplateStream
title: NSTemplateInfo SaveDocumentTemplateStream(Integer documentTemplateId, NSStream content, String languageCode, Integer pluginId)
intellisense: NSDocumentAgent.SaveDocumentTemplateStream
keywords: NSDocumentAgent, SaveDocumentTemplateStream
so.topic: reference
---

Saves content in stream to document template file

**Parameters:**
 - **documentTemplateId** Identifier for document template
 - **content** NSStream containing content to be saved to document template file
 - **languageCode** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
 - **pluginId** Plugin id. Use -1 to use the plugin specified in the template.

**Returns:** NSTemplateInfo

```crmscript
NSDocumentAgent agent;
Integer documentTemplateId;
NSStream content;
String languageCode;
Integer pluginId;
NSTemplateInfo res = agent.SaveDocumentTemplateStream(documentTemplateId, content, languageCode, pluginId);
```


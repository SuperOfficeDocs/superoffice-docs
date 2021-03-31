---
title: crmscript_ref_NSListAgent_SaveDocumentTemplateStream
description: TemplateInfo SaveDocumentTemplateStream(Integer documentTemplateId, Stream content, String languageCode, Integer pluginId)
intellisense: NSListAgent.SaveDocumentTemplateStream
keywords: NSListAgent,SaveDocumentTemplateStream
so.topic: reference
---

Writes content in stream to document template file

**Parameters:**
 - **documentTemplateId** Identifier for document template
 - **content** Stream containing content to be saved to document template file
 - **languageCode** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
 - **pluginId** Plugin to use for storing document content. 0 = SOARC. Use -1 to use the plugin specified in the template.

**Returns:** Template info

```crmscript
NSListAgent agent;
Integer documentTemplateId;
Stream content;
String languageCode;
Integer pluginId;
TemplateInfo res = agent.SaveDocumentTemplateStream(documentTemplateId, content, languageCode, pluginId);
```


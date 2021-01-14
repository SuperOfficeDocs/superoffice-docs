---
title: NSTemplateInfo SaveDocumentTemplateStream(Integer documentTemplateId, NSStream content, String languageCode, Integer pluginId)
path: /EJScript/Classes/NSListAgent/Member functions/NSTemplateInfo SaveDocumentTemplateStream(Integer p_0, NSStream p_1, String p_2, Integer p_3)
intellisense: 1
classref: 1
keywords: SaveDocumentTemplateStream(Integer,NSStream,String,Integer)
---


Writes content in stream to document template file



* **documentTemplateId:** Identifier for document template
* **content:** Stream containing content to be saved to document template file
* **languageCode:** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **pluginId:** Plugin to use for storing document content. 0 = SOARC. Use -1 to use the plugin specified in the template.
* **Returns:** Template info



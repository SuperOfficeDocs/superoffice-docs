---
title: crmscript_ref_NSDocumentAgent_SaveDocumentTemplateStream_Integer_p_0_NSStream_p_1_String_p_2_Integer_p_3
description: NSDocumentAgent.SaveDocumentTemplateStream(Integer p_0, NSStream p_1, String p_2, Integer p_3)
intellisense: NSDocumentAgent.SaveDocumentTemplateStream
sortOrder: 2530
keywords: SaveDocumentTemplateStream(Integer,NSStream,String,Integer)
so.topic: reference
---


Saves content in stream to document template file



* **documentTemplateId:** Identifier for document template
* **content:** Stream containing content to be saved to document template file
* **languageCode:** Language variation of template to update. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **pluginId:** Plugin id. Use -1 to use the plugin specified in the template.
* **Returns:** Template info



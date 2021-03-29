---
title: crmscript_ref_NSDocumentAgent_GetTemplateStream_String_p_0_Bool_p_1_String_p_2
description: NSDocumentAgent.GetTemplateStream(String p_0, Bool p_1, String p_2)
intellisense: NSDocumentAgent.GetTemplateStream
sortOrder: 2521
keywords: GetTemplateStream(String,Bool,String)
so.topic: reference
---


Retrieve a stream to a mail template based on its name



* **templateName:** Filename of mail template to retrieve
* **allowPersonal:** If true, try looking up template in personal area before looking in shared document template area
* **uiCulture:** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **Returns:** Open stream to the mail template



---
title: NSStream GetSanitizedTemplateStream(String templateName, Bool allowPersonal, String uiCulture)
path: /EJScript/Classes/NSDocumentAgent/Member functions/NSStream GetSanitizedTemplateStream(String p_0, Bool p_1, String p_2)
intellisense: 1
classref: 1
sortOrder: 2518
keywords: GetSanitizedTemplateStream(String,Bool,String)
---


Retrieve a stream to a mail template based on its name. Sanitizes the contents if possible.



* **templateName:** Filename of mail template to retrieve
* **allowPersonal:** If true, try looking up template in personal area before looking in shared document template area
* **uiCulture:** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".
* **Returns:** Open stream to the mail template



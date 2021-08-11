---
uid: crmscript_ref_NSDocumentAgent_GetSanitizedTemplateStream
title: NSStream GetSanitizedTemplateStream(String templateName, Bool allowPersonal, String uiCulture)
intellisense: NSDocumentAgent.GetSanitizedTemplateStream
keywords: NSDocumentAgent, GetSanitizedTemplateStream
so.topic: reference
---

# NSStream GetSanitizedTemplateStream(String templateName, Bool allowPersonal, String uiCulture)

Retrieve a stream to a mail template based on its name. Sanitizes the contents if possible.

**Parameters:**
 - **templateName** Filename of mail template to retrieve
 - **allowPersonal** If true, try looking up template in personal area before looking in shared document template area
 - **uiCulture** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** NSStream

```crmscript
NSDocumentAgent agent;
String templateName;
Bool allowPersonal;
String uiCulture;
NSStream res = agent.GetSanitizedTemplateStream(templateName, allowPersonal, uiCulture);
```


---
uid: crmscript_ref_NSDocumentAgent_GetTemplateStream
title: Stream GetTemplateStream(String templateName, Bool allowPersonal, String uiCulture)
intellisense: NSDocumentAgent.GetTemplateStream
keywords: NSDocumentAgent, GetTemplateStream
so.topic: reference
---

Retrieve a stream to a mail template based on its name

**Parameters:**
 - **templateName** Filename of mail template to retrieve
 - **allowPersonal** If true, try looking up template in personal area before looking in shared document template area
 - **uiCulture** Language variation of template to use. (ISO code: "en-US" or "nb-NO" etc). Used to select a template of the appropriate language. Can be overridden in SO ARC by user preference "PreferDocLang".

**Returns:** Open stream to the mail template

```crmscript
NSDocumentAgent agent;
String templateName;
Bool allowPersonal;
String uiCulture;
Stream res = agent.GetTemplateStream(templateName, allowPersonal, uiCulture);
```


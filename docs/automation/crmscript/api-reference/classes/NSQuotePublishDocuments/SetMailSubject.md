---
uid: crmscript_ref_NSQuotePublishDocuments_SetMailSubject
title: SetMailSubject(String mailSubject)
intellisense: NSQuotePublishDocuments.SetMailSubject
keywords: NSQuotePublishDocuments, GetMailSubject
so.topic: reference
---

# SetMailSubject(String mailSubject)

The string that is the mail subject; done by merging the text resource SR_QUOTE_PUBLISH_MAILHEADING with the current template variable values

**Parameter:** 
 - **mailSubject** String

```crmscript
NSQuotePublishDocuments thing;
String mailSubject;
thing.SetMailSubject(mailSubject);
```


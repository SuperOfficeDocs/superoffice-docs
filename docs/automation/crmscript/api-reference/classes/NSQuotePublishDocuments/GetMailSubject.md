---
uid: crmscript_ref_NSQuotePublishDocuments_GetMailSubject
title: String GetMailSubject()
intellisense: NSQuotePublishDocuments.GetMailSubject
keywords: NSQuotePublishDocuments, GetMailSubject
so.topic: reference
---

# String GetMailSubject()

The string that is the mail subject; done by merging the text resource SR_QUOTE_PUBLISH_MAILHEADING with the current template variable values

**Returns:** String

```crmscript
NSQuotePublishDocuments thing;
String mailSubject  = thing.GetMailSubject();
```


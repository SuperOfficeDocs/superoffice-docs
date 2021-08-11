---
uid: crmscript_ref_NSEMailAttachment_SetStream
title: SetStream(NSStream stream)
intellisense: NSEMailAttachment.SetStream
keywords: NSEMailAttachment, GetStream
so.topic: reference
---

# SetStream(NSStream stream)

Binary stream for outgoing attachments. This property will not be populated for existing e-mail items.

**Parameter:** 
 - **stream** NSStream

```crmscript
NSEMailAttachment thing;
NSStream stream;
thing.SetStream(stream);
```


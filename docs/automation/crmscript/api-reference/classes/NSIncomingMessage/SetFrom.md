---
uid: crmscript_ref_NSIncomingMessage_SetFrom
title: SetFrom(String from)
intellisense: NSIncomingMessage.SetFrom
keywords: NSIncomingMessage, GetFrom
so.topic: reference
---

# SetFrom(String from)

Who the message is from.  This can vary from provider to provider and can for SMS typically be a phone number or a string.  This is mail address on the form of an e-mail.

**Parameter:** 
 - **from** String

```crmscript
NSIncomingMessage thing;
String from;
thing.SetFrom(from);
```


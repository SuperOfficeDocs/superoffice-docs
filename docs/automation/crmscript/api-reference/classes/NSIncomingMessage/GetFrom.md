---
uid: crmscript_ref_NSIncomingMessage_GetFrom
title: String GetFrom()
intellisense: NSIncomingMessage.GetFrom
keywords: NSIncomingMessage, GetFrom
so.topic: reference
---

# String GetFrom()

Who the message is from.  This can vary from provider to provider and can for SMS typically be a phone number or a string.  This is mail address on the form of an e-mail.

**Returns:** String

```crmscript
NSIncomingMessage thing;
String from  = thing.GetFrom();
```


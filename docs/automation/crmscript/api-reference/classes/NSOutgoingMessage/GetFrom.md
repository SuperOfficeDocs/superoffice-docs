---
uid: crmscript_ref_NSOutgoingMessage_GetFrom
title: String GetFrom()
intellisense: NSOutgoingMessage.GetFrom
keywords: NSOutgoingMessage, GetFrom
so.topic: reference
---

# String GetFrom()

Who the message is from.  This can vary from provider to provider and can for SMS typically be a phone number or a string.  This is mail address on the form of an e-mail.

**Returns:** String

```crmscript
NSOutgoingMessage thing;
String from  = thing.GetFrom();
```


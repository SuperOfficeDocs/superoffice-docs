---
uid: crmscript_ref_NSOutgoingMessage_GetParentMessagingId
title: Integer GetParentMessagingId()
intellisense: NSOutgoingMessage.GetParentMessagingId
keywords: NSOutgoingMessage, GetParentMessagingId
so.topic: reference
---

# Integer GetParentMessagingId()

Id to the previous outgoing message related to this one. Used from message threading.

**Returns:** Integer

```crmscript
NSOutgoingMessage thing;
Integer parentMessagingId  = thing.GetParentMessagingId();
```


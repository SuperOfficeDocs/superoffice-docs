---
uid: crmscript_ref_NSOutgoingMessage_SetParentMessagingId
title: SetParentMessagingId(Integer parentMessagingId)
intellisense: NSOutgoingMessage.SetParentMessagingId
keywords: NSOutgoingMessage, GetParentMessagingId
so.topic: reference
---

# SetParentMessagingId(Integer parentMessagingId)

Id to the previous outgoing message related to this one. Used from message threading.

**Parameter:** 
 - **parentMessagingId** Integer

```crmscript
NSOutgoingMessage thing;
Integer parentMessagingId;
thing.SetParentMessagingId(parentMessagingId);
```


---
uid: crmscript_ref_NSChatAgent_RejectChatSessionTransfer
title: NSChatSessionEntity RejectChatSessionTransfer(Integer chatSessionId)
intellisense: NSChatAgent.RejectChatSessionTransfer
keywords: NSChatAgent, RejectChatSessionTransfer
so.topic: reference
---

Do not want. Deny the transfer to the user. If the session is not being transferred, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send back

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
Integer chatSessionId;
NSChatSessionEntity res = agent.RejectChatSessionTransfer(chatSessionId);
```


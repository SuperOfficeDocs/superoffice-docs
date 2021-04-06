---
uid: crmscript_ref_NSChatAgent_RejectChatSessionTransfer
title: ChatSessionEntity RejectChatSessionTransfer(Integer chatSessionId)
intellisense: NSChatAgent.RejectChatSessionTransfer
keywords: NSChatAgent, RejectChatSessionTransfer
so.topic: reference
---

Do not want. Deny the transfer to the user. If the session is not being transferred, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send back

**Returns:** The updated chat session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
ChatSessionEntity res = agent.RejectChatSessionTransfer(chatSessionId);
```


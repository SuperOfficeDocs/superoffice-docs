---
uid: crmscript_ref_NSChatAgent_AcceptChatSessionTransfer
title: NSChatSessionEntity AcceptChatSessionTransfer(Integer chatSessionId)
intellisense: NSChatAgent.AcceptChatSessionTransfer
keywords: NSChatAgent, AcceptChatSessionTransfer
so.topic: reference
---

Accept the transfer: assign the session to the user. If the session is not being transferred, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
Integer chatSessionId;
NSChatSessionEntity res = agent.AcceptChatSessionTransfer(chatSessionId);
```


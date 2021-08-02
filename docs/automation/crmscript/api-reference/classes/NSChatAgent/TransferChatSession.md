---
uid: crmscript_ref_NSChatAgent_TransferChatSession
title: NSChatSessionEntity TransferChatSession(Integer chatSessionId, String toAssociate)
intellisense: NSChatAgent.TransferChatSession
keywords: NSChatAgent, TransferChatSession
so.topic: reference
---

Request to send the session to another user. If the session does not belong to the user, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send
 - **toAssociate** Associate username or associate id to send session to.

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
Integer chatSessionId;
String toAssociate;
NSChatSessionEntity res = agent.TransferChatSession(chatSessionId, toAssociate);
```


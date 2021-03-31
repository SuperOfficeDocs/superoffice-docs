---
uid: crmscript_ref_NSChatAgent_TransferChatSession
title: ChatSessionEntity TransferChatSession(Integer chatSessionId, String toAssociate)
intellisense: NSChatAgent.TransferChatSession
keywords: NSChatAgent, TransferChatSession
so.topic: reference
---

Request to send the session to another user. If the session does not belong to the user, nothing happens.

**Parameters:**
 - **chatSessionId** id of the chat session to send
 - **toAssociate** Associate username or associate id to send session to.

**Returns:** The updated chat session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
String toAssociate;
ChatSessionEntity res = agent.TransferChatSession(chatSessionId, toAssociate);
```


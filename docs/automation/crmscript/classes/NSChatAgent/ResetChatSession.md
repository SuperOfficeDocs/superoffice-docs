---
uid: crmscript_ref_NSChatAgent_ResetChatSession
title: ChatSessionEntity ResetChatSession(Integer chatSessionId)
intellisense: NSChatAgent.ResetChatSession
keywords: NSChatAgent, ResetChatSession
so.topic: reference
---

Reset chat session, put it back on the queue for pickup. Used by bots to hand off a session to human

**Parameters:**
 - **chatSessionId** id of the chat session to reset

**Returns:** The updated chat session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
ChatSessionEntity res = agent.ResetChatSession(chatSessionId);
```


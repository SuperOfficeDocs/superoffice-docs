---
uid: crmscript_ref_NSChatAgent_GetChatMessages
title: NSChatMessage[] GetChatMessages(Integer chatSessionId, Integer after)
intellisense: NSChatAgent.GetChatMessages
keywords: NSChatAgent, GetChatMessages
so.topic: reference
---

# NSChatMessage[] GetChatMessages(Integer chatSessionId, Integer after)

Get all or some of the messages in a chat session

**Parameters:**
 - **chatSessionId** id of the chat session to reset
 - **after** Return messages after this message id

**Returns:** NSChatMessage[]

```crmscript
NSChatAgent agent;
Integer chatSessionId;
Integer after;
NSChatMessage[] res = agent.GetChatMessages(chatSessionId, after);
```


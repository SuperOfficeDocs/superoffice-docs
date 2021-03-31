---
title: crmscript_ref_NSChatAgent_GetChatMessages
description: ChatMessageArray GetChatMessages(Integer chatSessionId, Integer after)
intellisense: NSChatAgent.GetChatMessages
keywords: NSChatAgent,GetChatMessages
so.topic: reference
---

Get all or some of the messages in a chat session

**Parameters:**
 - **chatSessionId** id of the chat session to reset
 - **after** Return messages after this message id

**Returns:** Array of chat messages in the session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
Integer after;
ChatMessageArray res = agent.GetChatMessages(chatSessionId, after);
```


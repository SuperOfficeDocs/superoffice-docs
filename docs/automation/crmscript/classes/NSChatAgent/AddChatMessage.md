---
title: crmscript_ref_NSChatAgent_AddChatMessage
description: ChatMessage AddChatMessage(Integer chatSessionId, ChatMessage message)
intellisense: NSChatAgent.AddChatMessage
keywords: NSChatAgent,AddChatMessage
so.topic: reference
---

Add a new message to a chat session

**Parameters:**
 - **chatSessionId** id of the chat session to add message to
 - **message** Message to add

**Returns:** The chat message added to the session

```crmscript
NSChatAgent agent;
Integer chatSessionId;
ChatMessage message;
ChatMessage res = agent.AddChatMessage(chatSessionId, message);
```


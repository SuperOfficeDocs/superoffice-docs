---
uid: crmscript_ref_NSChatAgent_AddChatMessage
title: NSChatMessage AddChatMessage(Integer chatSessionId, NSChatMessage message)
intellisense: NSChatAgent.AddChatMessage
keywords: NSChatAgent, AddChatMessage
so.topic: reference
---

# NSChatMessage AddChatMessage(Integer chatSessionId, NSChatMessage message)

Add a new message to a chat session

**Parameters:**
 - **chatSessionId** id of the chat session to add message to
 - **message** Message to add

**Returns:** NSChatMessage

```crmscript
NSChatAgent agent;
Integer chatSessionId;
NSChatMessage message;
NSChatMessage res = agent.AddChatMessage(chatSessionId, message);
```


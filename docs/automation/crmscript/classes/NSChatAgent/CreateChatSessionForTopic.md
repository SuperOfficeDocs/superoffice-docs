---
uid: crmscript_ref_NSChatAgent_CreateChatSessionForTopic
title: ChatSessionEntity CreateChatSessionForTopic(Integer chatTopicId)
intellisense: NSChatAgent.CreateChatSessionForTopic
keywords: NSChatAgent, CreateChatSessionForTopic
so.topic: reference
---

Create a new session on a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic

**Returns:** The new chat session.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
ChatSessionEntity res = agent.CreateChatSessionForTopic(chatTopicId);
```


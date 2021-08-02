---
uid: crmscript_ref_NSChatAgent_CreateChatSessionForTopic
title: NSChatSessionEntity CreateChatSessionForTopic(Integer chatTopicId)
intellisense: NSChatAgent.CreateChatSessionForTopic
keywords: NSChatAgent, CreateChatSessionForTopic
so.topic: reference
---

Create a new session on a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic

**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
Integer chatTopicId;
NSChatSessionEntity res = agent.CreateChatSessionForTopic(chatTopicId);
```


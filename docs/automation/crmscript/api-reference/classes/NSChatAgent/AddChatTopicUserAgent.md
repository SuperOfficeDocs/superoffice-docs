---
uid: crmscript_ref_NSChatAgent_AddChatTopicUserAgent
title: ChatTopicAgent AddChatTopicUserAgent(Integer chatTopicId, ChatTopicAgent useragent)
intellisense: NSChatAgent.AddChatTopicUserAgent
keywords: NSChatAgent, AddChatTopicUserAgent
so.topic: reference
---

Add a user to a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **useragent** User's role within the chat topic to add to topic.

**Returns:** The user's role within the chat topic.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
ChatTopicAgent useragent;
ChatTopicAgent res = agent.AddChatTopicUserAgent(chatTopicId, useragent);
```


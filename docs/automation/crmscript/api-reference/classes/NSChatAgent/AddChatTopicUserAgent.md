---
uid: crmscript_ref_NSChatAgent_AddChatTopicUserAgent
title: NSChatTopicAgent AddChatTopicUserAgent(Integer chatTopicId, NSChatTopicAgent useragent)
intellisense: NSChatAgent.AddChatTopicUserAgent
keywords: NSChatAgent, AddChatTopicUserAgent
so.topic: reference
---

Add a user to a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **useragent** User's role within the chat topic to add to topic.

**Returns:** NSChatTopicAgent

```crmscript
NSChatAgent agent;
Integer chatTopicId;
NSChatTopicAgent useragent;
NSChatTopicAgent res = agent.AddChatTopicUserAgent(chatTopicId, useragent);
```


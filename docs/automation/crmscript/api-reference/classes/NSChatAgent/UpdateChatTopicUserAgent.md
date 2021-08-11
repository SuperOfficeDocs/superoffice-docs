---
uid: crmscript_ref_NSChatAgent_UpdateChatTopicUserAgent
title: NSChatTopicAgent UpdateChatTopicUserAgent(Integer chatTopicId, String username, NSChatTopicAgent useragent)
intellisense: NSChatAgent.UpdateChatTopicUserAgent
keywords: NSChatAgent, UpdateChatTopicUserAgent
so.topic: reference
---

# NSChatTopicAgent UpdateChatTopicUserAgent(Integer chatTopicId, String username, NSChatTopicAgent useragent)

Update a user's role in a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **username** Associate username or associate id to get.
 - **useragent** User's updated role within the chat topic.

**Returns:** NSChatTopicAgent

```crmscript
NSChatAgent agent;
Integer chatTopicId;
String username;
NSChatTopicAgent useragent;
NSChatTopicAgent res = agent.UpdateChatTopicUserAgent(chatTopicId, username, useragent);
```


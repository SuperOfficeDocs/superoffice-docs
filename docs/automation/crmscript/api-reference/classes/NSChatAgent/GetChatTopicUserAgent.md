---
uid: crmscript_ref_NSChatAgent_GetChatTopicUserAgent
title: NSChatTopicAgent GetChatTopicUserAgent(Integer chatTopicId, String username)
intellisense: NSChatAgent.GetChatTopicUserAgent
keywords: NSChatAgent, GetChatTopicUserAgent
so.topic: reference
---

# NSChatTopicAgent GetChatTopicUserAgent(Integer chatTopicId, String username)

Get a user assigned to a topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **username** Associate username or associate id to get.

**Returns:** NSChatTopicAgent

```crmscript
NSChatAgent agent;
Integer chatTopicId;
String username;
NSChatTopicAgent res = agent.GetChatTopicUserAgent(chatTopicId, username);
```


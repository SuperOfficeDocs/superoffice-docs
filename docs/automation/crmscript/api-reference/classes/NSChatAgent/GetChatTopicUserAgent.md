---
uid: crmscript_ref_NSChatAgent_GetChatTopicUserAgent
title: ChatTopicAgent GetChatTopicUserAgent(Integer chatTopicId, String username)
intellisense: NSChatAgent.GetChatTopicUserAgent
keywords: NSChatAgent, GetChatTopicUserAgent
so.topic: reference
---

Get a user assigned to a topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **username** Associate username or associate id to get.

**Returns:** The user's role within the chat topic.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
String username;
ChatTopicAgent res = agent.GetChatTopicUserAgent(chatTopicId, username);
```


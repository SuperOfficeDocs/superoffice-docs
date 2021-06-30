---
uid: crmscript_ref_NSChatAgent_GetChatTopicUserAgentList
title: ChatTopicAgent[] GetChatTopicUserAgentList(Integer chatTopicId)
intellisense: NSChatAgent.GetChatTopicUserAgentList
keywords: NSChatAgent, GetChatTopicUserAgentList
so.topic: reference
---

Get list of users assigned to a chat topic

**Parameters:**

- **chatTopicId** ID of the chat topic

**Returns:** List of user agents assigned to chat topic.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
ChatTopicAgent[] res = agent.GetChatTopicUserAgentList(chatTopicId);
```


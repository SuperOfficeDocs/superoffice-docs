---
uid: crmscript_ref_NSChatAgent_GetChatTopicUserAgentList
title: NSChatTopicAgent[] GetChatTopicUserAgentList(Integer chatTopicId)
intellisense: NSChatAgent.GetChatTopicUserAgentList
keywords: NSChatAgent, GetChatTopicUserAgentList
so.topic: reference
---

# NSChatTopicAgent[] GetChatTopicUserAgentList(Integer chatTopicId)

Get list of users assigned to a chat topic

**Parameters:**

- **chatTopicId** ID of the chat topic

**Returns:** NSChatTopicAgent[]

```crmscript
NSChatAgent agent;
Integer chatTopicId;
NSChatTopicAgent[] res = agent.GetChatTopicUserAgentList(chatTopicId);
```


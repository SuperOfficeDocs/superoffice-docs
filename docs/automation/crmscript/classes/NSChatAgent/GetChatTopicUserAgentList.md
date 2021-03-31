---
title: crmscript_ref_NSChatAgent_GetChatTopicUserAgentList
description: ChatTopicAgentArray GetChatTopicUserAgentList(Integer chatTopicId)
intellisense: NSChatAgent.GetChatTopicUserAgentList
keywords: NSChatAgent,GetChatTopicUserAgentList
so.topic: reference
---

Get list of users assigned to a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic

**Returns:** List of user agents assigned to chat topic.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
ChatTopicAgentArray res = agent.GetChatTopicUserAgentList(chatTopicId);
```


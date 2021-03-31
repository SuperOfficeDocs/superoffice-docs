---
title: crmscript_ref_NSChatAgent_UpdateChatTopicUserAgents
description: ChatTopicAgentArray UpdateChatTopicUserAgents(Integer chatTopicId, ChatTopicAgentArray useragents)
intellisense: NSChatAgent.UpdateChatTopicUserAgents
keywords: NSChatAgent,UpdateChatTopicUserAgents
so.topic: reference
---

Update users roles in a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **useragents** Users new/updated roles within the chat topic. Replaces existing roles

**Returns:** The updated agents within the chat topic.

```crmscript
NSChatAgent agent;
Integer chatTopicId;
ChatTopicAgentArray useragents;
ChatTopicAgentArray res = agent.UpdateChatTopicUserAgents(chatTopicId, useragents);
```


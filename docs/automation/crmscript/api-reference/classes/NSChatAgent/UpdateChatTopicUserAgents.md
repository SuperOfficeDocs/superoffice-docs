---
uid: crmscript_ref_NSChatAgent_UpdateChatTopicUserAgents
title: NSChatTopicAgent[] UpdateChatTopicUserAgents(Integer chatTopicId, NSChatTopicAgent[] useragents)
intellisense: NSChatAgent.UpdateChatTopicUserAgents
keywords: NSChatAgent, UpdateChatTopicUserAgents
so.topic: reference
---

# NSChatTopicAgent[] UpdateChatTopicUserAgents(Integer chatTopicId, NSChatTopicAgent[] useragents)

Update users roles in a chat topic

**Parameters:**
 - **chatTopicId** Id of the chat topic
 - **useragents** Users new/updated roles within the chat topic. Replaces existing roles

**Returns:** NSChatTopicAgent

```crmscript
NSChatAgent agent;
Integer chatTopicId;
NSChatTopicAgent[] useragents;
NSChatTopicAgent[] res = agent.UpdateChatTopicUserAgents(chatTopicId, useragents);
```


---
uid: crmscript_ref_NSChatAgent_IsWithinOpeningHours
title: Bool IsWithinOpeningHours(Integer chatTopicId)
intellisense: NSChatAgent.IsWithinOpeningHours
keywords: NSChatAgent, IsWithinOpeningHours
so.topic: reference
---

# Bool IsWithinOpeningHours(Integer chatTopicId)

Check if we are right now within the opening hours of the given topic. Will use timezones to calculate if configured.

**Parameters:**
 - **chatTopicId** The id of the topic to check

**Returns:** Bool

```crmscript
NSChatAgent agent;
Integer chatTopicId;
Bool res = agent.IsWithinOpeningHours(chatTopicId);
```


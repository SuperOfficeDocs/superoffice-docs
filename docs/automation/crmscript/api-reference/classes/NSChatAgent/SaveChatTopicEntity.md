---
uid: crmscript_ref_NSChatAgent_SaveChatTopicEntity
title: NSChatTopicEntity SaveChatTopicEntity(NSChatTopicEntity chatTopicEntity);
intellisense: NSChatAgent.SaveChatTopicEntity
keywords: NSChatAgent, SaveChatTopicEntity
so.topic: reference
---

# NSChatTopicEntity SaveChatTopicEntity(NSChatTopicEntity chatTopicEntity);
	  
Updates the existing NSChatTopicEntity or creates a new NSChatTopicEntity if the id parameter is 0
	  
**Parameters**:
 - **chatTopicEntity** The NSChatTopicEntity to save.

**Returns:** NSChatTopicEntity

```crmscript
NSChat  agent;
NSChatTopicEntity thing = agent.CreateDefaultChatTopicEntity();
thing = agent.SaveChatTopicEntity(thing);
```


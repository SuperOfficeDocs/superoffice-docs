---
uid: crmscript_ref_NSChatAgent_CreateDefaultChatTopicEntity
title: NSChatTopicEntity CreateDefaultChatTopicEntity()
intellisense: NSChatAgent.CreateDefaultChatTopicEntity
keywords: NSChatAgent, CreateDefaultChatTopicEntity
so.topic: reference
---
	  
Set default values into a new NSChatTopicEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSChatTopicEntity

```crmscript
NSChatAgent agent;
NSChatTopicEntity thing = agent.CreateDefaultChatTopicEntity();
thing = agent.SaveChatTopicEntity(thing);
```


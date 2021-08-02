---
uid: crmscript_ref_NSChatAgent_CreateDefaultChatSessionEntity
title: NSChatSessionEntity CreateDefaultChatSessionEntity()
intellisense: NSChatAgent.CreateDefaultChatSessionEntity
keywords: NSChatAgent, CreateDefaultChatSessionEntity
so.topic: reference
---
	  
Set default values into a new NSChatSessionEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSChatSessionEntity

```crmscript
NSChatAgent agent;
NSChatSessionEntity thing = agent.CreateDefaultChatSessionEntity();
thing = agent.SaveChatSessionEntity(thing);
```


---
uid: crmscript_ref_NSChatAgent_CreateDefaultChatTopicAgent
title: NSChatTopicAgent CreateDefaultChatTopicAgent()
intellisense: NSChatAgent.CreateDefaultChatTopicAgent
keywords: NSChatAgent, CreateDefaultChatTopicAgent
so.topic: reference
---

# NSChatTopicAgent CreateDefaultChatTopicAgent()
	  
Set default values into a new NSChatTopicAgent.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSChatTopicAgent

```crmscript
NSChatAgent agent;
NSChatTopicAgent thing = agent.CreateDefaultChatTopicAgent();
thing = agent.SaveChatTopicAgent(thing);
```


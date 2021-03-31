---
title: crmscript_ref_NSChatAgent_CreateDefaultChatTopicAgent
description: NSChatTopicAgent CreateDefaultChatTopicAgent()
intellisense: NSChatAgent.CreateDefaultChatTopicAgent
keywords: NSChatAgent,CreateDefaultChatTopicAgent
so.topic: reference
---
	  
Set default values into a new NSChatTopicAgent.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSChatTopicAgent with default values.

```crmscript
NSChatAgent agent;
NSChatTopicAgent thing = agent.CreateDefaultChatTopicAgent();
thing = agent.SaveChatTopicAgent(thing);
```


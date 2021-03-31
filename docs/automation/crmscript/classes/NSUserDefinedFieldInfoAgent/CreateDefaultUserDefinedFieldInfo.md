---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_CreateDefaultUserDefinedFieldInfo
title: NSUserDefinedFieldInfo CreateDefaultUserDefinedFieldInfo()
intellisense: NSUserDefinedFieldInfoAgent.CreateDefaultUserDefinedFieldInfo
keywords: NSUserDefinedFieldInfoAgent, CreateDefaultUserDefinedFieldInfo
so.topic: reference
---
	  
Set default values into a new NSUserDefinedFieldInfo.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSUserDefinedFieldInfo with default values.

```crmscript
NSUserDefinedFieldInfoAgent agent;
NSUserDefinedFieldInfo thing = agent.CreateDefaultUserDefinedFieldInfo();
thing = agent.SaveUserDefinedFieldInfo(thing);
```


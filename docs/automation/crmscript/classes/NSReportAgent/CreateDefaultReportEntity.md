---
uid: crmscript_ref_NSReportAgent_CreateDefaultReportEntity
title: NSReportEntity CreateDefaultReportEntity()
intellisense: NSReportAgent.CreateDefaultReportEntity
keywords: NSReportAgent, CreateDefaultReportEntity
so.topic: reference
---
	  
Set default values into a new NSReportEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSReportEntity with default values.

```crmscript
NSReportAgent agent;
NSReportEntity thing = agent.CreateDefaultReportEntity();
thing = agent.SaveReportEntity(thing);
```


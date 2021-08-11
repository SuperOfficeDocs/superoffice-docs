---
uid: crmscript_ref_NSReportAgent_CreateDefaultReportLabelLayoutEntity
title: NSReportLabelLayoutEntity CreateDefaultReportLabelLayoutEntity()
intellisense: NSReportAgent.CreateDefaultReportLabelLayoutEntity
keywords: NSReportAgent, CreateDefaultReportLabelLayoutEntity
so.topic: reference
---

# NSReportLabelLayoutEntity CreateDefaultReportLabelLayoutEntity()
	  
Set default values into a new NSReportLabelLayoutEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSReportLabelLayoutEntity

```crmscript
NSReportAgent agent;
NSReportLabelLayoutEntity thing = agent.CreateDefaultReportLabelLayoutEntity();
thing = agent.SaveReportLabelLayoutEntity(thing);
```


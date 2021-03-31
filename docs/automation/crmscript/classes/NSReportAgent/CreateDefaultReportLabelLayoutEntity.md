---
title: crmscript_ref_NSReportAgent_CreateDefaultReportLabelLayoutEntity
description: NSReportLabelLayoutEntity CreateDefaultReportLabelLayoutEntity()
intellisense: NSReportAgent.CreateDefaultReportLabelLayoutEntity
keywords: NSReportAgent,CreateDefaultReportLabelLayoutEntity
so.topic: reference
---
	  
Set default values into a new NSReportLabelLayoutEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSReportLabelLayoutEntity with default values.

```crmscript
NSReportAgent agent;
NSReportLabelLayoutEntity thing = agent.CreateDefaultReportLabelLayoutEntity();
thing = agent.SaveReportLabelLayoutEntity(thing);
```


---
title: crmscript_ref_NSReportAgent_SaveReportLabelLayoutEntity
description: NSReportLabelLayoutEntity SaveReportLabelLayoutEntity(NSReportLabelLayoutEntity reportLabelLayoutEntity);
intellisense: NSReportAgent.SaveReportLabelLayoutEntity
keywords: NSReportAgent,SaveReportLabelLayoutEntity
so.topic: reference
---
	  
Updates the existing NSReportLabelLayoutEntity or creates a new NSReportLabelLayoutEntity if the id parameter is 0
	  
**Parameters**:
 - **reportLabelLayoutEntity** The NSReportLabelLayoutEntity to save.

**Returns:** New or updated NSReportLabelLayoutEntity

```crmscript
NSReport  agent;
NSReportLabelLayoutEntity thing = agent.CreateDefaultReportLabelLayoutEntity();
thing = agent.SaveReportLabelLayoutEntity(thing);
```


---
uid: crmscript_ref_NSReportAgent_SaveReportEntity
title: NSReportEntity SaveReportEntity(NSReportEntity reportEntity);
intellisense: NSReportAgent.SaveReportEntity
keywords: NSReportAgent, SaveReportEntity
so.topic: reference
---
	  
Updates the existing NSReportEntity or creates a new NSReportEntity if the id parameter is 0
	  
**Parameters**:
 - **reportEntity** The NSReportEntity to save.

**Returns:** New or updated NSReportEntity

```crmscript
NSReport  agent;
NSReportEntity thing = agent.CreateDefaultReportEntity();
thing = agent.SaveReportEntity(thing);
```


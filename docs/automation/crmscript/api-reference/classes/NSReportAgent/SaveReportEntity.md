---
uid: crmscript_ref_NSReportAgent_SaveReportEntity
title: NSReportEntity SaveReportEntity(NSReportEntity reportEntity);
intellisense: NSReportAgent.SaveReportEntity
keywords: NSReportAgent, SaveReportEntity
so.topic: reference
---

# NSReportEntity SaveReportEntity(NSReportEntity reportEntity);
	  
Updates the existing NSReportEntity or creates a new NSReportEntity if the id parameter is 0
	  
**Parameters**:
 - **reportEntity** The NSReportEntity to save.

**Returns:** NSReportEntity

```crmscript
NSReport  agent;
NSReportEntity thing = agent.CreateDefaultReportEntity();
thing = agent.SaveReportEntity(thing);
```


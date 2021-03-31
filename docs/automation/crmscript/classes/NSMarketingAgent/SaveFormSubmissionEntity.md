---
title: crmscript_ref_NSMarketingAgent_SaveFormSubmissionEntity
description: NSFormSubmissionEntity SaveFormSubmissionEntity(NSFormSubmissionEntity formSubmissionEntity);
intellisense: NSMarketingAgent.SaveFormSubmissionEntity
keywords: NSMarketingAgent,SaveFormSubmissionEntity
so.topic: reference
---
	  
Updates the existing NSFormSubmissionEntity or creates a new NSFormSubmissionEntity if the id parameter is 0
	  
**Parameters**:
 - **formSubmissionEntity** The NSFormSubmissionEntity to save.

**Returns:** New or updated NSFormSubmissionEntity

```crmscript
NSMarketing  agent;
NSFormSubmissionEntity thing = agent.CreateDefaultFormSubmissionEntity();
thing = agent.SaveFormSubmissionEntity(thing);
```


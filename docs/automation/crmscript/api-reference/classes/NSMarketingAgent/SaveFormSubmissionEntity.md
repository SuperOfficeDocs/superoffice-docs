---
uid: crmscript_ref_NSMarketingAgent_SaveFormSubmissionEntity
title: NSFormSubmissionEntity SaveFormSubmissionEntity(NSFormSubmissionEntity formSubmissionEntity);
intellisense: NSMarketingAgent.SaveFormSubmissionEntity
keywords: NSMarketingAgent, SaveFormSubmissionEntity
so.topic: reference
---

# NSFormSubmissionEntity SaveFormSubmissionEntity(NSFormSubmissionEntity formSubmissionEntity);
	  
Updates the existing NSFormSubmissionEntity or creates a new NSFormSubmissionEntity if the id parameter is 0
	  
**Parameters**:
 - **formSubmissionEntity** The NSFormSubmissionEntity to save.

**Returns:** NSFormSubmissionEntity

```crmscript
NSMarketing  agent;
NSFormSubmissionEntity thing = agent.CreateDefaultFormSubmissionEntity();
thing = agent.SaveFormSubmissionEntity(thing);
```


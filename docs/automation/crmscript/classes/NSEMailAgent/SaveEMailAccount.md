---
title: crmscript_ref_NSEMailAgent_SaveEMailAccount
description: NSEMailAccount SaveEMailAccount(NSEMailAccount eMailAccount);
intellisense: NSEMailAgent.SaveEMailAccount
keywords: NSEMailAgent,SaveEMailAccount
so.topic: reference
---
	  
Updates the existing NSEMailAccount or creates a new NSEMailAccount if the id parameter is 0
	  
**Parameters**:
 - **eMailAccount** The NSEMailAccount to save.

**Returns:** New or updated NSEMailAccount

```crmscript
NSEMail  agent;
NSEMailAccount thing = agent.CreateDefaultEMailAccount();
thing = agent.SaveEMailAccount(thing);
```


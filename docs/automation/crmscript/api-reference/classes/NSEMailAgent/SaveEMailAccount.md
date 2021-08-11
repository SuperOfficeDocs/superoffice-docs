---
uid: crmscript_ref_NSEMailAgent_SaveEMailAccount
title: NSEMailAccount SaveEMailAccount(NSEMailAccount eMailAccount);
intellisense: NSEMailAgent.SaveEMailAccount
keywords: NSEMailAgent, SaveEMailAccount
so.topic: reference
---

# NSEMailAccount SaveEMailAccount(NSEMailAccount eMailAccount);
	  
Updates the existing NSEMailAccount or creates a new NSEMailAccount if the id parameter is 0
	  
**Parameters**:
 - **eMailAccount** The NSEMailAccount to save.

**Returns:** NSEMailAccount

```crmscript
NSEMail  agent;
NSEMailAccount thing = agent.CreateDefaultEMailAccount();
thing = agent.SaveEMailAccount(thing);
```


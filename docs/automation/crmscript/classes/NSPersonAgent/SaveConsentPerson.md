---
uid: crmscript_ref_NSPersonAgent_SaveConsentPerson
title: NSConsentPerson SaveConsentPerson(NSConsentPerson consentPerson);
intellisense: NSPersonAgent.SaveConsentPerson
keywords: NSPersonAgent, SaveConsentPerson
so.topic: reference
---
	  
Updates the existing NSConsentPerson or creates a new NSConsentPerson if the id parameter is 0
	  
**Parameters**:
 - **consentPerson** The NSConsentPerson to save.

**Returns:** New or updated NSConsentPerson

```crmscript
NSPerson  agent;
NSConsentPerson thing = agent.CreateDefaultConsentPerson();
thing = agent.SaveConsentPerson(thing);
```


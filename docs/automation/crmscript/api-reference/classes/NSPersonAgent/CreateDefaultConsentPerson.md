---
uid: crmscript_ref_NSPersonAgent_CreateDefaultConsentPerson
title: NSConsentPerson CreateDefaultConsentPerson()
intellisense: NSPersonAgent.CreateDefaultConsentPerson
keywords: NSPersonAgent, CreateDefaultConsentPerson
so.topic: reference
---

# NSConsentPerson CreateDefaultConsentPerson()
	  
Set default values into a new NSConsentPerson.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSConsentPerson with default values.

```crmscript
NSPersonAgent agent;
NSConsentPerson thing = agent.CreateDefaultConsentPerson();
thing = agent.SaveConsentPerson(thing);
```


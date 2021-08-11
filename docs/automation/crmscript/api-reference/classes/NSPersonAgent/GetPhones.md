---
uid: crmscript_ref_NSPersonAgent_GetPhones
title: NSEntityElement[] GetPhones(Integer personId)
intellisense: NSPersonAgent.GetPhones
keywords: NSPersonAgent, GetPhones
so.topic: reference
---

# NSEntityElement[] GetPhones(Integer personId)

Returning all phones that belong to a person, ordered by the phone type.

**Parameters:**
 - **personId** The person id

**Returns:** NSEntityElement[]

```crmscript
NSPersonAgent agent;
Integer personId;
NSEntityElement[] res = agent.GetPhones(personId);
```


---
uid: crmscript_ref_NSPersonAgent_GetPhones
title: EntityElement[] GetPhones(Integer personId)
intellisense: NSPersonAgent.GetPhones
keywords: NSPersonAgent, GetPhones
so.topic: reference
---

Returning all phones that belong to a person, ordered by the phone type.

**Parameters:**
 - **personId** The person id

**Returns:** An array of Phones

```crmscript
NSPersonAgent agent;
Integer personId;
EntityElement[] res = agent.GetPhones(personId);
```


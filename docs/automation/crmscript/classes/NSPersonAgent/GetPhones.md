---
title: crmscript_ref_NSPersonAgent_GetPhones
description: EntityElementArray GetPhones(Integer personId)
intellisense: NSPersonAgent.GetPhones
keywords: NSPersonAgent,GetPhones
so.topic: reference
---

Returning all phones that belong to a person, ordered by the phone type.

**Parameters:**
 - **personId** The person id

**Returns:** An array of Phones

```crmscript
NSPersonAgent agent;
Integer personId;
EntityElementArray res = agent.GetPhones(personId);
```


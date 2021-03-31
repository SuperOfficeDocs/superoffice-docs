---
uid: crmscript_ref_NSPersonAgent_GetAddress
title: Address GetAddress(Integer personId)
intellisense: NSPersonAgent.GetAddress
keywords: NSPersonAgent, GetAddress
so.topic: reference
---

Gets the person's localized address.

**Parameters:**
 - **personId** The person id

**Returns:** The address as LocalizedField[][].

```crmscript
NSPersonAgent agent;
Integer personId;
Address res = agent.GetAddress(personId);
```


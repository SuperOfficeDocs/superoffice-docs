---
uid: crmscript_ref_NSListAgent_GetLegalBaseList
title: NSLegalBase[] GetLegalBaseList(Integer[]  legalBaseIds);
intellisense: NSListAgent.GetLegalBaseList
keywords: NSListAgent, GetLegalBaseList
so.topic: reference
---

# NSLegalBase[] GetLegalBaseList(Integer[]  legalBaseIds);

Gets a vector of NSLegalBase objects.

**Parameters:**
 - **legalBaseIds** The identifiers of the NSLegalBase objects

**Returns:** NSLegalBase[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSLegalBase[] res = agent.GetLegalBaseList(ids);
```


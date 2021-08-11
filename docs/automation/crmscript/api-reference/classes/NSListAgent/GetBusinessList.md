---
uid: crmscript_ref_NSListAgent_GetBusinessList
title: NSBusiness[] GetBusinessList(Integer[]  businessIds);
intellisense: NSListAgent.GetBusinessList
keywords: NSListAgent, GetBusinessList
so.topic: reference
---

# NSBusiness[] GetBusinessList(Integer[]  businessIds);

Gets a vector of NSBusiness objects.

**Parameters:**
 - **businessIds** The identifiers of the NSBusiness objects

**Returns:** NSBusiness[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSBusiness[] list = agent.GetBusinessList(ids);
```


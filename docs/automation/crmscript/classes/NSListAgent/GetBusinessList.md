---
uid: crmscript_ref_NSListAgent_GetBusinessList
title: NSBusiness[] GetBusinessList(Integer[]  businessIds);
intellisense: NSListAgent.GetBusinessList
keywords: NSListAgent, GetBusinessList
so.topic: reference
---

Gets a vector of Business objects.

**Parameters:**
 - **businessIds** The identifiers of the NSBusiness objects

**Returns:** Vector of NSBusiness objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetBusinessList(ids);
```


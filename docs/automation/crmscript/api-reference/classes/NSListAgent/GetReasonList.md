---
uid: crmscript_ref_NSListAgent_GetReasonList
title: NSReason[] GetReasonList(Integer[]  reasonIds);
intellisense: NSListAgent.GetReasonList
keywords: NSListAgent, GetReasonList
so.topic: reference
---

# NSReason[] GetReasonList(Integer[]  reasonIds);

Gets a vector of NSReason objects.

**Parameters:**
 - **reasonIds** The identifiers of the NSReason objects

**Returns:** NSReason[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSReason[] res = agent.GetReasonList(ids);
```


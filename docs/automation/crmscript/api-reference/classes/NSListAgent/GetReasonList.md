---
uid: crmscript_ref_NSListAgent_GetReasonList
title: NSReason[] GetReasonList(Integer[]  reasonIds);
intellisense: NSListAgent.GetReasonList
keywords: NSListAgent, GetReasonList
so.topic: reference
---

Gets a vector of Reason objects.

**Parameters:**
 - **reasonIds** The identifiers of the NSReason objects

**Returns:** Vector of NSReason objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetReasonList(ids);
```


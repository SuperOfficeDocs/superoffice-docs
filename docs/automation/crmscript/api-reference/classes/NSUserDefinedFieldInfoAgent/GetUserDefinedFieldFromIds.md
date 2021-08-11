---
uid: crmscript_ref_NSUserDefinedFieldInfoAgent_GetUserDefinedFieldFromIds
title: NSUserDefinedFieldInfo[] GetUserDefinedFieldFromIds(Integer[] ids)
intellisense: NSUserDefinedFieldInfoAgent.GetUserDefinedFieldFromIds
keywords: NSUserDefinedFieldInfoAgent, GetUserDefinedFieldFromIds
so.topic: reference
---

# NSUserDefinedFieldInfo[] GetUserDefinedFieldFromIds(Integer[] ids)

Return an given array of user defined field identified by the ids.

**Parameters:**
 - **ids** Array of user defined field ids

**Returns:** NSUserDefinedFieldInfo[]

```crmscript
NSUserDefinedFieldInfoAgent agent;
Integer[] ids;
NSUserDefinedFieldInfo[] res = agent.GetUserDefinedFieldFromIds(ids);
```


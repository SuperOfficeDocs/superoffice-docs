---
uid: crmscript_ref_NSListAgent_GetLocalizedTextList
title: NSLocalizedText[] GetLocalizedTextList(Integer[]  localizedTextIds);
intellisense: NSListAgent.GetLocalizedTextList
keywords: NSListAgent, GetLocalizedTextList
so.topic: reference
---

Gets a vector of NSLocalizedText objects.

**Parameters:**
 - **localizedTextIds** The identifiers of the NSLocalizedText objects

**Returns:** NSLocalizedText[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSLocalizedText[] res = agent.GetLocalizedTextList(ids);
```


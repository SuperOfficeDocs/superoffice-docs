---
uid: crmscript_ref_NSListAgent_GetLanguageInfoList
title: NSLanguageInfo[] GetLanguageInfoList(Integer[]  languageInfoIds);
intellisense: NSListAgent.GetLanguageInfoList
keywords: NSListAgent, GetLanguageInfoList
so.topic: reference
---

Gets a vector of NSLanguageInfo objects.

**Parameters:**
 - **languageInfoIds** The identifiers of the NSLanguageInfo objects

**Returns:** NSLanguageInfo[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSLanguageInfo[] res = agent.GetLanguageInfoList(ids);
```


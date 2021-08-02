---
uid: crmscript_ref_NSListAgent_GetConsentSourceList
title: NSConsentSource[] GetConsentSourceList(Integer[]  consentSourceIds);
intellisense: NSListAgent.GetConsentSourceList
keywords: NSListAgent, GetConsentSourceList
so.topic: reference
---

Gets a vector of NSConsentSource objects.

**Parameters:**
 - **consentSourceIds** The identifiers of the NSConsentSource objects

**Returns:** NSConsentSource[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSConsentSource[] res = agent.GetConsentSourceList(ids);
```


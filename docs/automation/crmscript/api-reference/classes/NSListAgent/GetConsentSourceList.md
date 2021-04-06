---
uid: crmscript_ref_NSListAgent_GetConsentSourceList
title: NSConsentSource[] GetConsentSourceList(Integer[]  consentSourceIds);
intellisense: NSListAgent.GetConsentSourceList
keywords: NSListAgent, GetConsentSourceList
so.topic: reference
---

Gets a vector of ConsentSource objects.

**Parameters:**
 - **consentSourceIds** The identifiers of the NSConsentSource objects

**Returns:** Vector of NSConsentSource objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetConsentSourceList(ids);
```


---
uid: crmscript_ref_NSPersonAgent_GetConsentInfos
title: NSConsentInfo[] GetConsentInfos(Integer personId)
intellisense: NSPersonAgent.GetConsentInfos
keywords: NSPersonAgent, GetConsentInfos
so.topic: reference
---

Get all consent information for a given person. May include withdrawn consents (check 

**Parameters:**
 - **personId** The person id to get consents for

**Returns:** NSConsentInfo[]

```crmscript
NSPersonAgent agent;
Integer personId;
NSConsentInfo[] res = agent.GetConsentInfos(personId);
```


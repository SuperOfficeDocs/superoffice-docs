---
uid: crmscript_ref_NSListAgent_GetConsentPurposeList
title: NSConsentPurpose[] GetConsentPurposeList(Integer[]  consentPurposeIds);
intellisense: NSListAgent.GetConsentPurposeList
keywords: NSListAgent, GetConsentPurposeList
so.topic: reference
---

Gets a vector of NSConsentPurpose objects.

**Parameters:**
 - **consentPurposeIds** The identifiers of the NSConsentPurpose objects

**Returns:** NSConsentPurpose[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSConsentPurpose[] res = agent.GetConsentPurposeList(ids);
```


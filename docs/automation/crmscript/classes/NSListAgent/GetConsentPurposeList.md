---
title: crmscript_ref_NSListAgent_GetConsentPurposeList
description: NSConsentPurpose[] GetConsentPurposeList(Integer[]  consentPurposeIds);
intellisense: NSListAgent.GetConsentPurposeList
keywords: NSListAgent,GetConsentPurposeList
so.topic: reference
---

Gets a vector of ConsentPurpose objects.

**Parameters:**
 - **consentPurposeIds** The identifiers of the NSConsentPurpose objects

**Returns:** Vector of NSConsentPurpose objects

```crmscript
Integer[] ids;
NSListAgent agent;
agent.GetConsentPurposeList(ids);
```


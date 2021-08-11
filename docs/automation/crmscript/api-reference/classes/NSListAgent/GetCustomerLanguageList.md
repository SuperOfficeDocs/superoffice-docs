---
uid: crmscript_ref_NSListAgent_GetCustomerLanguageList
title: NSCustomerLanguage[] GetCustomerLanguageList(Integer[]  customerLanguageIds);
intellisense: NSListAgent.GetCustomerLanguageList
keywords: NSListAgent, GetCustomerLanguageList
so.topic: reference
---

# NSCustomerLanguage[] GetCustomerLanguageList(Integer[]  customerLanguageIds);

Gets a vector of NSCustomerLanguage objects.

**Parameters:**
 - **customerLanguageIds** The identifiers of the NSCustomerLanguage objects

**Returns:** NSCustomerLanguage[]

```crmscript
Integer[] ids;
NSListAgent agent;
NSCustomerLanguage[] res = agent.GetCustomerLanguageList(ids);
```


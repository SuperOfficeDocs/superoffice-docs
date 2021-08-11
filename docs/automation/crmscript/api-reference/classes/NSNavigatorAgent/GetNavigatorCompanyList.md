---
uid: crmscript_ref_NSNavigatorAgent_GetNavigatorCompanyList
title: NSNavigatorCompany[] GetNavigatorCompanyList(Integer[]  navigatorCompanyIds);
intellisense: NSNavigatorAgent.GetNavigatorCompanyList
keywords: NSNavigatorAgent, GetNavigatorCompanyList
so.topic: reference
---

# NSNavigatorCompany[] GetNavigatorCompanyList(Integer[]  navigatorCompanyIds);

Gets a vector of NSNavigatorCompany objects.

**Parameters:**
 - **navigatorCompanyIds** The identifiers of the NSNavigatorCompany objects

**Returns:** NSNavigatorCompany[]

```crmscript
Integer[] ids;
NSNavigatorAgent agent;
agent.GetNavigatorCompanyList(ids);
```


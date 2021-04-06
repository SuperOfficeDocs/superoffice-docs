---
uid: crmscript_ref_NSNavigatorAgent_GetNavigatorCompanyList
title: NSNavigatorCompany[] GetNavigatorCompanyList(Integer[]  navigatorCompanyIds);
intellisense: NSNavigatorAgent.GetNavigatorCompanyList
keywords: NSNavigatorAgent, GetNavigatorCompanyList
so.topic: reference
---

Gets a vector of NavigatorCompany objects.

**Parameters:**
 - **navigatorCompanyIds** The identifiers of the NSNavigatorCompany objects

**Returns:** Vector of NSNavigatorCompany objects

```crmscript
Integer[] ids;
NSNavigatorAgent agent;
agent.GetNavigatorCompanyList(ids);
```


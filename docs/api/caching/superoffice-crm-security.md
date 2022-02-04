---
title: SuperOffice.CRM.Security
uid: superoffice_crm_security
description: SuperOffice.CRM.Security
author: {github-id}
so.date: 05.11.2016
keywords: cache
so.topic: reference
---

# SuperOffice.CRM.Security

The namespace `SuperOffice.CRM.Security` exposes the following classes, which can be used in caching related to NetServer security issues and data.

* **DataRightsCache** holds different data rights on different tables used by the user.

* **FunctionRightsCache** stores information about summary of the Function rights that the user possesses.

* **OwnerContactCache** consists of information about the owner of the contact. The cache holds information on Contacts who may own Associates.

* **RefCountsPermissionCache** holds information on all tables that generate numbers such as company number, project number, and contact number. It is a numbered allocation system.

* **SentryPreferanceCache** holds information about the user’s sentry preferences.

* **UserGroupCahce** holds information about the user groups (Associates).

To use the cache, we would need to call the following two namespaces using the `using` keyword:

```csharp
using SuperOffice.CRM.Cache;
using SuperOffice.CRM.Security;
```

> [!NOTE]
> In some cases, it is necessary to indicate the entire path of the cache even though we have used the `using` statement to call the namespace. For example, when using the namespace SuperOffice.CRM.Rows, it would point to an ambiguous error since `ProbCache` is located in both the above namespaces.

```csharp
SuperOffice.CRM.Cache.ProbCache newProCache = SuperOffice.CRM.Cache.ProbCache.GetCurrent();
```

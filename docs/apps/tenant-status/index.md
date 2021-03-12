---
title: tenants       
description:                    
author: {github-id}             # Your GitHub alias.
keywords:
---

# Tenants

A **tenant** is a specific SuperOffice installation registered for a specific customer. In other words, the unique combination of customersite/custid.

Each application environment ([SOD, stage, production][1] has its own set of tenants. You will most likely be connecting to the free test tenant in SOD when you develop your [application][2].

In the SOD tenant, you get a new blank database. However, if you plan to create customizations based on a customer's own settings such as list items and user-defined fields, you probably need access to [production data][3].

> [!NOTE]
> For security reasons, we don't want production data in the SOD environment.

## Tenant status

Each tenant has a status page where you can [check its state][4] to ensure your application remain stable and responds accordingly. The URL is environment specific and contains the context identifier. For example:

 `https://**sod**.superoffice.com/api/state/**Cust00000**`

The information listed by [the state API][5]:

* context identifier
* endpoint
* functional state
* whether the tenant is running
* when the tenant information expires

## Notifications

When a tenant installation undergoes changes, SuperOffice sends a notification to each approved application. Notifications ensure that vendors are aware when the state of their customers change and that they know when tenants are unable to respond to requests.

> [!TIP]
> Notifications offer the ability to mitigate any potential errors that might occur due to state changes.

An application uses notifications to ensure it doesn't attempt to connect to that particular tenant when the tenant is unavailable. Then, the application is able to resume operation as normal when it receives a notification that indicates the tenant's availability is restored.

For example, when we upgrade a tenant, SuperOffice sends a notification to each application approved by the tenant to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Change type | Operation | Description |
|-----|-----|-----|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice |
| 1 | BackupRestored | This occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | This occurs when a tenant installation is placed in suspension. |
| 3 | Resume | This occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | This occurs when a tenant installation is deleted. |

<!-- Referenced links -->
[1]: ../apps/app-envir.md
[2]: ../apps/index.md
[3]: production-test-tenant.md
[4]: check-status.md
[5]: online-tenant-status.md

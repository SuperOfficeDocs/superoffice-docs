---
title: Tenant status
description: Tenant status
author: {github-id}
so.date:
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Tenant status

Each tenant has a status page where you can [check its state][1] to ensure your application remains stable and responds accordingly. The URL is environment-specific and contains the context identifier. For example:

 `https://**sod**.superoffice.com/api/state/**Cust00000**`

The information listed by [the state API][2]:

* context identifier
* endpoint
* functional state
* whether the tenant is running
* when the tenant information expires

## Notifications

When a tenant installation changes, SuperOffice sends a notification to each approved application. Notifications ensure that vendors are aware when the state of their customers changes and that they know when tenants are unable to respond to requests.

> [!TIP]
> Notifications offer the ability to mitigate any potential errors that might occur due to state changes.

An application uses notifications to ensure it doesn't attempt to connect to that particular tenant when the tenant is unavailable. Then, the application can resume operation as normal when it receives a notification that indicates the tenant's availability is restored.

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
[1]: check-status.md
[2]: online-tenant-status.md

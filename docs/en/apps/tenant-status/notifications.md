---
title: Tenant status notification
uid: tenant_status_notification
description: Tenant status notification
author: {github-id}
keywords: notification,monitor
so.topic: reference
so.envir: cloud
so.client: online
---

# Notifications

Notifications ensure that vendors are aware when the states of their customers change, for example, their SuperOffice subscription and that they know when tenants are unable to respond to requests.

When SuperOffice upgrades a tenant, for example, SuperOffice looks at each application approved by the tenant and sends out a notification to each one to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

You need to [register to get notifications][1].

## Payload

The JSON payload contains the following information:

* tenant context identifier
* the [change type][1]
* a text representation of the installation version
* the version of the file set
* a JWT to verify it was sent by SuperOffice

```javascript
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "ejy234ASD...1234#"
}
```

## Change type

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Type | Name | Description |
|:----:|------|-------------|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice |
| 1 | BackupRestored | Occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | Occurs when a tenant installation is placed in suspension. |
| 3 | Resume | Occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | Occurs when a tenant installation is deleted. |

<!-- Referenced links -->
[1]: get-notifications.md

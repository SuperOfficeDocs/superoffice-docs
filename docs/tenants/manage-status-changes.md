---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: manage_tenant_status_changes       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Manage tenant status changes # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: notification
so.topic: reference             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Manage tenant status changes

**When a tenant installation undergoes changes, SuperOffice sends out a change notification to each approved application.**

As tenant installations experience state changes, each application vendor is able to receive a notification about change events, and handle them if necessary. Notifications offers the ability to mitigate any potential errors that might occur when a tenant enters an unreachable state.

Applications use notifications to ensure the application does not attempts to connect to that particular tenant when the tenant is unavailable. Then, the application is able to resume operations as normal when a notification is received that indicates the tenants availability has resumed.

When SuperOffice upgrades a tenant, for example, SuperOffice looks at each application approved by the tenant, and sends out a notification to each one to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

## State change URL

To receive notifications, application vendors must provide a **State Change URL** that specifies where SuperOffice sends notifications. For example:

`https://www.awesomeapp.com/NotifyCustomerStateChange`

## Payload

The JSON payload contains the tenant context identifier, the change type, a text representation of the installation version, the version of the fileset, and a JWT to verify it was sent by SuperOffice.

```javascript
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "ejy234ASD...1234#"
}
```

### Change type

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Type | Name | Description |
|:----:|------|-------------|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice |
| 1 | BackupRestored | Occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | Occurs when a tenant installation is placed in suspension. |
| 3 | Resume | Occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | Occurs when a tenant installation is deleted. |

## Code Example

While there are several ways to accomplish processing these notifications, the following is a short description of what that might look using .NET and C#.

### CustomerStateChangeNotificationType Enumeration

[!include[ALT](./includes/notification-type.md)]

### Notification Message

[!include[ALT](./includes/notification-message.md)]

### API Controller and JWT Validation

[!include[ALT](./includes/api-controller.md)]

## Conclusion

It's important that application take advantage of these notifications to ensure their environments are kept up-to-date with the status of SuperOffice CRM Online tenants.

Notifications ensure vendors are aware when that state of existing customers change, for example their SuperOffice subscription, as well as know when tenants are placed in unstable states that do not respond to on-going requests.

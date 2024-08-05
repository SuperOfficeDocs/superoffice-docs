---
uid: app-best-practice-tenant-status-webhook
title: Tenant status webhook
description: Best practices for Tenant status webhook
author: Eivind Fasting
keywords: apps, best practices, 3rd-party, Tenant status
date: 08.05.2023
topic: howto
envir: cloud
client: online
---
# Tenant status webhook

When a tenant installation changes, SuperOffice sends a notification to each approved application.

To receive notifications, application vendors must provide a **State Change URL** that specifies where SuperOffice sends notifications. This can be done through the developer portal, and is described further down in this document.

Notifications ensure that vendors are aware when the states of their customers change, for example, their SuperOffice subscription and that they know when tenants are unable to respond to requests.

When SuperOffice upgrades a tenant, for example, SuperOffice looks at each application approved by the tenant and sends out a notification to each one to indicate that the tenant is about to be upgraded. This provides the application an opportunity to know when a tenant going to be unavailable and why communications with that tenant cease until further notice.

## To receive notifications (onetime set-up)

1. Set up a web service listening for state changes. For example:

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

2. In the Developer Portal, go to your app page.

3. Select **Configuration**.

4. Turn on **Advanced**.

5. Select **Notifications**.

    ![Configure notifications -screenshot][img1]

6. Enter the URL of your endpoint SuperOffice should push notifications to when a tenant changes status.

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

    Optionally, turn on **Configure per Environment** to set different URLs for SOD, Stage, and Production.

    ![Configure notifications per environment -screenshot][img2]

7. [!include[Has integration?](../../includes/has-integration.md)]

8. Click **Save Settings** or **OK**.

9. [Request to publish the new configuration.][1]

You are now set to parse notifications when you get them.

## Parse notifications

The application **must** take advantage of these notifications to ensure their environments are kept up-to-date with the status of SuperOffice CRM Online tenants.

While there are several ways to process tenant status changes notification, the following is a short example of what that might look like using .NET and C#.

### Payload

The JSON payload contains the following information:

* Tenant context identifier
* The change type
* A text representation of the installation version
* The version of the file set
* A JWT to verify it was sent by SuperOffice

```javascript
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "ejy234ASD...1234#"
}
```

### CustomerStateChangeNotificationType Enumeration

[!code-csharp[CS](includes/CustomerStateChangeNotificationType.cs)]

#### NotificationMessage

[!code-csharp[CS](includes/NotificationMessage.cs)]

#### API Controller and JWT Validation

[!code-csharp[CS](includes/ApiController.cs)]

### Change type

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Type | Name | Description |
|:----:|------|-------------|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice |
| 1 | BackupRestored | Occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | Occurs when a tenant installation is placed in suspension. |
| 3 | Resume | Occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | Occurs when a tenant installation is deleted. |

<!-- Referenced links -->
[1]: ../../create-app/request-to-publish.md

<!-- Referenced images -->
[img1]: ../media/notifications.png
[img2]: ../media/endpoint-per-envir.png

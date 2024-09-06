---
uid: notify-customer-state-change
title: Tenant status webhook
description: Get notifications when tenant status changes
keywords: state, tenant
author: Eivind Fasting, Bergfrid Dias
date: 09.06.2024
version_devportal: 1.25
topic: howto
envir: cloud
client: online
---

# Tenant status webhook

1. Set up a web service listening for state changes. For example:

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

1. In the Developer Portal, go to your app page.

1. Select **Configuration**.

1. Select **Integration settings**.

    ![Configure notifications -screenshot][img1]

1. Scroll down to the **Customer state change** section and enter the URL of your endpoint that SuperOffice should push notifications to when a tenant changes status.

    `https://www.awesomeapp.com/NotifyCustomerStateChange`

    Optionally, turn on **Configure per Environment** to set different URLs for SOD, Stage, and Production.

    ![Configure notifications per environment -screenshot][img2]

1. [!include[Has integration?](../../includes/has-integration.md)]

1. Click **Save Settings** or **OK**.

1. [Request to publish the new configuration.][1]

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
* The current public endpoint

**Upgrade:**

```json
{
  "ChangeType": 0,
  "ContextIdentifier": "Cust12345",
  "VersionName": "Release 8.4 R08",
  "FileVersion": "8.4.12.1234",
  "Token": "eyJ234ASD...1234#"
}
```

**Move endpoint:**

```json
{
  "ChangeType":5,
  "ContextIdentifier":"Cust12345",
  "VersionName":"Release_10.3.8_2024.08.30-01",
  "FileVersion":"10.3.8.2024",
  "Token":"eyJ....",
  "PublicEndpoint":"sod3.superoffice.com"
}
```

### CustomerStateChangeNotificationType enumeration

[!code-csharp[CS](includes/CustomerStateChangeNotificationType.cs)]

#### NotificationMessage

[!code-csharp[CS](includes/NotificationMessage.cs)]

#### API Controller and JWT validation

[!code-csharp[CS](includes/ApiController.cs)]

### Change type

The **change type** is a number value that corresponds to the operation performed on the tenant. The possible change types are:

| Type | Name | Description |
|:----:|------|-------------|
| 0 | Upgrade | Occurs when a tenant installation is upgraded to a new version of SuperOffice. |
| 1 | BackupRestored | Occurs when a tenant installation is restored from a backup. |
| 2 | Suspend | Occurs when a tenant installation is placed in suspension. |
| 3 | Resume | Occurs when a tenant installation is resumed from another operation. |
| 4 | Delete | Occurs when a tenant installation is deleted. |
| 5 | Move | Occurs when a tenant is moved to another public endpoint. Check the `PublicEndpoint` value. |

<!-- Referenced links -->
[1]: ../../create-app/request-to-publish.md

<!-- Referenced images -->
[img1]: ../../media/integration-settings.png
[img2]: ../media/endpoint-per-envir.png

---
title: Get tenant status notifications
uid: notify-customer-state-change
description: Get notifications when tenant status changes
author: Margrethe Romnes
so.date: 09.12.2023
keywords: state, tenant
so.topic: howto
so.envir: cloud
so.client: online
---

# Register to get notifications when tenant status changes

When a tenant installation changes, SuperOffice sends a [change notification][2] to each approved application. The **State change URL** is set in the advanced application configuration of each application.

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

7. [!include[Has integration?](includes/has-integration.md)]

8. Click **Save Settings** or **OK**.

9. [Request to publish the new configuration.][3]

You are now set to parse notifications when you get them.

## Parse notifications

The application **must** take advantage of these notifications to ensure their environments are kept up-to-date with the status of SuperOffice CRM Online tenants.

While there are several ways to process tenant status changes notification, the following is a short example of what that might look like using .NET and C#.

### CustomerStateChangeNotificationType Enumeration

[!code-csharp[CS](includes/CustomerStateChangeNotificationType.cs)]

### NotificationMessage

[!code-csharp[CS](includes/NotificationMessage.cs)]

### API Controller and JWT Validation

[!code-csharp[CS](includes/ApiController.cs)]

<!-- Referenced links -->
[2]: index.md#notify
[3]: ../../create-app/request-to-publish.md

<!-- Referenced images -->
[img1]: ../media/notifications.png
[img2]: ../media/endpoint-per-envir.png

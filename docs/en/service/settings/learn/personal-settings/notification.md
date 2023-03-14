---
uid: help-en-service-settings-personal-notification
title: Notification
description: Learn how to set up notifications in this how-to guide.
author: Bergfrid Dias
so.date: 03.14.2023
keywords: personal settings, notification
so.topic: reference
language: en
so.client: Service
---

# Notification

In SuperOffice Service, request handlers can choose to receive notifications of various events.

Requests with a high priority should be solved before you complete other requests. But how do you know that a high priority request has come in, been escalated to you, or was reopened by the customer? SuperOffice will notify you by showing you a pop-up on your screen, sending you an email or an SMS. This way you will know a request is waiting for you and you will not forget to follow up on it.

## Settings

You can decide how you wish to be alerted by setting up your notifications. In the **Notification** tab in the **Edit users** screen, you can check how you want to receive such notifications.

![Open the Notification tab in the Edit users dialogue and set up the notifications according your personal preferences -screenshot][img3]

* **Pop-up**: The notification button ![icon][img2] in the [top bar][1] will indicate that you have new notifications.
* **Email**: You will receive an email message when an event occurs.
* **SMS** (if the SMS module is installed): You will receive a text message when an event occurs.

You can receive notifications of the following events in SuperOffice Service.

* **Open requests, not read in the last \[number\] days**: Check here to be notified of open requests that have not been edited for the specified number of days and where you are the owner.

    > [!NOTE]
    > This option is activated from ![icon][img1] **System settings** > **System** > **Settings** > **Send email notification of open requests**.

* **New request**: Check here to be notified each time you are assigned a new request.

* **New message in request**: Check here to be notified each time a new message arrives for one of your requests.

* **Request escalated**: Check here to be notified when one of your requests is escalated (forwarded to another request handler under the [rules defined for escalation][2]).

* **Request activated**: Check here to be notified when one of your requests is activated (given the **Open** status again after having been **Postponed** or **Closed**).

* **When someone takes over your request**: Check here to be notified when one of your requests is taken over by another request handler.

* **For requests in your favorites list**: Check here to be notified about requests in your favorites list, in the same way as for your own requests.

* **Custom messages**: Check here to receive custom notifications created using scripts.

<!-- Referenced links -->
[1]: ../../../../learn/getting-started/main-screen/buttons-in-menu-bar.md
[2]: ../../../../request/learn/priority/escalation-levels.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/settings-small.png
[img2]: ../../../../../media/icons/notice-new.png
[img3]: media/service-notification-settings.png

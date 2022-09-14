---
uid: help-en-admin-edituser-helpnotification
title: admin editUser helpNotification
description: admin editUser helpNotification
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Notification

In SuperOffice Service, request handlers can choose to receive notifications of various events. In the **Notification** tab in the **Edit users** screen, you can check how you want to receive such notifications:

* **Pop-up**: The notification button ( ![icon][img2] ) in the [top bar][1] will indicate that you have new notifications.
* **E-mail**: You will receive an e-mail message when an event occurs.
* **SMS** (if the SMS module is installed): You will receive a text message when an event occurs.

You can receive notifications of the following events in SuperOffice Service.

* **Open requests, not read in the last \[number\] days**: Check here to be notified of open requests that have not been edited for the specified number of days and where you are the owner.

    > [!NOTE]
    > This option is activated from ![icon][img1] **System settings** &gt; **System** &gt; **Settings** &gt; **Send e-mail notification of open requests**.

* **New request**: Check here to be notified each time you are assigned a new request.

* **New message in request**: Check here to be notified each time a new message arrives for one of your requests.

* **Request escalated**: Check here to be notified when one of your requests is escalated, i.e. forwarded to another request handler under the rules defined for escalation (see [Work with escalation levels][2]).

* **Request activated**: Check here to be notified when one of your requests is activated, i.e. is given the **Open** status again after having been **Postponed** or **Closed**.

* **When someone takes over your request**: Check here to be notified when one of your requests is taken over by another request handler.

* **For requests in your favourites list**: Check here to be notified about requests in your favourites list, in the same way as for your own requests.

* **Custom messages**: Check here to receive custom notifications created using scripts.

<!-- Referenced links -->
[1]: ../../../getting-started/buttons-in-menu-bar.md
[2]: listPriorities.editAlert.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/globalmenu-settings-small.png
[img2]: ../../../../media/icons/globalmenu-notice-new.png

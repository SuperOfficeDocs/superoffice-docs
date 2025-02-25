---
uid: dp-error-email
title: Error reporting emails
description: How to subscribe to error emails in the SuperOffice Developer Portal.
keywords: Developer Portal, app, notification, error, tenant status
author: Bergfrid Dias
date: 01.30.2025
version: 1.30
version_devportal: 1.30
topic: howto
envir: cloud
client:
---

# Error reporting emails

SuperOffice will also send you emails when there is a problem with your application or someone wish to uninstall it. By default, these emails go to the technical contact of the application. However, you can also specify a list of addresses for error reporting and uninstall.

Watch the walk-through on YouTube:

<!-- markdownlint-disable-next-line MD034 MD007 -->
> [!Video https://www.youtube-nocookie.com/embed/kqEpAw7qQEY?start=1400]

## ERP sync, quote, and mirroring

For each endpoint you have configured SuperOffice to send data to, you can also subscribe to error emails.

To turn off/on error emails to the technical contact for an endpoint, update the integration settings configuration of the application.

* [ERP sync][5]
* [Quote connector][6]
* [Database mirror][4]

To receive error emails at different or more than one email addresses, update the application settings:

1. On the app page, select **Settings** from the left menu or click the **Edit** button.

1. Scroll to **Error reporting emails**.

1. Enter one or more email addresses, then press Enter after each one to add them to the list.

1. Click **Save Settings**.

![Application settings, error reporting emails -screenshot][img3]

> [!NOTE]
> You can update the email addresses in the application settings at any time. Technical contact will receive any notification mail if this field is blank.

## Uninstall reporting emails

To receive notifications when an app uninstall request is submitted, update the **Uninstall reporting emails** field in the application settings.

1. On the app page, select **Settings** from the left menu or click the **Edit** button.
2. Scroll to **Uninstall reporting emails**.
3. Enter one or more email addresses, then press **Enter** after each one to add them to the list.
4. Click **Save Settings**.

> [!NOTE]
> If app's list is blank, uninstall notifications will be sent to the partner's **Uninstall reporting emails** list.
>
> If both lists are blank, uninstall notifications will be sent to the partner's **administrative contact**.

## Other errors

For other errors, such as when a customer reports a problem from the App Store, the technical contact will be notified if error reporting emails field is empty.

## Read more

* [How to change contact person][8]
* [About tenant status notifications][1]
* [Troubleshooting authorizing an application and working with tokens][7]

<!-- Referenced links -->
[1]: tenant-status/index.md

[4]: ../create-app/config/update-endpoints.md
[5]: ../create-app/config/update-endpoints.md
[6]: ../create-app/config/update-endpoints.md
[7]: ../../api/authentication/online/troubleshooting/index.md
[8]: ../faq/update-contact-person.md

<!-- Referenced images -->
[img3]: ../media/error-reporting-emails.png

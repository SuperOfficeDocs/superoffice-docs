---
title: Update app config
uid: dp-update-app-config
description: Update technical specification for an application
author: Bergfrid Dias
so.date: 08.26.2022
keywords: App Store
so.topic: howto
so.envir: cloud
so.client: online
---

# Update app config

The application configuration, also known as the technical specification, consists of many sections. For details about each field, see the [app config reference section](../reference/app-config.md).

1. In the [Developer Portal][7], go to your application page.
1. Select **Configuration** from the left menu.
1. Toggle on **Advanced**.
1. [Create a new version.][3]
1. Go through each sub-section and change what you need.

    * [Create a new client secret][2]
    * [Create a new certificate][3]
    * [Change redirection URLs][5]
    * [Update endpoints][4]
    * [Customer state change notifications][6]

    > [!NOTE]
    > For any other changes, send an email to `appdev AT superoffice.com`.

1. Click **Save Settings**.
1. [Request to publish][1] the configuration. Extensive changes might trigger re-certification.

> [!CAUTION]
> If you add database mirroring or webhooks, the tenant administrator must renew the consent to your application. **Users will be locked out from when the change happens until the consent has been given.**

<!-- Referenced links -->
[1]: request-to-publish.md
[2]: ../security/get-client-secret.md
[3]: ../security/new-certificate.md
[4]: update-endpoints.md
[5]: ../security/cors-and-redirection-urls.md
[6]: ../howto/notifications.md
[7]: https://dev.superoffice.com/

---
uid: dp-update-app-config
title: Update app config
description: Update technical specification for an application
keywords: app config
author: Bergfrid Dias
date: 02.26.2025
version: 2.0
version_devportal: 2.0
topic: howto
envir: cloud
client: online
---

# Update app config

The application configuration, also known as the technical specification, consists of many sections. For details about each field, see the [app config reference section][8].

1. In the [Developer Portal][7], go to your application page.
1. Select **Configuration** from the left menu.
1. [Create a new version.][3]
1. Go through each tab and change what you need.

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
[1]: ../request-to-publish.md
[2]: get-client-secret.md
[3]: new-certificate.md
[4]: update-endpoints.md
[5]: cors-and-redirection-urls.md
[6]: ../../best-practices/tenant-status/index.md#notify
[7]: https://dev.superoffice.com/
[8]: app-config.md

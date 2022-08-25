---
title: Application settings
uid: dp-app-settings
description: Reference of application settings in the SuperOffice Developer Portal.
author: Bergfrid Dias
so.date: 06.08.2022
keywords: apps, Developer Portal
so.topic: reference
so.version:
so.envir: cloud
so.client:
---

# Application settings

These settings may only be changed by SuperOffice app managers. Contact us via chat or support if you want to request any changes.

![Application settings in the SuperOffice Developer Portal -screenshot][img1]

| Setting | Description | How-tos | Read more |
|---|---|---|---|
| Application name | The human-readable name of the application. | [Update app info][9] | [Naming requirements][8] |
| SEO-friendly name | For search engines. | [Update partner profile][2], [Update the product page][9] | [Improve SEO][10] |
| Authorize | The description shown in the concent dialog when the admin is prompted to approve the application. | [Get consent][5] | [About consent][15] |
| Technical contact | The contact person for this app. | [Update contact person][1] | |
| Error reporting emails | Semicolon-separated list of email addresses that should receive error emails. If empty, technical contact will get these. | [Set state change URL][11], [Get error emails][11] | [About tenant status][17] |
| Hidden from Our Apps | If checked, this app will not show up when customers go to the App Store and see their installed apps. | | |
| Is custom app | Whether this is a one-off customization or if we should provide the option to publish to the app store as a standard app. | [Create app][13] | [About custom apps][6] |
| Is beta | Whether the app is currently in beta in the App Store. | [Publish app][14] | [About the beta period][7] |

## See also

* [Application configuration][2]
* [Partner settings][3]
* [User settings][4]

<!-- Referenced links -->
[1]: ../howto/update-contact-person.md
[2]: app-config.md
[3]: partner-settings.md
[4]: user-settings.md
[5]: ../../apps/provisioning/get-consent.md
[6]: ../../apps/custom.md
[7]: ../../apps/publish/beta-period.md
[8]: ../../apps/requirements/marketing.md#application-name
[9]: ../app-store/update-app-page.md
[10]: ../app-store/seo.md
[11]: ../howto/notifications.md#tenant-status
[12]: ../app-store/update-company-profile.md
[13]: ../create-app/index.md
[14]: ../../apps/publish/index.md
[15]: ../../apps/provisioning/consent.md
[16]: ../howto/notifications.md#erp-sync-quote-and-mirroring
[17]: ../../apps/tenant-status/index.md

<!-- Referenced images -->
[img1]: ../media/app-overview.png

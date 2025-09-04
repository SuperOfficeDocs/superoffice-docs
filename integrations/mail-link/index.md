---
uid: mail-link
title: MailLink
description: SuperOffice Mail Link is a plug-in that links the Microsoft Outlook mail client with SuperOffice CRM.
keywords: MailLink, email plugin, email add-on, email extension
author: SuperOffice Product and Engineering
date: 06.29.2022
content_type: concept
category: integration
topic: Mail Link
audience: person
audience_tooltip: SuperOffice CRM
redirect_from:
  - /en/email/mail-link/index
  - /en/email/mail-link/learn/index
  - /da/email/mail-link/learn/index
  - /de/email/mail-link/learn/index
  - /nl/email/mail-link/learn/index
  - /no/email/mail-link/learn/index
  - /sv/email/mail-link/learn/index
index: true
---

# MailLink

SuperOffice Mail Link is a plug-in that links the Microsoft Outlook mail client with SuperOffice CRM and/or SuperOffice Service. This means that among other things, you can:

* Archive emails and attachments to SuperOffice CRM.
* Archive an email as a document or a task in SuperOffice CRM.
* Archive an email as a request in SuperOffice Service.
* Search for the sender of an email.
* Set functions for default archiving.
* Use SuperOffice templates or predefined email body templates when creating emails.
* Update the information about companies and contacts in SuperOffice CRM based on emails you receive.

## Buttons on the mail client toolbar

These buttons appear on the Microsoft Outlook toolbar:

| Button | Function |
|:-:|---|
| ![icon][img4] | Archiving emails to SuperOffice CRM |
| ![icon][img5] | Searching for the sender of an email |
| ![icon][img3] | Click the small arrow to the right of the **SuperOffice** button to open the **SuperOffice CRM options** dialog. |

## Modes of operation

SuperOffice MailLink (part of SuperOffice WebTools) supports 2 main modes of operation:

* Against a Web installation
* Against a Windows installation

## Components

![Mail Link components -screenshot][img2]

The picture was different before 8.3:

![Mail Link legacy components -screenshot][img1]

## Compatibility

One version of WebTools should now be compatible with all versions of SuperOffice: Online, Onsite Web, (future releases of) Onsite Windows.

**MailLink (and WebTools) will only exist in one version: The latest version.**

In older WebTools versions (before 8.3), MailLink shipped with its own copy of NetServer and ran its own database layer directly. In this case, if you have a SuperOffice Windows installation and download the latest WebTools from the [SuperOffice Download Service][1], you may end up in a situation where your MailLink runs a newer version of NetServer and expects a different database schema than the one you have.

The Windows client installer will also install *one* extra file into the client folder: *SuperOffice.MailLink.WinClient.dll*. **This file must be present for this new MailLink to enable "Windows mode"** (which means it will not work with older versions of the Windows client). If this file is not found, only web support is available.

## How to install only MailLink part of WebTools

MailLink is now a separate downloadable installer (the latest version) available on the Download Service so customers wishing to upgrade only MailLink can do so.

## Related content

* [Archive emails to SuperOffice CRM][2]
* [Create emails from SuperOffice CRM][5]
* [Create emails from Microsoft Outlook][6]
* [Search for the sender of an email][3]
* [Set options][4]

<!-- Referenced links -->
[1]: https://www3.superoffice.com/DownloadService/
[2]: archive.md
[3]: manage-senders.md
[4]: settings.md
[5]: create-in-superoffice.md
[6]: create-in-outlook.md

<!-- Referenced images -->
[img1]: media/webtools-old-schema.png
[img2]: media/webtools-new-schema.png
[img3]: ../../docs/media/loc/en/email/superoffice-button.png
[img4]: ../../docs/media/icons/mail-link/archive-to-superoffice-crm.png
[img5]: ../../docs/media/icons/mail-link/search-for-sender-in-superoffice-crm.png

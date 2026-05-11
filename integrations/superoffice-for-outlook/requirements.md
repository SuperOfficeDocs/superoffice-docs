---
uid: sofo-requirements
title: Requirements
description: Requirements and known limitations of SuperOffice for Outlook add-in
keywords: SuperOffice for Outlook, Outlook, email, SOFO
author: Frode B, Martin Pavlas
date: 05.05.2026
version_sofo: 6.3.0
content_type: reference
category: integration
topic: SuperOffice for Outlook
deployment: online
platform: web
audience: person
audience_tooltip: SuperOffice CRM
language: en
index: true
redirect_from: 
  - /en/email/superoffice-for-outlook/requirements
  - /en/email/superoffice-for-outlook/learn/requirements
  - /da/email/superoffice-for-outlook/learn/requirements
  - /de/email/superoffice-for-outlook/learn/requirements
  - /nl/email/superoffice-for-outlook/learn/requirements
  - /no/email/superoffice-for-outlook/learn/requirements
  - /sv/email/superoffice-for-outlook/learn/requirements
---

# Requirements

* Available for both CRM Online and Onsite customers
  * Onsite: SuperOffice CRM Onsite 10.0.1 or newer (available on the internet with REST API enabled)
* Users must have a Microsoft 365 subscription and must use a Microsoft 365 mail account
* A compatible version of Outlook
* For mobile phones, the latest version of iOS or Android and use an app that supports Outlook add-ins

## Office versions

* Microsoft 365
* Office 2021 or higher
* Office 2021 for Mac or higher

## Outlook clients

* Outlook on the web
* Classic Outlook
* New Outlook
* Outlook for Mac
* [Microsoft Outlook for iOS][2]
* [Microsoft Outlook for Android][3]

## Supported browsers
The latest version of the following browsers are supported for Outlook on the web:
* Microsoft Edge
* Google Chrome
* Mozilla Firefox
* Apple Safari (macOS)

## Shared mailbox support

SuperOffice for Outlook supports shared mailboxes when the mailbox is available to the user in Outlook and the required Microsoft 365 permissions have been granted.

Users may be asked to approve additional Microsoft permissions the first time they use SuperOffice for Outlook with a shared mailbox. In some organizations, an administrator must approve these permissions on behalf of all users before shared mailbox features can be used.

Shared mailbox access is controlled by Microsoft 365. If a shared mailbox does not appear in Outlook, or if you cannot send from it, contact your Microsoft 365 administrator.

See also: See also: [SuperOffice for Outlook: Authorisation guide][1]

> [!NOTE]
SuperOffice for Outlook requires a Microsoft 365 or Exchange account. 
This is a Microsoft limitation - SuperOffice for Outlook uses Microsoft's 
Graph API, which only supports work or school accounts within Microsoft 365 
or Exchange. Consumer email accounts from providers such as Gmail, Yahoo, 
Hotmail, iCloud, and AOL are not supported.

> [!TIP]
> If you use Gmail, SuperOffice offers a separate integration. 
> See [SuperOffice for Gmail][4].

## Attachment size limit

Attachments saved to SuperOffice from SuperOffice for Outlook cannot exceed 28 MB. Attachments larger than this limit cannot be saved.

## Requirements for centralized deployment

Learn more about the requirements for [Centralized Deployment][5] from Microsoft.

If an add-in update significantly increases the scope of data access, you must re-approve it before the update is deployed.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/support-faqs/faq/superoffice-for-outlook-authorisation-guide/
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[4]: https://online.superoffice.com/appstore/superoffice-as/superoffice-gmail-link
[5]: https://aka.ms/centralized-deployment-guidance

---
uid: help-en-superoffice-for-outlook-requirements
title: Requirements
description: Requirements and known limitations of SuperOffice for Outlook add-in
keywords: SuperOffice for Outlook, Outlook, email
author: Frode B, Martin Pavlas
date: 01.27.2025
version_sofo: 2024.8.12
topic: reference
envir: cloud
client: online
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Requirements

* Available for both CRM Online and Onsite customers
  * Onsite: SuperOffice CRM Onsite 10.0.1 or newer (available on the internet with REST API enabled)
* Users must have a Microsoft 365 subscription and must use Microsoft 365 mail account
* A compatible version of Outlook
* For mobile phones, the latest version of iOS or Android and use an app that supports Outlook add-ins

## Outlook versions

* Outlook on the Web
* Outlook 2016 for Mac
* Outlook 2016 or later
* Outlook desktop app version 2001 or newer
* [Microsoft Outlook for iOS][2] on iOS 13
* [Microsoft Outlook for Android][3] on Android 10

## Limitations

SuperOffice for Outlook works only with main account. Shared mailboxes are not supported.

Versions earlier than 2001 of the Outlook desktop app do not work in Send and Archive, because they lack APIs.

![Limitations in Outlook for SuperOffice -screenshot][img1]

## Requirements for centralized deployment

Learn more about the requirements for [Centralized Deployment][5] from Microsoft.

If an add-in update significantly increases the scope of data access, you must re-approve it before the update is deployed.

<!-- Referenced links -->
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/email/outlook-api-limitation.png

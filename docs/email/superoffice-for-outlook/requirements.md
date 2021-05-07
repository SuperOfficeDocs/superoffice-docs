---
title: superoffice_for_outlook_requirements
description: Requirements and known limitations of SuperOffice for Outlook add-in
author: {github-id}
keywords:
so.topic: reference
# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# Requirements

* Available for CRM Online customers only
* Users must have an Office 365 subscription and must use Office 365 mail account
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

Versions earlier than 2001 of the Outlook desktop app do not work in Send and Archive, because they miss APIs.

![imagecaqul.png -screenshot][img1]

The current released add-on version (via the MS App Source) do not support Mobile phones (the mobile device API).

To get the version that has support for the mobile devices, use one of these options:

* option a: [centralized deployment][1]

* option b: [use the pilot version][4]

## Requirements for centralized deployment

Learn more about the requirements for [Centralized Deployment][5] from Microsoft.

If an add-in update significantly increases the scope of data access, you must re-approve it before the update is deployed.

<!-- Referenced links -->
[1]: deploy-centrally.md
[2]: https://apps.apple.com/us/app/microsoft-outlook/id951937596
[3]: https://play.google.com/store/apps/details?id=com.microsoft.office.outlook
[4]: https://community.superoffice.com/en/customer/forum/rooms/topic/pilot-program/superoffice-for-outlook/how-to-deploy-superoffice-for-outlook-during-pilot/
[5]: https://aka.ms/centralized-deployment-guidance

<!-- Referenced images -->
[img1]: media/imagecaqul.png
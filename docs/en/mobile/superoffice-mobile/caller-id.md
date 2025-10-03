---
uid: mobile-crm-caller-id
title: Enable caller ID
description: How to enable caller ID in SuperOffice Mobile CRM.
keywords: mobile, caller ID, call identification, phone number
author: Bergfrid Dias
date: 06.10.2025
version: 11.1
content_type: howto
platform: mobile
language: en
index: true
---

# Enable caller ID

Caller ID in Mobile CRM shows the name of incoming callers if their number is saved in SuperOffice CRM. On Android, you can also save the call directly to SuperOffice as an activity.

![Caller ID for Mobile CRM iOS -app-screen][img2]![Caller ID for Mobile CRM Android -app-screen][img3]

> [!NOTE]
> To activate this function, you must allow SuperOffice to provide information about incoming calls in the phone's settings.
>
> Caller ID requires version 10.1.9 or higher of Mobile CRM.

## Why enable caller ID

* See who's calling—even if the number is not in your phone contacts.
* React personally to customer calls.
* Notice missed calls from a registered contact.
* Keep your private and professional contact lists separate.
* Avoid syncing all CRM contacts to your phone (GDPR-friendly).

## Included phone numbers

Caller ID uses numbers from:

* All persons and companies in follow-ups, sales, documents, and requests created by you or your primary group in the last 12 months (with active dates ±12 months).
* All colleagues across all groups.

> [!NOTE]
> For each person or company, all stored phone numbers are included. If duplicates exist, the most recently updated one is shown.

## Requirements

* SuperOffice CRM Online (any user plan)
* Mobile CRM app version 10.1.9 or higher

## How to enable caller ID

1. In Mobile CRM, tap <i class="ph ph-list" aria-label="Main menu"></i> in the bottom center of the screen and select **Settings**.
2. Tap **Allow call identification**.
3. Tap **Open settings menu** to go to your device's settings and complete setup.

    ![Allow call identification -app-screen][img4]

<!-- markdownlint-disable-file MD029 MD051 -->
### [iOS](#tab/ios)

4. In iOS settings, go to **Call Blocking & Identification** and enable **SuperOffice**.

    * If your phone opened the general **Phone** settings, scroll down and tap **Call Blocking & Identification**.

5. Check if **Background App Refresh** is enabled for SuperOffice:

    * If this option is **not visible**, you're all set. Caller ID will work.
    * If visible, go to **Settings** > **General** > **Background App Refresh**, and turn it on for SuperOffice.

    ![Call Blocking & Identification -app-screen][img5]![Background App Refresh -app-screen][img7]

### [Android](#tab/android)

4. You will be taken to the **Display over other apps** screen. Enable **SuperOffice**.

5. Grant the necessary permissions:
    * Allow **Draw over other apps**.
    * If prompted, also allow access to **Call logs** and **Phone** permissions.

    ![Display/Draw over other apps -app-screen][img8]

> [!NOTE]
> If you previously denied permission with "Do not ask again," go to **Settings** > **Apps** > **Permissions**, and enable **Call logs** and **Phone** for the SuperOffice app manually.

***

When setup is complete, the "Allow call identification" setting in Mobile CRM will show **Active**.

![Background update not active -app-screen][img6]

## Related content

* [Settings][1] reference

<!-- Referenced links -->
[1]: settings.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/mobile/caller-id-ios.png
[img3]: ../../../media/loc/en/mobile/caller-id-android.png
[img4]: ../../../media/loc/en/mobile/open-settings-menu.png
[img5]: ../../../media/loc/en/mobile/ios-call-blocking.png
[img6]: ../../../media/loc/en/mobile/allow-call-identification.png
[img7]: ../../../media/loc/en/mobile/background-app-refresh.png
[img8]: ../../../media/loc/en/mobile/android-call-id.png

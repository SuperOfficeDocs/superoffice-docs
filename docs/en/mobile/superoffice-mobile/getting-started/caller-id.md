---
uid: mobile-crm-caller-id
title: Enable caller ID
description: How to enable caller ID in SuperOffice Mobile CRM.
keywords: mobile, caller ID, call identification, phone number
author: Bergfrid Dias
date: 09.24.2024
version: 10
topic: howto
language: en
client: mobile
---

# Enable caller ID

With the Caller ID function enabled in Mobile CRM you can see the name of the person who is calling you, if the phone number is stored in SuperOffice CRM. On Android phones, you can also save the phone call directly to SuperOffice as an activity.

![Caller ID for Mobile CRM -app-screen][img1]![Caller ID for Mobile CRM -app-screen][img2]

## Why enable caller ID

* Know who is calling you​ and answer the call in a personal way
* Notice missed calls from a registered contact
* Avoid saving all your contacts in your local address book (GDPR related)​

## Included numbers

* All persons and companies from follow-ups, sales, documents, and requests created by you or colleagues in you primary group within the last 12 months, with active dates +- 12 months
* All colleagues from all groups

> [!NOTE]
> For each included person and company, all phone numbers are added. If duplicates exist, the most recently updated number is used.

## Requirements

* SuperOffice CRM Online (included in all user plans)
* Mobile CRM app: version 10.1.9 or higher

## Steps

1. In Mobile CRM, go to **Settings**
2. Select **Allow call identification**.
3. Tap **Open settings menu**. This takes you to the iOS or Android settings where you can activate Caller ID​. The next steps depend on your device.

![Allow call identification -app-screen][img3]![Allow call identification -app-screen][img4]

<!-- markdownlint-disable MD029 -->
### iOS

4. In the **Call Blocking & Identification** screen in iOS settings you can activate the SuperOffice app​.

    * If your phone opened the **Phone settings** screen in iOS settings instead, find **Call blocking & Identification** in the list and click on it to get to the screenshot above.

    ![Call Blocking & Identification -app-screen][img5]

    The allow call Identification function is now set to *Active*.

5. Do you see the **Background update** setting?

    * If no, your device and app are ready to use Caller ID for Mobile CRM (the setting is active by default).
    * If yes, like in the screenshot below, you must enable **Background App Refresh** for SuperOffice Mobile CRM. This settings is found in iOS settings under **General.**​

    ![Background update not active -app-screen][img6]![Background App Refresh -app-screen][img7]

### Android

4. You may end up in the **Display over other apps** screen in Android settings. Activate the SuperOffice app.

5. Allow the permission requests as they appear and enable **Display/Draw over other apps** for SuperOffice. Tap the previous page button twice to go back to Mobile CRM.

    ![Display/Draw over other apps -app-screen][img8]

    > [!NOTE]
    > If you have previously chosen "Deny, do not ask again" to the permission requests, you need to go into the general phone settings to allow SuperOffice to access your phone call logs and make and manage phone calls.
    >
    > Go to **Settings** > **Apps** > **Permissions**. Select **Call logs** and **Phone** and give the SuperOffice app these permissions.

6. The Mobile CRM Settings screen for "Allow call identification" will now show *Active*. Your device and app are now ready to use Caller ID for Mobile CRM.

<!-- markdownlint-enable MD029 -->

## Related content

* [Settings][1] reference

<!-- Referenced links -->
[1]: ../settings.md

<!-- Referenced images -->
[img1]: media/incoming-call.png
[img2]: media/caller-id.png
[img3]: media/allow-call-identification.png
[img4]: media/open-settings-menu.png
[img5]: media/ios-call-blocking.png
[img6]: media/background-update-inactive.png
[img7]: media/background-app-refresh.png
[img8]: media/android-call-id.png

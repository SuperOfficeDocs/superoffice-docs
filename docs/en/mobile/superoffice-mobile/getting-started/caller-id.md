---
uid: mobile-crm-caller-id
title: Enable caller ID
description: How to enable caller ID in SuperOffice Mobile CRM.
author: Bergfrid Dias
so.date: 07.24.2023
keywords: mobile, caller ID
so.topic: howto
so.version: 10
language: en
so.client: mobile
---

# Enable caller ID

With the Caller ID function enabled in Mobile CRM you can see the name of the person who is calling you, if the phone number is stored in SuperOffice CRM. On Android phones, you can also save the phone call directly to SuperOffice as an activity.

![Caller ID for Mobile CRM -mobile-screenshot][img1]![Caller ID for Mobile CRM -mobile-screenshot][img2]

## Requirements

* SuperOffice CRM Online
* Mobile CRM app: version 10.1.9 or higher

## Steps

1. In Mobile CRM, go to **Settings**
2. Select **Allow call identification**.
3. Tap **Open settings menu**. This takes you to the iOS or Android settings where you can activate Caller ID​. The next steps depend on your device.

![Allow call identification -mobile-screenshot][img3]![Allow call identification -mobile-screenshot][img4]

<!-- markdownlint-disable MD029 -->
### iOS

4. In the **Call Blocking & Identification** screen in iOS settings you can activate the SuperOffice app​.

    * If your phone opened the **Phone settings** screen in iOS settings instead, find **Call blocking & Identification** in the list and click on it to get to the screenshot above.

    ![Call Blocking & Identification -mobile-screenshot][img5]

    The allow call Identification function is now set to *Active*.

5. Do you see the **Background update** setting?

    * If no, your device and app are ready to use Caller ID for Mobile CRM (the setting is active by default).
    * If yes, like in the screenshot below, you must enable **Background App Refresh** for SuperOffice Mobile CRM. This settings is found in iOS settings under **General.**​

    ![Background update not active -mobile-screenshot][img6]![Background App Refresh -mobile-screenshot][img7]

### Android

4. You may end up in the **Display over other apps** screen in Android settings. Activate the SuperOffice app.

5. Allow the permission requests as they appear and enable **Display/Draw over other apps** for SuperOffice. Tap the previous page button twice to go back to Mobile CRM.

    ![Display/Draw over other apps -mobile-screenshot][img8]

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
[img1]: ../media/incoming-call.png
[img2]: ../media/caller-id.png
[img3]: ../media/allow-call-identification.png
[img4]: ../media/open-settings-menu.png
[img5]: ../media/ios-call-blocking.png
[img6]: ../media/background-update-inactive.png
[img7]: ../media/background-app-refresh.png
[img8]: ../media/android-call-id.png

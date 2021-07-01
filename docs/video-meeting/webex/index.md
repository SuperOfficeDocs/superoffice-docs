---
title: Video Meetings for SuperOffice - Webex
uid: video_meetings_webex
description: Getting started with Video Meetings for SuperOffice - Webex
so.date: 06.21.2021
keywords: video meeting, Webex
so.topic: howto
so.envir: cloud
so.client: online
---
# Video Meetings for SuperOffice: Webex

This article describes how to connect, configure, use and disconnect Webex.

## Pre-requisites

* Use CRM Online
* You need a SuperOffice admin account during setup
* Webex account

[!include[ALT](../includes/req-email-config.md)]

## How to connect to video provider

1. Open SuperOffice **Settings and maintenance** (admin) and go to the **Preferences** section.
2. Choose the **Video meetings** tab.
3. Click **Configure** to [start the configuration process][7].
4. Select Cisco Webex as the provider.
5. Authenticate and authorize Webex


> [!NOTE]
> We are currently in the process of approving this app, Before the app get final approval by Cisco, you will be able to authorize the app by adding the SuperOffice app from the Cisco app store

1. Add the SuperOffice app from the Cisco app store, by supplying our Integration ID when asked:

    ```text
    Y2lzY29zcGFyazovL3VzL0FQUExJQ0FUSU9OL0MwZThkNmFkYmUzYzZkOTE5Y2MyYzMzNjExYTMzMGQ2NzAzNWQwODYxMTliY2I4ZjhkMGQzZWNkODQ4NDQ2OGVh
    ```

    The SuperOffice app for Cisco Webex integration ID will be added to your Cisco Webex admin page at [https://admin.webex.com][2]:

    ![imageb11q.png -screenshot][img1]

2. You will be forwarded to the providers' authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

    ![imaget1zxp.png -screenshot][img2]

    ![imageqstfq.png -screenshot][img3]

    ![imageb9iy.png -screenshot][img4]

    ![image1jawz.png -screenshot][img5]

3. Webex Meetings has some additional configurations, only a password is required: set your random password and click **Save**.

    ![imageezby.png -screenshot][img6]

If it says "Connected to Webex. Logged in as xxx, connected to custxxxx", and password filled under **Set Configurations**, you may close this browser window - to go back to SuperOffice Settings and maintenance to confirm the setup.

<!-- Referenced links -->
[1]: ../connect-provider.md
[2]: https://admin.webex.com/

<!-- Referenced images -->
[img1]: media/imageb11q.png
[img2]: media/imaget1zxp.png
[img3]: media/imageqstfq.png
[img4]: media/imageb9iy.png
[img5]: media/image1jawz.png
[img6]: media/imageezby.png


6. Return to the SuperOffice **Video meetings** tab and verify that the configuration is active.

 You'll now see the status of configuration towards your video meeting provider. Verify configurations is active in SuperOffice

"Your SuperOffice installation is configured with the following meeting service Webex"

You may now start using Video Meetings in SuperOffice​!

## How to configure SuperOffice
To be able to send and receive e-mail invitations to video meetings, you must have [configured your e-mail setup][8] in SuperOffice CRM  or use SuperOffice Mail Link.

## How to use Video Meetings

* [Create a video meeting][2]
* [Join a video meeting][3]

## Troubleshooting

* [How to remove video-meetings configuration for users][1]

## How to disconnect video provider from SuperOffice

* [Disconnect video provider][4]

## How to uninstall the Webex video provider

Uninstalling the Webex video meeting service:

1. Log in to your Webex account and navigate to the Cisco Webex admin page at [admin.webex.com][1]
2. Open Apps, and go to the **Integrations** tab.
3. Remove the **SuperOffice CRM** app from the Cisco app store.

<!-- Referenced links -->
[1]: https://admin.webex.com

<!-- Referenced images -->
[img1]: media/imageb11q.png
<!-- Referenced links -->
[1]: ../remove-config-for-user.md
[2]: ../create-video-meeting.md
[3]: ../join-video-meeting.md
[4]: ../disconnect-provider.md
[5]: uninstall.md
[6]: auth.md
[7]: connect-provider.md
[8]: configure-video-meetings.md

<!-- Referenced images -->
---
title: Video Meetings for SuperOffice - Webex
uid: video_meetings_webex
description: Getting started with Video Meetings for SuperOffice - Webex
date: 06.21.2021
keywords: video meeting, Webex
content_type: howto
envir: cloud
client: online
---
# Video Meetings for SuperOffice: Webex

This article describes how to connect, configure, use and disconnect Webex.

## Pre-requisites

* Use CRM Online
* You need a SuperOffice admin account during setup
* Webex account

[!include[ALT](../includes/req-email-config.md)]

## How to connect to video provider

1. Open SuperOffice **Settings and maintenance** and go to the **Preferences** section.
2. Choose the **Video meetings** tab.
3. Click **Configure** to start the configuration process.
4. Select Cisco Webex as the provider.
5. Authenticate and authorize Webex:
    1. Add the SuperOffice app from the Cisco app store, by supplying our Integration ID when asked:

        ```text
        Y2lzY29zcGFyazovL3VzL0FQUExJQ0FUSU9OL0MwZThkNmFkYmUzYzZkOTE5Y2MyYzMzNjExYTMzMGQ2NzAzNWQwODYxMTliY2I4ZjhkMGQzZWNkODQ4NDQ2OGVh
        ```

        The SuperOffice app for Cisco Webex integration ID will be added to your Cisco Webex admin page at [https://admin.webex.com][4]:

        ![imageb11q.png -screenshot][img1]

    2. You will be forwarded to the provider's authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

        ![imaget1zxp.png -screenshot][img2]

        ![imageqstfq.png -screenshot][img3]

        ![imageb9iy.png -screenshot][img4]

        ![image1jawz.png -screenshot][img5]

    3. Webex Meetings has some additional configurations, only a password is required: set your random password and click **Save**.

        ![imageezby.png -screenshot][img6]

    If it says "Connected to Webex. Logged in as xxx, connected to custxxxx", and password filled under **Set Configurations**, you may close this browser window - to go back to SuperOffice Settings and maintenance to confirm the setup.
6. Return to the SuperOffice **Video meetings** tab and verify that the configuration is active.

## How to configure email invitations for video meetings

To be able to send and receive email invitations to video meetings, you must have [configured your email setup][8] in SuperOffice CRM  or use SuperOffice Mail Link.

## How to use Video Meetings

### Create a video meeting

[!include[How to create a video meeting](../includes/create-steps.md)]

[!include[Note: user must authenticate the fist time](../includes/note-firsttime-auth-user.md)]

### Join a video meeting

[!include[How to join a video meeting](../includes/join-options.md)]

## Troubleshooting

### Something went wrong

[!include[Fix something went wrong message](../includes/something-went-wrong.md)]

### 404

If you (the user) experience difficulties with creating and starting video meetings, remove the video-meetings configuration in SuperOffice.

[!include[How to remove video-meetings configuration for user step-by-step](../includes/re-auth-steps.md)]

## How to disconnect video provider from SuperOffice

[!include[How to disconnect video provider step-by-step](../includes/disconnect-provider-steps.md)]

## How to uninstall the Webex video provider

1. Log in to your Webex account and navigate to the Cisco Webex admin page at [admin.webex.com][4]
2. Open Apps, and go to the **Integrations** tab.
3. Remove the **SuperOffice CRM** app from the Cisco app store.

<!-- Referenced links -->
[4]: https://admin.webex.com
[8]: ../howto/configure-email-invitations.md

<!-- Referenced images -->
[img1]: media/imageb11q.png
[img2]: media/imaget1zxp.png
[img3]: media/imageqstfq.png
[img4]: media/imageb9iy.png
[img5]: media/image1jawz.png
[img6]: media/imageezby.png

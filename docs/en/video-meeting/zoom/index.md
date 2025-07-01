---
title: Video Meetings for SuperOffice - Zoom
uid: video_meetings_zoom
description: Getting started with Video Meetings for SuperOffice - Zoom
date: 06.21.2021
keywords: video meeting, Zoom
content_type: howto
deployment: online
platform: web
---
# Video Meetings for SuperOffice: Zoom

This article describes how to connect, configure, use and disconnect Zoom.

## Pre-requisites

* Use CRM Online
* You need a SuperOffice admin account during setup
* Zoom Pro account

[!include[ALT](../includes/req-email-config.md)]

## How to connect to video provider

1. Open SuperOffice **Settings and maintenance** and go to the **Preferences** section.
2. Choose the **Video meetings** tab.
3. Click **Configure** to start the configuration process.
4. Select Zoom as the provider.
5. Authenticate and authorize Zoom:
    1. Click **configure your video-provider** if needed:

        ![imaged2zr2.png -screenshot][img1]

    2. You will be forwarded to the provider's authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

        ![imagewvl4y.png -screenshot][img2]

        ![imagecxj9r.png -screenshot][img3]

    3. Zoom has one additional configuration required: set your random password and click **Save**.

        ![7y -screenshot][img4]

        If it says "Connected to Zoom. Logged in as xxx, connected to custxxxx", and password filled under **Set Configurations**, you may close this browser window - to go back to SuperOffice Settings and maintenance to confirm the setup.
6. Return to the SuperOffice **Video meetings** tab and verify that the configuration is active.

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

## How to disconnect video provider

First, **disconnect** the Zoom service provider in SuperOffice Settings and maintenance:

[!include[How to disconnect video provider step-by-step](../includes/disconnect-provider-steps.md)]

Then, **uninstall** the Zoom video meeting service:

1. Sign in to your Zoom account and navigate to the [Zoom Marketplace][4].
2. Search for SuperOffice CRM and click the app or navigate to your installed apps via **Manage > Installed Apps**.
3. Click **Uninstall** next to SuperOffice CRM.
4. Confirm the dialog and click **Uninstall**.

<!-- Referenced links -->
[4]: http://marketplace.zoom.us/

<!-- Referenced images -->
[img1]: media/imaged2zr2.png
[img2]: media/imagewvl4y.png
[img3]: media/imagecxj9r.png
[img4]: media/image7yqg.png

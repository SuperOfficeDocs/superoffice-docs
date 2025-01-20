---
uid: video_meetings_msteams
title: Video Meetings for SuperOffice - Microsoft Teams
description: Getting started with Video Meetings for SuperOffice - Microsoft Teams
keywords: video meeting, Microsoft Teams
date: 12.10.2024
topic: howto
envir: cloud
client: online
---
# Video Meetings for SuperOffice: Microsoft Teams

This article describes how to connect, configure, use and disconnect Microsoft Teams.

## Pre-requisites

* Use CRM Online
* You need a SuperOffice admin account during setup
* MS Teams activated / access for your Microsoft 365 subscription
* You need a Microsoft 365 admin account to grant access during setup
* Microsoft 365 for business account

> [!NOTE]
> If you try to authenticate without a Microsoft 365 Admin account, a message will tell you to log in with an admin account:

![imagewf14i.png -screenshot][img1]

[!include[ALT](../includes/req-email-config.md)]

## How to connect to video provider

1. Open SuperOffice **Settings and maintenance** and go to the **Preferences** section.
2. Choose the **Video meetings** tab.
3. Click **Configure** to start the configuration process.
4. Select Microsoft Teams as the provider.
5. Authenticate and authorize Microsoft Teams:
    1. You will be forwarded to the provider's authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

    2. Please accept the integration on behalf of your organization, by setting the checkbox:

        ![imagelm6ei.png -screenshot][img2]

    3. After authentication and confirmation are completed, you'll be redirected back to SuperOffice Video Meetings settings.

        ![image0z9pi.png -screenshot][img3]

        Teams Meetings provider does not have any additional configuration settings.

        If it says "Connected to Teams. Logged in as xxx, connected to custxxxx", and password filled under **Set Configurations**, you may close this browser window - to go back to SuperOffice Settings and maintenance to confirm the setup.
6. Return to the SuperOffice **Video meetings** tab and verify that the configuration is active.

## How to use Video Meetings

> [!NOTE]
> You need a Microsoft 365 **for business** subscription. Video meetings with Microsoft Teams does not support Personal and Family accounts.

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

First, disconnect the Microsoft Teams service provider in SuperOffice Settings and maintenance:

[!include[How to disconnect video provider step-by-step](../includes/disconnect-provider-steps.md)]

Then, **uninstall** the Microsoft Teams video meeting service:

1. Sign in to your Microsoft 365 administrator account and navigate to **Settings > Integrated apps**.

    ![imagehz5oq.png -screenshot][img4]

2. Click the link for **Microsoft Entra ID**

3. Open enterprise applications, and find the SuperOffice VideoMeetings app in the list, click to open it.

4. Go to **Properties**.

5. Click the **Delete** button for the *VideoMeeings* app.

    ![imageo2a0p.png -screenshot][img5]

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/imagewf14i.png
[img2]: media/imagelm6ei.png
[img3]: media/image0z9pi.png
[img4]: media/imagehz5oq.png
[img5]: media/imageo2a0p.png

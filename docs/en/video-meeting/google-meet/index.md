---
title: Video Meetings for SuperOffice - Google Meet
uid: video_meetings_google
description: Getting started with Video Meetings for SuperOffice - Google Meet
date: 08.12.2021
keywords: video meeting
content_type: howto
deployment: online
client: online
---
# Video Meetings for SuperOffice: Google Meet

This article describes how to connect, configure, use and disconnect Google Meet.

## Pre-requisites

* Use CRM Online
* You need a SuperOffice admin account during setup
* A Google account (Gmail or Google Workspace)

[!include[You must configure email invitations](../includes/req-email-config.md)]

## How to connect to video provider

1. Open SuperOffice **Settings and maintenance** and go to the **Preferences** section.
2. Choose the **Video meetings** tab.
3. Click **Configure** to start the configuration process.
4. Select Google Meet as the provider.
5. Authenticate and authorize Google Meet:
    1. You will be forwarded to the providers' authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

        ![imageaq45c.png -screenshot][img6]

        ![imagevja1.png -screenshot][img7]

        ![imagenw4gm.png -screenshot][img8]

    2. After authentication and confirmation is completed, you'll be redirected back to SuperOffice Video Meetings settings

        ![imagemzlj8.png -screenshot][img9]

        If it says "Logged in as xxx and connected to Google" under **Configure settings**, you may close this browser window - to go back to SuperOffice "Settings and maintenance" to confirm the setup.
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

### Remove access for Video Meeting App in Google

This procedure fixes problems with video meetings and Google accounts.

This might happen when you create a meeting in your CRM diary:

![image9u3i.png -screenshot][img10]

1. In your (the user's) Google account, go to [the list of authorized third-party applications][5].
2. Find SuperOffice Video Meetings in the list.
3. Click the button to Revoke access for this app.
4. Close the tab.
5. Go to [meetings.SuperOffice.com/Error/GoogleAuthenticationFailure][6] and click **Click here to restart the authorization process** again on that page.

You will be asked to authenticate and everything should work after that.

## How to disconnect video provider

First, **disconnect** the Google Meet service provider in SuperOffice Settings and maintenance:

[!include[How to disconnect video provider step-by-step](../includes/disconnect-provider-steps.md)]

Then, **uninstall** the Google Meet video meeting service:

1. Sign in to your [Google account][4] and navigate to Security.

    ![imageqb9db.png -screenshot][img1]

2. Click **Manage third-party access**.

    ![image767ll.png -screenshot][img2]

3. Find the SuperOffice VideoMeetings app in the list, click to open it.

    ![imagebwcao.png -screenshot][img3]

4. Click **Remove Access**.

    ![imageoicbe.png -screenshot][img4]

5. Confirm remove access.

    ![imagef35lq.png -screenshot][img5]

<!-- Referenced links -->
[4]: https://myaccount.google.com/security
[5]: https://myaccount.google.com/permissions
[6]: https://meetings.superoffice.com/Error/GoogleAuthenticationFailure

<!-- Referenced images -->
[img1]: media/imageqb9db.png
[img2]: media/image767ll.png
[img3]: media/imagebwcao.png
[img4]: media/imageoicbe.png
[img5]: media/imagef35lq.png
[img6]: media/imageaq45c.png
[img7]: media/imagevja1.png
[img8]: media/imagenw4gm.png
[img9]: media/imagemzlj8.png
[img10]: media/image9u3i.png

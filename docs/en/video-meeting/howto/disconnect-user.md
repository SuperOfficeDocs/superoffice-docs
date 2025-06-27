---
title: Disconnect user
uid: disconnect_user
description: How to disconnect a user from video meetings
author: {github-id}
date: 08.12.2021
keywords: video meetings
content_type: howto
envir: cloud
client: online
---

# How to remove video-meetings configuration for users

There are 2 ways to remove video-meetings configuration for users:

* The user does it self-service
* The admin user does it for the user

## Self-service: remove your own video-meetings configuration

1. In a browser, go to [https://meetings.superoffice.com/meet/DisconnectUser][1].

2. Click **Confirm**.

    ![imageusytk.png -screenshot][img5]

> [!NOTE]
> If you disconnected due to problems with authentication, you have to re-authenticate. Simply create a meeting in your CRM diary and click the video icon. You will then be asked to authenticate.

## Admin: remove the video-meetings configuration for specific users

How to use this functionality:

1. Open **Users** section from SuperOffice Settings and maintenance, and add column **ID** if not already there.

    ![imageh2o8t.png -screenshot][img3]

2. Find and note the ID (associate ID) for the users that you want to remove the Video meetings configuration for.

    ![imagem4qu6.png -screenshot][img4]

3. Open the Video Meetings configuration from SuperOffice Settings and maintenance and click **Configure**.

4. Open **Manage Users** from the **Configuration** page.

5. In the list of associates, you can remove their configuration.

The user is now disconnected. To use video meetings, the user has to re-authenticate. Tell them to create a meeting in their CRM diary and click the video icon. The user will then be asked to authenticate.

<!-- Referenced links -->
[1]: https://meetings.superoffice.com/meet/DisconnectUser

<!-- Referenced images -->
[img3]: media/imageh2o8t.png
[img4]: media/imagem4qu6.png
[img5]: media/imageusytk.png

---
title: Remove configuration for users
uid: remove_video_meeting_user_config
description: How to remove video-meetings configuration for users
author: {github-id}
so.date: 06.21.2021
keywords: video meetings
so.topic: howto
so.envir: cloud
so.client: online
---

# How to remove video-meetings configuration for users

In the video meetings configuration page, it is possible to remove the configuration for users. This can be done if the user experience difficulties with creating and starting video meetings:

![image761z.png -screenshot][img1]

There are 2 ways to remove video-meetings configuration for users:

* The user does it self-service
* The admin user does it for the user

## Self-service: remove your own video-meetings configuration

1. In a browser, go to [https://meetings.superoffice.com/meet/DisconnectUser][1].

2. Click **Confirm**.

    ![imageusytk.png -screenshot][img2]

> [!NOTE]
> If you disconnected due to problems with authentication, you have to re-authenticate. Simply create a meeting in your CRM diary and click the video icon. You will then be asked to authenticate.

## Admin: remove the video-meetings configuration for specific users

How to use this functionality:

1. Open **Users** from SuperOffice Settings and Maintenance, and add column **ID** if not already there.

    ![imageh2o8t.png -screenshot][img3]

2. Find and note the ID (associate ID) for the users that you want to remove the Video meetings configuration for.

    ![imagem4qu6.png -screenshot][img4]

3. Open the Video Meetings configuration from SuperOffice Settings and Maintenance and click **Configure**.

    ![image1k13q.png -screenshot][img5]

4. Open **Manage Users** from the **Configuration** page.

    ![image480wy.png -screenshot][img6]

5. In the list of associates, you can remove their configuration.

    ![imagezdd1e.png -screenshot][img7]

    ![image2qtev.png -screenshot][img8]

The user is now disconnected. To use video meetings, the user has to re-authenticate. Tell them to create a meeting in their CRM diary and click the video icon. The user will then be asked to authenticate.

<!-- Referenced links -->
[1]: https://meetings.superoffice.com/meet/DisconnectUser

<!-- Referenced images -->
[img1]: media/image761z.png
[img2]: media/imageusytk.png
[img3]: media/imageh2o8t.png
[img4]: media/imagem4qu6.png
[img5]: media/image1k13q.png
[img6]: media/image480wy.png
[img7]: media/imagezdd1e.png
[img8]: media/image2qtev.png

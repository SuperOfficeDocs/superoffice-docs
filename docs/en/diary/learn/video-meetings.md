---
uid: help-en-video-meetings
title: Work with video meetings
description: Learn how to create and join a video meeting in SuperOffice here.
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: diary, follow-up, video meeting
so.topic: howto
language: en
---

# Work with video meetings

The SuperOffice video meetings allow you to schedule and create video meetings directly from your diary. Let us take a look at how you can set up a video meeting.

> [!NOTE]
> Before you can use this feature, the [administrator must configure][1] your preferred video meeting service in SuperOffice Settings and Maintenance.

## Available video conferencing providers

* Zoom
* Microsoft Teams
* Google Meet
* Cisco WebEx
* Jitsi Meet (free to use, no subscription needed)

## Create a video meeting

You can easily set up a video meeting when creating a follow up. Watch this video to learn how to create a video meeting or follow the steps below (video length - 1:09):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/WuTqnDPx17Q]

### Steps

1. Create a new meeting and select the name of the company and the contact you plan to meet.

2. To create the video meeting URL, click the video meeting icon ![icon][img1]. The icon changes to ![icon][img2] and a video meeting link is added. SuperOffice CRM will create and add the video meeting URL for the video provider you use.

    ![Click the video meeting icon to create the video meeting URL -screenshot][img5]
    <!-- TODO: Retake for GA -->

    > [!NOTE]
    > The first time you select the video icon ![icon][img1], you must log in to authenticate your user in the video meeting service defined by your administrator.
    >
    > If you do not see the icon, this means that the video meeting feature is not configured yet. Please contact your SuperOffice administrator, who would be able to set up the feature and video provider connection.

3. Optionally, set up an alarm to be notified by a pop-up before the meeting starts.

4. [Invite participants][2].

    When you have added everyone that you want to attend the meeting, click **Save**.

    If you turned on email invitations for the participants of the follow-up, an email with a link to join the video meeting is sent when the meeting is saved. In the diary, follow-ups with video meetings are displayed with the icon ![icon][img3].

> [!TIP]
> Click ![icon][img4] to copy the video meeting link. You can then paste the link in the agenda/description of the meeting or send to others via direct messaging. Use the template variable {burl} to add the video meeting link to invitation templates.

## Join video meetings

You can join a video meeting in SuperOffice in several ways:

* Click **Join meeting** in the **Follow-up** dialog.
* Click **Join meeting** in the side panel.
* Click a browser notification (only available if the **Alarm** option is active).
* Right-click a video meeting in the diary and select **Join meeting**.

Watch this video or follow the steps below (video length - 1:11):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/uee_XO1kwTc]

### Steps

#### On the notification pop-up

If the host of the meeting has set up notifications for the meeting, SuperOffice CRM will warn you by showing a notification pop-up before your meeting is about to begin. You can click the **Join Meeting** button in the pop-up to automatically start your video meeting.

#### In the follow-up

You can also join the video meeting by opening the follow-up in your diary and clicking the **Join Meeting** button.

When you click the link, your video meeting will automatically start.

> [!TIP]
> When not using video meeting URL, but have another video URL, simply add it to the Location field and it is easy for any using Mobile CRM to click **Location** to connect to the video meeting on the go.

#### In the side panel preview

Click on the follow-up in your SuperOffice diary to view its details in the side panel. (Enable the preview by selecting it from the drop-down menu at the top of the side panel).

To join the video meeting via the preview screen, just click the **Join Meeting** button. After you click it, your video meeting will automatically start.

<!-- Referenced links -->
[1]: ../../../en/video-meeting/howto/connect-provider.md
[2]: invitation/add-participant.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/videocall-off.png
[img2]: ../../../../common/icons/videocall.png
[img3]: ../../../../common/icons/diary-videocall.png
[img4]: ../../../../common/icons/diary-copy.png
[img5]: ../../../media/loc/en/diary/appointment-videomeeting-icon.png

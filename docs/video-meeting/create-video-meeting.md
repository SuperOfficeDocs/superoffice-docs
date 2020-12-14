---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: create_video_meeting # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to create a video meeting # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# Create a video meeting

You can easily set up a video meeting when [creating a follow up][1].

1. Go to the Follow-up dialog (example: go to the diary and create a new appointment).

2. Click ![inactive][img1] next to the meeting type (for instance Business meeting). The icon changes to ![active][img2] and a video meeting link is added.

Note: The first time you select the video icon (![inactive][img1]), a new window will open. Here you need to sign in to authenticate your user in the video meeting service defined by your administrator.

3. Complete the information in the dialog as described in the [Dialog for follow-ups][2].

If you have turned on email invitations for the participants of the follow-up, an email with a link to join the video meeting will be sent when the appointment is saved. In the diary, follow-ups with video meetings are displayed with the icon ![in diary][img3].

> [!TIP]
> Click ![copy link][img4] to copy the video meeting link. You can then paste the link in the description of the appointment or send it to others via direct messaging.

<!-- Referenced links -->
[1]: https://community.superoffice.com/documentation/help/en/crm/9.2/userhelp/StandardCRM/chap02/Add_activities.htm
[4]: https://community.superoffice.com/documentation/help/en/crm/9.2/userhelp/StandardCRM/chap02/Dialog_for_followups.htm

<!-- Referenced images -->
[img1]: ../media/icons/videomeeting_inactive.png
[img2]: ../media/icons/videomeeting_active.png
[img3]: ../media/icons/videomeeting_diaryicon.png
[img4]: ../media/icons/videomeeting_copylink.png
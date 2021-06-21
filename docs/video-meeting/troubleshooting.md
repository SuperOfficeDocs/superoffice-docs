---
title: Troubleshooting Video Meetings for SuperOffice
uid: video_meetings_troubleshooting
description: Troubleshooting Video Meetings for SuperOffice
so.date: 06.21.2021
keywords: video meeting, troubleshooting, 404, context identifier
so.topic: howto
so.envir: cloud
so.client: online
---

# Troubleshooting

## Something went wrong reserving your video meeting. Please try again later

**Problem:** If SuperOffice Online is not able to provide video meetings with a valid context-identifier (used for getting correct API-credentials) when a user logs in to CRM Online, the user will get an error in the client when creating the video meeting:

![imagen1s5.png][img1]

**Solution:** The user should try to log out of CRM Online and then log in to CRM Online again to get a valid context-identifier.

## 404 OOPS. Something went wrong!

**Problem:** The user is disconnected due to problems with authentication towards the video provider.

**Solution:** To resolve this, the [user has to remove the video-meetings configuration][1] in SuperOffice and [remove the video meeting app in Google][2] to re-authenticate.

<!-- Referenced links -->
[1]: remove-config-for-user.md
[2]: google-meet/remove-access-for-app.md

<!-- Referenced images -->
[img1]: media/imagen1s5.png

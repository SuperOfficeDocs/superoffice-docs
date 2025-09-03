---
uid: video-meetings-troubleshooting
title: Troubleshooting Video Meetings for SuperOffice
description: Troubleshooting Video Meetings for SuperOffice
keywords: video meeting, troubleshooting, 404, context identifier
date: 06.21.2021
content_type: howto
category: integration
topic: video meetings
deployment: online
platform: web
language: en
redirect_from: /en/diary/video-meetings/troubleshooting
index: true
---

# Troubleshooting

## Something went wrong reserving your video meeting. Please try again later

**Problem:** If SuperOffice Online is not able to provide video meetings with a valid Customer ID when a user logs in to SuperOffice Online, the user will get an error in the client when creating the video meeting:

![imagen1s5.png -screenshot][img1]

**Solution:** The user should try to log out of SuperOffice Online and then log in again to get a valid Customer ID.

## 404 OOPS. Something went wrong!

**Problem:** Authentication towards the video provider.

![image761z.png -screenshot][img2]

**Solution:** To resolve this, the [user has to remove the video-meetings configuration in SuperOffice][1].

<!-- Referenced links -->
[1]: howto/disconnect-user.md

<!-- Referenced images -->
[img1]: media/imagen1s5.png
[img2]: media/image761z.png

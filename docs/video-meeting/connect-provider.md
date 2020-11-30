---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: connect_video_provider # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to connect video provider # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# How to connect to a video provider

## Before you begin

* The administrator must first [configure](configure-video-meetings.md) the Zoom video meeting service in SuperOffice Settings and Maintenance.

## How to

1. Open SuperOffice **Settings and maintenance** (admin) and go to **Preferences** section.

![imageq058q.png][1]

2. Choose the **Video meetings** tab.

![imagekb02n.png][2]

3. Click **Configure** to start the configuration process. A new web browser window will open.

4. Select a provider. Choose the provider your company uses for video meetings.

![provider][3]

5. You will be forwarded to the providers' authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

6. Verify configurations is active in SuperOffice. For example, "Your SuperOffice installation is configured with the following meeting service **Zoom**"

![imagezo47s.png][4]

You may now start using Video Meetings in SuperOffice​!

## Authenticate and authorize Zoom - details

We are currently in the process of approving this app, and it is currently only in Zoom beta.

When we get verified, you will be able to authorize the app:

![imageajbsc.png][5]

When app is approved:  
You will be forwarded to the provider's authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

![imagewvl4y.png][6]

![imagecxj9r.png][7]

Zoom has one additional configuration required: set your own random password and click **Save**.

![][8]

If it says "Connected to Zoom. Logged in as xxx and connected to custxxxx", and password is filled under 'Set Configurations', you may close this browser window - to go back to SuperOffice "Settings and maintenance" to confirm the setup.

<!-- Referenced links -->
[1]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imageq058q.png
[2]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imagekb02n.png
[3]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imageaos3n.png
[4]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imagezo47s.png
[5]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imageajbsc.png
[6]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imagewvl4y.png
[7]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/imagecxj9r.png
[8]: https://community.superoffice.com/contentassets/ff7f0882643c42ba9181482ce59b2269/image7yqg.png
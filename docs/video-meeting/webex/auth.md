---
title: auth_webex
description: How to authenticate and authorize Webex Meetings
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud              # cloud or onsite
so.client: online            # online, web, win, pocket, or mobile
---

# Authenticate and authorize Webex Meetings

This is step 5 in [connecting your provider][1]. It is provider-specific.

> [!NOTE]
> We are currently in the process of approving this app, Before the app get final approval by Cisco, you will be able to authorize the app by adding the SuperOffice app from the Cisco app store

1. Add the SuperOffice app from the Cisco app store, by supplying our Integration ID when asked:

    ```text
    Y2lzY29zcGFyazovL3VzL0FQUExJQ0FUSU9OL0MwZThkNmFkYmUzYzZkOTE5Y2MyYzMzNjExYTMzMGQ2NzAzNWQwODYxMTliY2I4ZjhkMGQzZWNkODQ4NDQ2OGVh
    ```

    The SuperOffice app for Cisco Webex integration ID will be added to your Cisco Webex admin page at [https://admin.webex.com][2]:

    ![imageb11q.png][img1]

2. You will be forwarded to the providers' authentication portal to authenticate and validate your user and to confirm you allow to connect it to SuperOffice.

    ![imaget1zxp.png][img2]

    ![imageqstfq.png][img3]

    ![imageb9iy.png][img4]

    ![image1jawz.png][img5]

3. Webex Meetings has some additional configurations, only password is required: set your own random password and click **Save**.

    ![imageezby.png][img6]

If it says "Connected to Webex. Logged in as xxx and connected to custxxxx", and password is filled under **Set Configurations**, you may close this browser window - to go back to SuperOffice Settings and maintenance to confirm the setup.

<!-- Referenced links -->
[1]: ../connect-provider.md
[2]: https://admin.webex.com/

<!-- Referenced images -->
[img1]: media/imageb11q.png
[img2]: media/imaget1zxp.png
[img3]: media/imageqstfq.png
[img4]: media/imageb9iy.png
[img5]: media/image1jawz.png
[img6]: media/imageezby.png

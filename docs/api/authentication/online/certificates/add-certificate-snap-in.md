---
title: How to install the Certificate snap-in
uid: add_certificate_snap_in
description: How to install the Certificate snap-in on Windows 
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# How to install the Certificate snap-in on Windows

The **Certificate** snap-in is a useful tool when configuring certificates.

1. Open the Windows **Run** dialog and enter `mmc.exe`.

    ![x][img1]

2. Click **File** and select **Add/Remove Snap-in**.

3. Select **Certificates** and click **Add**.

    ![x][img2]

4. Select **Computer account** and click **Next**.

    ![x][img3]

5. Select **Local computer** and click **Finish**.

    ![x][img4]

6. You should now see the following dialog with **Certificates (Local Computer)** on the right pane.

    Click **OK** to finish the task.

    ![x][img5]

You can now proceed to [configure certificates][1].

<!-- Referenced links -->
[1]: configure.md

<!-- Referenced images -->
[img1]: media/rundialog.png
[img2]: media/addremovesnapin.png
[img3]: media/mmc-certs-snapin.png
[img4]: media/selectlocalcomputer.png
[img5]: media/addremoveadded.png

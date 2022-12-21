---
title: Restart synchronization
uid: restart_scim_sync
description: Restart SCIM synchronization
author: {github-id}
keywords:
so.topic: howto
so.envir: cloud
so.client: online
---

# Restart synchronization

If you suspect Azure AD and SuperOffice are out of sync, you might need to restart the synchronization.

> [!WARNING]
> If you need to start synchronization from scratch, it should be **done on both sides!**
>
> Restarting only 1 side will lead to inconsistent data. Azure AD has no knowledge of what you do to the synchronized user list.

## In the SuperOffice Identity Manager

1. Go to the **Configuration** screen.

2. Click the trashcan icon in the **SCIM Users** pane to clear all synchronized items from the database.

    ![Reset scim sync in SuperOffice tool -screenshot][img1]

3. After the Azure AD cycle has completed and you see that the **SCIM Users** pane has been repopulated, click **Save** to restore your SCIM rules.

## In Azure AD provisioning configuration

1. Select **Clear current state and start resynchronization** and then click **Save**.

    ![Reset SCIM sync in AAD -screenshot][img2]

    The **Current Status** changes to *Initial cycle not run*. ![scim user sync started -screenshot][img3]

2. Refresh the **Current Status**, and when it changes to *Initial cycle completed* verify that the SuperOffice Identity Manager has received the expected users and groups.

    ![scim aad initial cycle not run -screenshot][img4]

<!-- Referenced images -->
[img1]: media/imagew9x2g.png
[img2]: media/scim-clear-synced-aad.png
[img3]: media/b01f4cd8-a2c8-4f62-b7ad-f51f26c2ca3f.png
[img4]: media/ca58bf0e-5854-4728-9928-297aab9c9f7a.png

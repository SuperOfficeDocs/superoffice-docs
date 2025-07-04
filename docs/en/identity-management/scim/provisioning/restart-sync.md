---
title: Restart synchronization
uid: restart_scim_sync
description: Restart SCIM synchronization
author: SuperOffice Product and Engineering
date: 09.04.2024
keywords: IdP, SCIM, Microsoft Entra, ME-ID, AAD
content_type: howto
deployment: online
platform: web
index: true
---

# Restart synchronization

If you suspect Microsoft Entra ID and SuperOffice are out of sync, you might need to restart the synchronization.

> [!WARNING]
> If you need to start synchronization from scratch, it should be **done on both sides!**
>
> Restarting only 1 side will lead to inconsistent data. Entra ID has no knowledge of what you do to the synchronized user list.

## In the SuperOffice Identity Manager

1. Go to the **Configuration** screen.

2. Click the trashcan icon in the **SCIM Users** pane to clear all synchronized items from the database.

    ![Reset scim sync in SuperOffice tool -screenshot][img1]

3. After the Microsoft Entra ID cycle has completed and you see that the **SCIM Users** pane has been repopulated, click **Save** to restore your SCIM rules.

## In Microsoft Entra provisioning configuration

1. At the top, select **Restart provisioning**. The **Current Status** changes to *Initial cycle not run*.

    ![Reset SCIM sync in Microsoft Entra ID -screenshot][img2]

2. Refresh the **Current Status**, and when it changes to *Initial cycle completed* verify that the SuperOffice Identity Manager has received the expected users and groups.

    ![SCIM Microsoft Entra ID initial cycle not run -screenshot][img4]

<!-- Referenced images -->
[img1]: media/imagew9x2g.png
[img2]: media/scim-restart-provisioning.png
[img4]: media/scim-initial-cycle-completed.png

---
uid: help-en-request-close
title: Close a request
description: How to close one or multiple request in SuperOffice.
keywords: close request, set status closed, closed, bulk update, request
author: Bergfrid Dias, kirstiaa
date: 01.15.2025
version: 10.5.1
topic: howto
license: serviceessentials
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# Close requests

To close a request means changing its [status][5] to *Closed*.

## Close one request

After [responding to the request][3], select **Closed** in the **Status** field in the sidebar properties.

## Close multiple requests with Bulk update

You can quickly close multiple requests by setting the **Status** field to *Closed* in the **Bulk update** dialog.

1. Open the list of requests you want to update. You can use:
    * A **saved selection** in the Selection screen.
    * Search results from the **Find requests** screen.
    * The **Requests section tab** (on a company or contact).

1. Access the **Bulk update** dialog:
    * **Selections:** Click <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i> and choose **Bulk update**.
    * **Find requests:** Select the requests, click the <i class="ph ph-list" aria-hidden="true"></i> **Task** button in the lower-left corner, and choose **Bulk update**.
    * **Section tab:** Select the requests, right-click, and choose **Bulk update**.

1. In the **Bulk update** dialog:
    * In the **Field** column, type or select **Status**.
    * In the **Action** column, choose **Select one**.
    * In the **New value** column, select **Closed**.
    * Ensure the checkbox next to **Status** is the only one selected.

    ![Bulk update dialog -screenshot][img1]

    Optionally, you can update other fields, but proceed with caution.

1. Click **Update**.

1. Review the summary in the **Confirm** dialog. It lists the field to update and the number of requests affected.

    ![Confirm dialog -screenshot][img2]

1. Click **Yes** to apply the changes. The selected requests are now closed.

    > [!CAUTION]
    > Once an update is applied, it cannot be undone. However, you can stop the update while it is in progress. Any records that have not yet been updated will remain unchanged.

## Related content

* [Update multiple records (bulk update)][1]
* [Create a selection][6]
* [Requests section tab][2]
* [Find requests][4]

<!-- Referenced links -->
[1]: ../../learn/basics/bulk-update.md
[2]: ../../learn/section-tabs/requests-tab.md
[3]: reply.md
[4]: find.md
[5]: ../admin/status/index.md
[6]: ../../search-options/selection/learn/create/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/request/bulk-update-requests.png
[img2]: ../../../media/loc/en/request/bulk-update-confirm.png

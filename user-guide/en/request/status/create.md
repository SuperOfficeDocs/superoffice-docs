---
uid: help-en-request-status-create
title: Create request status
description: Create request status
author: SuperOffice RnD
so.date: 06.29.2022
keywords: request, status
so.topic: howto
language: en
---

# Create request status

## Define a status in Settings and maintenance

1. Click the **Requests** button in the navigator.

1. Select the **Request status** tab.

1. Click the **Add** button.

1. In the **Name** field, enter a descriptive name for the request status.

1. In the **Internal status** list box, select which of the internal statuses you want to link your custom request status to.

1. Check **Default** if you want this request status to be the default custom status for the internal status it represents.

1. Check **Queue status** if requests with this status are to be placed in the queue.

1. Check **Create new request on customer reply** to prevent old requests being reopened because a customer replies to an old message. This could be appropriate for example for statuses such as **Closed** and **Deleted**.

1. In the list **Track time as**, choose how to report time usage:

    * In queue and awaiting processing
    * At internal decision stage
    * At external decision stage

1. Click **Save**. The request status is created.

1. If required, adjust the position of the status using the arrow buttons below the list of statuses. The rank here specifies the order in the **Status** list box when creating a new request. Place the most frequently used statuses at the top.

## Define a status in Service

1. Select ![icon][img1] **System settings** > **Request status**. The **Request status** screen appears.

2. Click the **New status** button. This takes you to the **Edit request status** screen.

3. In the **Internal status** list box, select which of the internal statuses you want to link your custom request status to.

4. Check **Default** if you want this request status to be the default custom status for the internal status it represents.

5. In the **Name** field, enter a descriptive name for the request status.

6. Check **Queue status** if requests with this status are to be placed in the queue.

7. Check **Create new request on customer reply** to prevent old requests being reopened because a customer replies to an old message. This could be appropriate for example for statuses such as **Closed** and **Deleted**.

8. In the list **Track time as**, choose how to report time usage:

    * in queue and awaiting processing
    * at internal decision stage
    * at external decision stage

9. Click **OK**. The request status is created.

10. If required, adjust the position of the status using the drag handel button ( ![icon][img2] ) in the **Request status** screen. The rank here specifies the order in the **Status** list box when creating a new request.

## Related content

* [How to set up Get next request in queue][1]

<!-- Referenced links -->
[1]: ../next-in-queue.md

<!-- Referenced images -->
[img1]: ../../../media/icons/globalmenu-settings-small.png
[img2]: ../../../../common/icons/drag-handle.png

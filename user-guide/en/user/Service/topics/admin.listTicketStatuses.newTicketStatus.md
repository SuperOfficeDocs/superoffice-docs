---
uid: help-en-admin-listticketstatuses-newticketstatus
title: admin listTicketStatuses newTicketStatus
description: admin listTicketStatuses newTicketStatus
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Create request status

To create a new request status:

1. Select ![icon][img1] **System settings** &gt; **Request status**. The **Request status** screen appears.
2. Click the **New status** button. This takes you to the **Edit request status** screen.
3. In the **Internal status** list box, select which of the internal statuses you want to link your custom request status to.
4. Check **Default** if you want this request status to be the default custom status for the internal status it represents.
5. In the **Name** field, enter a descriptive name for the request status.
6. Check **Queue status** if requests with this status are to be placed in the queue. See [How to set up Get next request in queue](get-next-request-in-the-queue.md).
7. Check **Create new request on customer reply** to prevent old requests being reopened because a customer replies to an old message. This could be appropriate for example for statuses such as **Closed** and **Deleted**.
8. In the list **Track time as** you can select what requests with this status should be tracked as. This is used to report time usage in various phases of request management. The system calculates time used both in relation to defined "opening hours" and the whole 24-hour period. The different types are:
    * in queue and awaiting processing
    * at internal decision stage
    * at external decision stage
9. Click **OK**. The request status is created.
10. If required, adjust the position of the status using the arrow buttons ( ![icon](../media/btn-RankUp.png) and ![icon](../media/btn-RankDown.png) ) in the **Rank** column in the **Request status** screen. The rank here specifies the order in the **Status** list box when creating a new request.

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: ../../../../media/icons/globalmenu-settings-small.png

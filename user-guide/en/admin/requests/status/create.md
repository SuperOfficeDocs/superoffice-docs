---
uid: help-en-admin-listticketstatuses-newticketstatus
title: admin listTicketStatuses newTicketStatus
description: admin listTicketStatuses newTicketStatus
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create request status

To create a new request status:

[!include[Go to request status](includes/goto-reguest-status.md)]

1. Click the **Add** button. A new request status opens to the right.

1. In the **Name** field, enter a descriptive name for the request status.

1. In the **Internal status** list box, select which of the internal statuses you want to link your custom request status to.

1. Check **Default** if you want this request status to be the default custom status for the internal status it represents.

1. Check **Queue status** if requests with this status are to be placed in the queue. See [How to set up Get next request in queue][1].

1. Check **Create new request on customer reply** to prevent old requests being reopened because a customer replies to an old message. This could be appropriate for example for statuses such as **Closed** and **Deleted**.

1. In the list **Track time as** you can select what requests with this status should be tracked as. This is used to report time usage in various phases of request management. The system calculates time used both in relation to defined "opening hours" and the whole 24-hour period. The different types are:

    * in queue and awaiting processing
    * at internal decision stage
    * at external decision stage

1. Click **Save**. The request status is created.

1. If required, adjust the position of the status using the arrow buttons below the list of statuses. The rank here specifies the order in the **Status** list box when creating a new request. Place the most frequently used statuses at the top.

<!-- Referenced links -->
[1]: ../../../request/get-next-request-in-queue.md

<!-- Referenced images -->

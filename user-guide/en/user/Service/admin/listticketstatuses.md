---
uid: help-en-admin-listticketstatuses
title: admin listTicketStatuses
description: admin listTicketStatuses
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Service
so.topic: help
language: en
---

# Request status

All requests that are registered in SuperOffice Service, have a status, such as **Open**, **Closed** or **Postponed**. In the **Request status** screen, you can see the request statuses already defined in the system, and create additional request statuses. A request status needs to be linked to one of the system's internal statuses, such as **Open** or **Closed**. Each internal status must be linked to at least one request status.

For example, you can create a new status called "Waiting for reply" as a more detailed variant of either **Closed** or **Open**, depending on how you want the system to process and report this status internally. You can also link custom logic to such statuses in order to streamline your business processes.

[!include[Restricted access](../../../includes/note-insufficient-rights.md)]

The **Request status** screen displays all existing statuses in the system. The list contains the following columns:

* **Name**: The name of the request status. By default each internal status has a request status with the same name.
* **Internal status**: The system's internal statuses. Each internal status must be linked to at least one request status. The system statuses **Linked** and **Deleted** are only used for merged requests and deleted requests respectively, and are not visible to the users.
* **Track time as**: This is used to report time usage in various phases of request management. See [Create request status](listTicketStatuses.newTicketStatus.md).
* **Queue status**: Indicates if requests with this status should be placed in the queue. This is relevant if you use the **Get next request in queue** function. See [How to set up Get next request in queue](../request/get-next-request-in-the-queue.md).
* **Default**: Indicates if this is a default status for the internal status.
* **Rank**: The **Rank** column specifies the order in the **Status** list box in the **Properties** tab in the **Request** screen. You use the arrow buttons ( ![icon](../media/btn-RankUp.png) and ![icon](../media/btn-RankDown.png) ) to change the order.

## What would you like to do now?

[Create request statuses](listTicketStatuses.newTicketStatus.md)

[Delete request statuses](listTicketStatuses.deleteTicketStatus.md)

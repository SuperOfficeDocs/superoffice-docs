---
uid: help-en-request-status
title: Request status
description: Request status
author: SuperOffice RnD
so.date: 06.29.2022
keywords: request, status
so.topic: concept
language: en
---

# Request status

All requests that are registered in SuperOffice Service, have a status, such as **Open**, **Closed** or **Postponed**. In the **Request status** tab, you can see the request statuses already defined in the system, and create additional request statuses. A request status must be linked to one of the system's internal statuses, such as **Open** or **Closed**. Each internal status must be linked to at least one request status.

For example, you can create a new status called "Waiting for reply" as a more detailed variant of either **Closed** or **Open**, depending on how you want the system to process and report this status internally. You can also link custom logic to such statuses to streamline your business processes.

## Settings

| Setting | Description |
|---|---|
| Name | The name of the request status. By default each internal status has a request status with the same name. |
| Internal status | The system's internal statuses. Each internal status must be linked to at least one request status. The system statuses **Linked** and **Deleted** are only used for merged requests and deleted requests respectively, and are not visible to the users. |
| Track time as | Used to report time usage in various phases of request management. The system calculates time used both in relation to defined "opening hours" and the whole 24-hour period. Choose from: in queue and awaiting processing; at internal decision stage; at external decision stage |
| Queue status | Indicates if requests with this status should be placed in the queue. Relevant if you use the **Get next request in queue** function. |
| Default | Indicates if this is a default status for the internal status. |
| Rank | The **Rank** column specifies the order in the **Status** list box in the **Properties** tab in the **Request** screen. You use the drag handle button ( ![icon][img1] ) to change the order. |

## What do you want to do now?

* [Create request status][1]
* [Delete request status][2]
* [Set up Get next request in queue][3].

<!-- Referenced links -->
[1]: create.md
[2]: delete.md
[3]: ../next-in-queue.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/drag-handle.png

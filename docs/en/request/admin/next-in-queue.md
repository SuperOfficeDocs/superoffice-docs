---
uid: help-en-request-next-in-queue
title: Get next request in the queue
description: Get next request in the queue
keywords: get next request in queue, request
author: Hanne Gunnarsson
date: 01.15.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice Service
language: en
---

# How to set up Get next request in queue

In SuperOffice, requests are normally assigned to users according to an assignment method. Another method of assigning requests to request handlers, is to place new requests in **Requests**> **Unassigned requests**. The request handlers must then accept the requests manually.

However it is also possible to create an intelligent queue system for handling new requests. Request handlers can then click **Get next request in queue** under **Requests** to accept the next request in the queue. Requests in the queue are filtered by [category][2], so that users are only assigned requests that belong to categories they are members of.

## How are requests in the queue prioritised?

The sequence of the requests in the queue is determined by the deadline for each individual request. The requests with the closest deadlines come first in the queue. The deadline is calculated based on priorities that were defined for contact, company, mailbox, email filter and standard priority.

This ensures that requests are prioritised in a logical and fair sequence.

> [!NOTE]
> It is also possible to use a combination of queue system and assignment method. Requests can for example be placed in the queue or assigned to users based on which category the requests belong to.

## Which requests can be fetched from the queue?

The following factors determine which requests a request handler can get from the queue:

* The requests must have a request status with **Queue status** activated.
* The requests must have a category of which the request handler is a member.
* The request owner must be **Unassigned**.

## Create new request status "In queue"

First, we will create a new request status: **In queue**. New requests should automatically be assigned this request status.

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Select **Requests** > **Request status**.

1. Click the **Add** button.

1. In the **Name** field, enter a descriptive name for the request status. For example "In queue".

1. In the **Internal status** list box, select **Open**.

1. Check **Default**, so that all new requests (active requests) are assigned this status by default.

1. Check **Queue status**. The users can now get requests with this status from the queue.

    > [!NOTE]
    > This does not mean that these requests MUST be fetched from the queue. We will use categories to decide which requests to place in the queue and which requests to distribute according to the assignment method for the category.

1. You do not have to check **Create new request on customer reply**.

1. In the **Track time as** list, select **In queue**.

1. Click **Save**.

The new request status is shown in the list, and there is a check mark in the columns **Default** and **Queue status**.

## Use categories to place requests in the queue

Now you must ensure that you are a member of the category or categories you are going to manage. We must also specify that requests belonging to these categories should not be assigned according to the assignment method.

> [!NOTE]
> Membership in categories can also be defined at group level. In Settings and maintenance (**Users** > **User groups**) you can state categories for the various user groups.

**Steps:**

1. [!include[Go to](../../learn/includes/goto-sm.md)]

1. Select **Requests** > **Categories**.

1. Click the required category name. This takes you to the **Category properties** screen.

1. Select the **Members** tab.

1. Select yourself in the **User** list and click **+** to add yourself as a member of the category.

1. Add any other users as members of this category.

1. Select the **Assignment method** tab and select **Do not assign**. Now requests in this category will not be assigned to users in accordance with the assignment method.

1. Click **Save**.

If needed, repeat this procedure for other categories that are to be available to be fetched from the queue. Categories that follow an assignment method will be assigned a user and will not therefore join the queue.

## Define new status for requests that are fetched from the queue

When you have fetched a request from the queue, the status must be changed from **In queue** to **Open** (or another active status that indicates that the request is being processed). This is normally handled automatically.

## Verify that the queue works

Create a new request, set **Owner** to **Unassigned**, select the category you are a member of and set **Status** to **In queue**. Then try clicking **Requests** > **Get next request in queue**.

<!-- Referenced links -->
[2]: category/index.md

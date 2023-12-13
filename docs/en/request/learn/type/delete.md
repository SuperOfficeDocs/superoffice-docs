---
uid: help-en-request-type-delete
title: Delete request type
description: Delete request type
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: request, type
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Delete request type (pilot only)

> [!NOTE]
> You cannot delete the current default type (the one with a check mark in the **Use as default** box).

## Pre-requisites

* If the type you wish to delete is used as default, set another request type as default. (Until you do, the **Delete** button is deactivated.)

* Update any [email filters][1] and [Service mailboxes][2] that use this request type first. You cannot delete a type that is in use.

  * **Settings and maintenance** > **Requests** > **E-mail** > **Set properties** tab
  * **Settings and maintenance** > **Requests** > **E-mail** > **E-mail boxes** tab

## Steps

1. Click the **Requests** button in the navigator and select the **Request types** tab.

1. Click the required request type.

1. Click the **Delete** button at the bottom of the screen.

1. If there are any requests of this type, choose a new type from the **Transfer request type to** list.

1. Click **OK** to confirm. The request type is deleted all the requests are moved to the specified alternative type.

<!-- Referenced links -->
[1]: ../../../email/service/learn/email-filters/create-email-filter.md
[2]: ../../../email/service/learn/create-mailbox.md

<!-- Referenced images -->

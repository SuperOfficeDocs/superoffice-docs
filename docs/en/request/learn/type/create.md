---
uid: help-en-request-type-create
title: Create request type
description: Create request type
author: Bergfrid Dias
so.date: 12.12.2023
so.version: 10.2.11
keywords: request, type
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Create request type (pilot only)

## Steps

1. In Settings and maintenance, select **Requests** in the navigator.

1. Select the **Request types** tab.

1. Click the **Add** button.

    ![Settings and maintenance, Request types -screenshot][img1]

1. Enter a short descriptive **Name** for the new request type. You can add more details in the **Description** field.

1. Optionally, change the icon to visually distinguish requests of this type from other requests.

1. Check **Use as default** if you want this request type to be the default for all new requests.

1. Optionally, filter the list of available statuses and/or priorities for requests of this type.

    * To allow any [status][4] or [priority][3], leave the availability field empty.
    * If you select one or more statuses, you must also choose a default status.
    * If you select one or more priorities, you must also choose a default priority.

1. Optionally, select a default status and/or priority to use when an agent creates a request of this type. (Mandatory if you set availability.) This setting takes precedence over other preferences.

1. Optionally, select a [reply template][5] to use when an agent replies to a request of this type.

    ![Settings and maintenance, Request type settings -screenshot][img2]

1. Click **Save**. The request type is created.

<!-- Referenced links -->
[3]: ../priority/index.md
[4]: ../status/index.md
[5]: ../../reply-templates/learn/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/request/add-request-type.png
[img2]: ../../../../media/loc/en/request/request-type-settings.png

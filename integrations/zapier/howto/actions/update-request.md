---
uid: zapier-update-request-action
title: Set SuperOffice CRM request update action
description: How to use SuperOffice update request action with Zapier
keywords: Update request, new Zap, Zapier update action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update a SuperOffice CRM Request action

## Steps

1. [!include[ALT](includes/initial-steps-new-action.md)]

1. Click on the **Action** step to set up app, event, and account:

    * In the **Action event** section, select **Update Request**

    ![Set up an action -screenshot][img4]

1. Click **Continue**.

1. Fill out the mandatory fields **Request** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Click **Test step** to check that the action works.

    If the above steps were configured correctly, the response should consist of **Request id**, **Title**, **Author**, **Contact id**, **Contact name**, **Company id**, **Company name**, **Owner id**, **Owner**, **Category id**, **Category**, **Priority id**, **Priority**, **Status**, **Access level for request**, **Origin**, **Created by id**, **Created by**, **Replied at**, **Closed at**, **Deadline**, **Self URL**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Find Request Action][1]
* [Create Request Action][2]
* [New Request Trigger][3]
* [Create a SuperOffice CRM action - detailed steps][4]

<!-- Referenced links -->
[1]: search-request.md
[2]: create-request.md
[3]: ../triggers/new.md
[4]: index.md

<!-- Referenced images -->
[img4]: media/update-request-action.png
[img5]: media/update-request-window.png
[img6]: media/update-request-output.png

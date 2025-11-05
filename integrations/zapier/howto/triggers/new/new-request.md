---
uid: zapier-new-request-trigger
title: Set SuperOffice CRM new Request trigger
description: How to use SuperOffice new appointment trigger with Zapier
keywords: New request, new Zap, Zapier new trigger
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM new Request trigger

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. Click **Trigger** step to open a window for selecting the application to use.

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[search for so](../includes/search-for-so.md)]

1. A side menu will open, in the **Trigger event** section, select **New Request**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your trigger -screenshot][img4]

1. [!include[test](../includes/test.md)]

    ![Test your trigger -screenshot][img5]

1. [!include[action](../includes/action.md)]

1. If the above steps were configured correctly, the action you chosen should be executed properly when the **Trigger event New Request** is executed in SuperOffice CRM.

## Related content

* [Create Request Action][1]
* [Update Request Action][2]
* [Create a Zap with SuperOffice CRM][3]

<!-- Referenced links -->
[1]: ../../actions/create/create-request.md
[2]: ../../actions/update/update-request.md
[3]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img4]: ../../media/triggers/new-request/new-request-action.png
[img5]: ../../media/triggers/new-request/new-request-output.png
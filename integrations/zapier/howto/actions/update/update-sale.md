---
uid: zapier-update-sale-action
title: Set SuperOffice CRM Sale update action
description: How to use SuperOffice update sale action with Zapier
keywords: Update sale, new Zap, Zapier update action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Update a SuperOffice CRM Sale action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Update Sale**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Sale ID**, **Sale title**, **Sale type**, **Stage**, **Date** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Sale id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Find Sale Action][1]
* [Create Sale Action][2]
* [New Sale Trigger][3]
* [Sale Changed Trigger][4]
* [Create a Zap with SuperOffice CRM][5]

<!-- Referenced links -->
[1]: ../search/search-sale.md
[2]: ../create/create-sale.md
[3]: ../../triggers/new/new-sale.md
[4]: ../../triggers/changed/sale-changed.md
[5]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/update/update-sale/update-sale-action.png
[img5]: ../../media/actions/update/update-sale/update-sale-window.png
[img6]: ../../media/actions/update/update-sale/update-sale-output.png

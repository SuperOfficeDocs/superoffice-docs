---
uid: zapier-create-sale-action
title: Set SuperOffice CRM Sale create action
description: How to use SuperOffice create sale action with Zapier
keywords: Create sale, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create SuperOffice CRM Sale action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Sale**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Sale Title**, **Sale type**, **Stage** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Sale id**, **Company id**, **Company name**, **Contact id**, **Contact name**, **Project id**, **Project name**, **Owner id**, **Owner**, **E-mail**, **Sale title**, **Description**, **Note**, **Amount**, **Currency id**, **Currency**, **Sale type id**, **Sale type**, **Status**, **Date**, **Number**, **Stage id**, **Stage**, **Source id**, **Source**, **Probability %**, **Completed?**, **Updated by**, **Updated date**, **Created by**, **Created date**, **Visible for**, **Links**, **Competitor**, **Credited**, **Next activity**, **Profit**, **Profit amount**, **Total cost**, **Self URL**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Find Sale Action][1]
* [Update Sale Action][2]
* [New Sale Trigger][3]
* [Sale Changed Trigger][4]
* [Create a Zap with SuperOffice CRM][5]

<!-- Referenced links -->
[1]: ../search/search-sale.md
[2]: ../update/update-sale.md
[3]: ../../triggers/new/new-sale.md
[4]: ../../triggers/changed/sale-changed.md
[5]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-sale/create-sale-action.png
[img5]: ../../media/actions/create/create-sale/create-sale-window.png
[img6]: ../../media/actions/create/create-sale/create-sale-output.png

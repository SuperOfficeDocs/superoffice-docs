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

> [!NOTE]
> To be able to create Zaps, you must connect a SuperOffice CRM account that has **General Administrator** user rights.

## Steps

1. On the page that lists all your Zaps, click **Create**. You will be taken to a new Zap creation window.

    ![Zapier: Create a new Zap -screenshot][img1]

1. Create your **Trigger** by clicking on it. It can be an action in Google Sheets or another action in external systems or a part of SuperOffice.

    ![Zapier: Create your trigger -screenshot][img2]

1. Click on **Action**. You will be taken to a window from which you can select the application you want to use. Search for and click on SuperOffice.

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Sale**, then click the **Account** section and log in using your SuperOffice account.

    ![Set up your action -screenshot][img4]

1. Click on the **Continue** button at the bottom of the side panel and you will be taken to the **Configure** step.

1. Fill out the mandatory fields **Sale Title**, **Sale type**, **Stage** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. Check that the action works by clicking **Test step**.

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
[img1]: ../../media/common/create-zap.png
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/create/create-sale/create-sale-action.png
[img5]: ../../media/actions/create/create-sale/create-sale-window.png
[img6]: ../../media/actions/create/create-sale/create-sale-output.png

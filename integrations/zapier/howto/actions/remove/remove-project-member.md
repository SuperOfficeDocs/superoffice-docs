---
uid: zapier-remove-project-member-action
title: Set SuperOffice CRM Project Member remove action
description: How to use SuperOffice remove project member action with Zapier
keywords: Remove project member, new Zap, Zapier remove action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Remove a SuperOffice CRM Project Member action

[!include[note](../../includes/note.md)]

## Steps

[!include[create zap step](../../includes/create-zap-intro.md)]

1. [!include[click trigger step](../includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](../includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Remove Project Member**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](../includes/go-to-conf-step.md)]

1. Click on the **Selection** field and select one of the available deletion criteria.

    ![Fill out your action -screenshot][img5]

1. If its selected **Project member id** option, fill out the mandatory field **Project member id**.

    ![Fill out your Project member id action -screenshot][img6]

1. If its selected **Project & member** option, fill out the mandatory field **Project** and **Member**.

    ![Fill out your Project & member action -screenshot][img7]

1. [!include[check action works step](../includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Project id**, **Title**, **Responsible id**, **Responsible**, **Description**, **Number**, **Web site**, **Type id**, **Type**, **Status id**, **Status**, **Completed**, **End date**, **Next milestone**, **Note**, **Created by**, **Created date**, **Updated by**, **Updated date**, **Project members**, **Self URL**.

    ![Zapier: Verify -screenshot][img8]

## Related content

* [Create Project Member Action][1]
* [New Project Member Trigger][2]
* [Project Member Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: ../create/create-project-member.md
[2]: ../../triggers/new/new-project-member.md
[3]: ../../triggers/changed/project-member-changed.md
[4]: ../../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../../media/common/new-zap-window.png
[img3]: ../../media/common/search-superoffice-in-zapier.png
[img4]: ../../media/actions/remove/remove-project-member/remove-project-member-action.png
[img5]: ../../media/actions/remove/remove-project-member/remove-project-member-selection-window.png
[img6]: ../../media/actions/remove/remove-project-member/remove-by-project-member-id-window.png
[img7]: ../../media/actions/remove/remove-project-member/remove-by-project-and-member-window.png
[img8]: ../../media/actions/remove/remove-project-member/remove-project-member-output.png

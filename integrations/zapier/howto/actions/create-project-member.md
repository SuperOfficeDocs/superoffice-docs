---
uid: zapier-create-project-member-action
title: Create SuperOffice CRM Project Member
description: How to create SuperOffice project member with Zapier
keywords: Create project member, new Zap, Zapier create action
author: miguellemos95
date: 11.03.2025
content_type: howto
functional_right: general administrator
category: integration
topic: Zapier
platform: Zapier
language: en
---

# Create a SuperOffice CRM Project Member action

[!include[note](../includes/note.md)]

## Steps

[!include[create zap step](../includes/create-zap-intro.md)]

1. [!include[click trigger step](includes/click-trigger-step.md)]

    ![Zapier: Create your trigger -screenshot][img2]

1. [!include[click trigger step](includes/click-on-action-step.md)]

    ![Zapier: Select your action -screenshot][img3]

1. A side menu will open, in the **Action event** section, select **Create Project Member**, then click the **Account** section and login using a SuperOffice account.

    ![Set up your action -screenshot][img4]

1. [!include[go to conf step](includes/go-to-conf-step.md)]

1. Fill out the mandatory fields **Title**, **Responsible**, **Type** and optionally other fields.

    ![Fill out your action -screenshot][img5]

1. [!include[check action works step](includes/check-action-works-step.md)]

1. If the above steps were configured correctly, the response should consist of **Project member id**, **Company id**, **Company**, **Project id**, **Project**, **Project member type id**, **Project member type**, **Contact id**, **Contact**, **Contact email**, **Comment**.

    ![Zapier: Verify -screenshot][img6]

## Related content

* [Remove Project Member Action][1]
* [New Project Member Trigger][2]
* [Project Member Changed Trigger][3]
* [Create a Zap with SuperOffice CRM][4]

<!-- Referenced links -->
[1]: remove-project-member.md
[2]: ../triggers/new-project-member.md
[3]: ../triggers/project-member-changed.md
[4]: ../../get-started/create-zap.md

<!-- Referenced images -->
[img2]: ../media/new-zap-window.png
[img3]: ../media/search-superoffice-in-zapier.png
[img4]: ../media/create-project-member-action.png
[img5]: ../media/create-project-member-window.png
[img6]: ../media/create-project-member-output.png

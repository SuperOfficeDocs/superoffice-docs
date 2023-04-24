---
uid: help-en-ui-extra-menu-actions
title: Add function to Task button
description: Add function to Task button
author: Bergfrid Dias
so.date: 03.16.2023
keywords: macro, task, actions
so.topic: howto
language: en
---

# Add function to menu button

> [!NOTE]
> Changes done **System design** - **Extra menus** tab will only show in the **SuperOffice Service** module, not in the Requests screen in SuperOffice CRM module.

To add a macro to the **Task** button in the Company screen, Contact screen, Request screen, or **Message** tab:

1. Select ![icon][img3] **System design** > **Extra menus**.
2. Click **Top menu** to display the sub-folders.
3. Hold the mouse pointer over one of these folders: **View request**, **View contact**, **View company** or **Message menu**. Then click ![icon][img1]. The **Menu properties** screen appears.
4. Enter the name of the button in the **Label** field. The name should be quite short, to fit on the button.
5. Select **Use script**, and select a macro.
6. Select the desired position in the **Position** list (0 = top).
7. Click **OK**.
8. Open a request, contact, company or message, click the ![icon][img2] **Task** button and check that the button is displayed and functions as desired.

> [!NOTE]
> You can also add a macro to the **Task** button when you [create or edit a macro][1].

<!-- Referenced links -->
[1]: ../../../../automation/crmscript/learn/create-macro.md

<!-- Referenced images -->
[img1]: ../../../../../media/icons/btn-add.png
[img2]: ../../../../../../common/icons/task.png
[img3]: ../../../../../media/icons/main-menu-small.png

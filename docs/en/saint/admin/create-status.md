---
uid: help-en-saint-status-create
title: Create new status
description: Create new status
keywords: SAINT, activity monitor, status monitor
author: SuperOffice Product and Engineering
date: 09.22.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: 
  - /en/sale/saint/learn/admin/create-status
  - /en/sale/saint/learn/admin/select-image-for-status
  - /en/saint/admin/select-image-for-status
---

# Create a new status

[!include[Requirement](../includes/note-saint-req.md)]

## Why should you create a status monitor?

You want to monitor companies that you have very few activities with, to avoid unhappy customers and churn. With this status monitor, you easily see all the customers who need attention.

![Create a status monitor by clicking the Add button -screenshot][img1]

## Steps

1. Open the **SAINT** screen in Settings and maintenance and select the **Company**, **Contact**, or **Project** tab.

1. Click **Add** below the **Status monitors** list.

1. In the dialog, complete these fields:

    * **Name**: Enter a descriptive name for the status you want to add.

        Optional: Click <i class="ph ph-translate" aria-label="Translate"></i> to [add translations][8] of the status name.

    * **Description**: Enter an explanatory description of the status and what measures are required or recommended. In this field you can also use [template variables][9] to tailor the text to the relevant company, contact or project.

    The name and description are displayed in SuperOffice CRM when the user holds the mouse pointer over the status image or opens the status image for the company. You can subsequently [edit the description][2].

1. Click **Save**. The status is displayed in the status list.

1. If there are several statuses in the list, set the **priority** to control which status image is displayed on the card.
    A company, contact, or project can match the criteria for multiple statuses, but only one image can be shown.
    Select a status and use the arrow buttons below the list to move it up or down.

    ![List of status monitors with priorities -screenshot][img2]

### Specify criteria for the status

Each status must include at least one criterion. After creating the status:

1. Select the new status in the list.
1. Select **Add** to insert a new criterion.
1. Choose a criterion type, set the condition, and enter a value.
1. Repeat as needed, then select **Regenerate selected status monitor** to activate the status.

## <a id="image"></a>Select an image for a status

You can add an image to be displayed on company, contact, or project cards that meet the status criteria. The image appears as a light watermark (40% transparency) so it does not obscure other content.

Adding an image is optional. It can help draw attention and symbolize the type of follow-up action you want users to take. If you only want to use the status for searches or selections, you can leave it without an image.

1. In the status list, select the required status.
1. On the right side of the screen, check **Visualize** to display the image.
1. Select **Change image**.
1. Do one of the following:
    * Select one of the existing images from the **Images** list.
    * Select **Add**, upload a file, enter a description, and select **Save**.
1. Select **OK** to confirm.

[!include[File type and size](../../learn/includes/image-type-and-size.md)]

> [!TIP]
> Use simple, light-colored images that represent the status meaningfully. For example, a spider's web can symbolize inactivity.

## Related content

* [Specify status criteria][6]
* [Specify a period length][7]
* [Regenerate status monitors and counters][4]

<!-- Referenced links -->
[2]: edit-status.md
[4]: manage-status-monitors.md
[6]: select-status-criteria.md
[7]: select-period-length.md
[8]: ../../globalization-and-localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/admin-saint-company.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png

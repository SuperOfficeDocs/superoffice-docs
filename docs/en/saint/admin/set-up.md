---
uid: help-en-saint-setup
title: Set up a new activity monitor
description: Set up a new activity monitor
keywords: SAINT, activity monitor, status monitor
author: SuperOffice Product and Engineering
date: 09.23.2025
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
  - /en/saint/admin/create-status
---

# Set up a new activity monitor

[!include[Requirement](../includes/note-saint-req.md)]

With an activity monitor, you easily see all the customers who need attention.

To create a status, you define its name and description, add at least one criterion, and optionally set a priority, default follow-up type, or image. The steps below show the full process.

## Steps

1. Open the **SAINT** screen in Settings and maintenance and select the **Company**, **Contact**, or **Project** tab.

1. Click **Add** below the **Status monitors** list.

1. In the dialog, complete these fields:

    * **Name:** Enter a descriptive name for the status you want to add.
        Optional: Click <i class="ph ph-translate" aria-label="Translate"></i> to [add translations][8] of the status name.

    * **Description:** Enter a clear description of the status and what action is required or recommended. You can also use [template variables][9] to tailor the text to the company, contact, or project.

    ![New status monitor dialog -screenshot][img1]

    The name and description are displayed in SuperOffice CRM when the user hovers over the status image or opens the status dialog. You can later edit the description.

1. Click **Save**. Then select the new status in the list to continue with the setup.

1. **Specify criteria for the status:**

    1. Below the criteria list, select **Add** to insert a new criterion.
    1. Choose a criterion type, set the condition, and enter a value.

    ![Criteria list with multiple conditions defined and the Add button below the list -screenshot][img3]

    Each status must include at least one criterion. Repeat as needed to add more.

1. *(Optional)* [Define a default follow-up type][2] for the status in the **Create follow-up** tab.

1. *(Optional)* [Select an image to visualize the status](#image).

1. If there are several statuses in the list, set the **priority** to control which status image is displayed on the card.
    A company, contact, or project can match the criteria for multiple statuses, but only one image can be shown.
    Select a status and use the arrow buttons below the list to move it up or down.

    ![List of status monitors with priorities -screenshot][img2]

1. When you are done, select <i class="ph ph-arrow-circle-right" aria-hidden="true"></i> **Regenerate selected status monitor** to activate the status.

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

## Use template variables in descriptions

You can use template variables in the **Description** field to personalize the text shown in follow-ups or status dialogs. Variables are replaced with information from the company, contact, or project.

### Example

A status could apply to companies that meet the following criteria:

* Category = Customer
* Last sale more than 2 months old
* Number of sales greater than 50

The text in the **Description** field could be:

"&lt;name&gt; has previously been a good customer, but we have not sold anything to them in 2 months. &lt;cont&gt; is the main contact for this customer and should get in touch with the customer soon by phone (&lt;cpho&gt;) or email (&lt;mail&gt;) to find out why."

In this example, the following template variables are used:

| Variable | Description |
|---|---|
| name | The name of the company |
| cont | The name of our contact for the company |
| cpho | The company's phone number |
| mail | The company's email address |

## Related content

* [Update, delete, and restore status monitors][2]
* [Counters and counter settings (period)][7]
* [Regenerate status monitors and counters][4]

<!-- Referenced links -->
[2]: update.md
[4]: update.md#regen
[7]: counter-settings.md
[8]: ../../localization/learn/translate-fields.md
[9]: ../../document/templates/variables/index.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/saint/new-status-monitor.png
[img2]: ../../../media/loc/en/saint/status-list-priority.png
[img3]: ../../../media/loc/en/saint/criteria.png

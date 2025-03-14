---
uid: help-en-sales-guide
title: Sales guide
description: Introduction to sales guides in SuperOffice.
keywords: sales guide, guide, workflow, Sales guide section tab, sale
author: Bergfrid Dias
date: 01.07.2025
version: 10.5.2
topic: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Sales guides

Sales guides in SuperOffice CRM are powerful tools designed to simplify and standardize the sales process by linking sale types to predefined stages. Each stage includes suggested follow-ups and documents that guide sales staff through a structured sales pipeline, ensuring no opportunities are missed and maintaining consistency across your team.

> [!NOTE]
> This feature requires the Sales Premium licence.

## What is a sales guide?

A sales guide consists of:

* **Stages:** Predefined phases in the sales process, such as First Meeting, Quotation, or Closing. Each stage has a name, a probability percentage, and a description.
* **Follow-ups:** Actions like calls or meetings associated with each stage.
* **Documents:** Templates for quotations, contracts, or emails relevant to the sales process.

When you create a sale or update its type to one with a linked sales guide, the guide automatically activates in the **Sales guide** section tab. This tab provides an overview of stages, follow-ups, and documents for the sale.

**Example:**

A sale type for new customer acquisition might include:

* First Meeting stage: Meeting follow-up and introductory email.
* Quotation stage: Preparing and sending the quotation.
* Closing stage: Signing the contract and scheduling follow-ups.

Sales guides are set up in Settings and maintenance and can be tailored to fit your organization's specific workflows.

## How a sales guide works

Watch this video to learn how easy it is to use the Sales guide:

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/IyETjAtn3po]

(video length - 1:24)

### Steps

1. **Start with a stage:** When you create or update a sale with a linked sales guide, the first stage is automatically set. The **Sales guide** section tab displays the follow-ups and documents associated with this stage.

1. **Create activities:** Follow-ups and documents can be created directly from the **Sales guide** section tab:
    * Click **Create** next to the follow-up or document name.
    * Complete the prefilled fields in the dialog and save.

    > [!TIP]
    > Assign follow-ups to specific team members for better collaboration.

1. **Mark task as completed:** After completing an activity, check the box next to its name in the **Sales guide** section tab. Documents are marked completed automatically when created.

    Completed items also appear in the **Activities** section tab.

1. **Move to the next stage:** Once all activities for a stage are complete or as needed:
    * Manually move the sale to the next stage or allow automatic progression (if configured).
    * The guide updates to display the suggested follow-ups and documents for the new stage.

1. **Repeat until sale completion:** Work through the stages until the sale is marked as **Sold** or **Lost**.

> [!NOTE]
> You can move to the next stage without completing all follow-ups for the current stage.

## <a id="sales-guide-tab"></a>Sales guide section tab

The **Sales guide** section tab provides a visual and functional overview of the sales process, helping sales reps track progress and manage tasks efficiently.

![Sales guide section tab showing First Meeting status -screenshot][img1]

### Key components

* **Stage buttons:** Located at the top, these buttons represent predefined stages, such as First Meeting, Quotation, and Closing.

    ![Sales guide stages -screenshot][img2]

  * **Current stage:** Highlighted with a filled circle (<i class="ph ph-fill ph-circle" aria-hidden="true"></i>).
  * **Future stages:** Marked with an open circle (<i class="ph ph-circle" aria-hidden="true"></i>).
  * **Completed stages:** Marked with a check (<i class="ph ph-check" aria-hidden="true"></i>).

* **Activities:** The tab is divided into two columns: **Follow-ups** and **Documents**. Each row includes a **Create** link, enabling users to generate the required follow-up or document directly from the section tab.

    > [!TIP]
    > Use the **Show all stages** checkbox to view all activities and documents across stages.

## Create a follow-up or document

To create a follow-up or document linked to a sales guide:

1. Go to the **Sales guide** section tab.
1. Locate the follow-up or document under the current stage.
1. Click **Create** next to the item.

   * For follow-ups, the [Follow-up dialog][6] opens with prefilled fields based on the sales guide's settings. Modify as needed, then click **Save**.

   * For documents, the [Document dialog][7] opens with a preselected template. Complete the required fields and click **Save**.

> [!TIP]
> You can create multiple follow-ups or documents of the same type by right-clicking an item and selecting **Create another**.

## Mark a follow-up as completed

1. In the **Sales guide** section tab, locate the follow-up.
1. Check the box next to the follow-up's name. The task is marked as completed and appears in the **Activities** section tab as finished.

Documents are automatically marked as completed upon creation.

### Why does the Sales guide dialog open when complete a follow-up?

In Settings and maintenance, it is possible to specify that a follow-up in a sales guide should be suggested automatically when the preceding follow-up is marked as completed. In that case, the **Sales guide** dialog opens when you mark the previous follow-up as completed.

In the **Sales guide** dialog you have three options:

* Click **Create** to create the next follow-up in the sales guide. This takes you directly to the dialog for follow-ups.

* Click **Cancel** if you do not want to create the follow-up at the moment. The **Sales guide** dialog closes and you should remember to create the follow-up later on.

* Check **Always create follow-up? Do not show this dialog again** if, in future, you always want to create the suggested follow-up. The dialog for follow-ups will then open automatically next time.

> [!TIP]
> To reset this option, so that the **Sales guide** dialog opens, go to <i class="ph ph-user-circle" aria-hidden="true"></i> **Personal settings** > **Preferences** > **Sale** and select **Yes** for the **Confirm creation of suggested follow-up** option.

## <a id="change-stage"></a>Move to the next stage

Sales guides support both manual and automatic progression through stages:

### Automatic stage progression

If enabled, the next stage is suggested when all required follow-ups and documents in the current stage are marked as completed. You can choose to move forward or remain in the current stage.

![Automatic sale stage progression dialog -screenshot][img3]

1. Complete all required follow-ups and documents for the current stage.
1. When the dialog appears, click **Yes** to move to the next stage or **No** to remain in the current stage.

> [!NOTE]
> Automatic progression must be enabled in **Settings and maintenance** for this feature to work.

### Manual stage progression

You can manually move the sale to the next stage if needed, without completing all follow-ups and documents in the current phase.

1. Right-click the button for the desired stage in the **Sales guide** section tab.
1. Select **Move to this stage** from the menu.

Alternatively:

1. Click **Edit** (<i class="ph ph-pencil-simple" aria-hidden="true"></i>) on the Sale card.
1. Use the **Stage** dropdown to select the next stage.
1. Click **Save**.

> [!TIP]
> You can also return to a previous stage by following the same steps.

## Benefits of using sales guides

* Consistency: Standardizes sales processes across your organization.
* Efficiency: Provides clear steps, templates, and tasks for every stage.
* Visibility: Keeps sales reps focused on the current stage and upcoming steps.

## Related content

* [Introduction to sales][1]
* [Create a sale][2]
* [Sales guide tutorial][3]
* [Create a new sales guide][4]
* [Edit or deactivate a sales guide][5]

<!-- Referenced links -->
[1]: index.md
[2]: create.md
[3]: tutorial.md
[4]: ../admin/create-sales-guide.md
[5]: ../admin/edit-sales-guide.md
[6]: ../../diary/learn/create-follow-up.md
[7]: ../../document/learn/edit.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/sales-guide-tab.png
[img2]: ../../../media/loc/en/sale/guide-stages.png
[img3]: ../../../media/loc/en/sale/goto-next-stage.png

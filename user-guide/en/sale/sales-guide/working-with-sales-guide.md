---
uid: help-en-working-with-sales-guide
title: Working with sales guide
description: Working with sales guide
author: SuperOffice RnD
so.date: 07.04.2022
keywords: sale
so.topic: help
language: en
---

# Work with sales guides

If a sales guide has been defined for a sale type that you specify for a sale, the following happens:

* The first stage in the sales guide is selected in the **Stage** field on the main **Sale** card.
* Follow-ups and/or documents for the stage are listed on the **Sales guide** section tab.

This is how you perform the sales process:

1. Click the **Create** button in front of the follow-up/document name.

2. In the dialog which appears, you create the follow-up/document in the usual way. Many of the fields are prefilled, but you can change the information, or add more information. See [The Document dialog][1] and [The dialog for follow-ups][2].

3. When you have completed the follow-up, check **Completed** in the relevant dialog, or in the checkbox in front of the follow-up name on the **Sales guide** section tab. By default, documents are marked as completed.

    > [!TIP]
    > If you want to create several follow-ups of the same type, right-click the activity and select **Create another**. The [follow-ups dialog][2] then opens.

4. Once all follow-ups and documents for a stage have been completed, go to the next stage on the main **Sale** card.

    > [!NOTE]
    > If you wish, you can go to the next stage without creating or performing all the follow-ups/documents in a stage.

5. Repeat the above procedure for all follow-ups/documents in each stage of the sales guide.

## How to advance the status

You can move the project to the next status in two ways:

**From the Sales guide:**

1. Right-click the button for the next status in the **Sales guide** section tab and select **Move to this status**.

**From the Sale tab:**

1. Click **Edit** on the **Sale** tab.
2. Click the arrow next to the **Stage** field.
3. Select the required stage from the list that appears. Apart from the statuses **Sold** and **Lost**, the options in the list are defined in SuperOffice Settings and maintenance.
4. Click **Save**.

## Why does the Sales guide dialog open when I mark a follow-up as completed?

In SuperOffice Settings and maintenance, it is possible to specify that a follow-up in a sales guide should be suggested automatically when the preceding follow-up is marked as completed. In that case, the **Sales guide** dialog opens when you mark the previous follow-up as completed.

In the **Sales guide** dialog you have three options:

* Click **Create** to create the next follow-up in the sales guide. This takes you directly to the dialog for follow-ups.
* Click **Cancel** if you do not want to create the follow-up at the moment. The **Sales guide** dialog closes and you will need to remember to create the follow-up later on.
* Check **Always create follow-up? Do not show this dialog again** if, in future, you always want to create the suggested follow-up. The dialog for follow-ups will then open automatically next time.

> [!TIP]
> If you want to reset this option, so that the **Sales guide** dialog opens, go to ![icon][img1] **Personal settings &gt; Preferences &gt; Sale** and select **Yes** for the **Confirm creation of suggested follow-up** option.

[Click here for an example of a sales guide.][3]

<!-- Referenced links -->
[1]: ../../clients/sales/document/document-dialog.md
[2]: ../../diary/dialog-for-followups.md
[3]: example-salesguide.md

<!-- Referenced images -->
[img1]: ../../../media/icons/globalmenu-personalsettings-small.png

---
uid: help-en-sales-guide-create
title: Create new sales guide
description: How to create a sales guide in SuperOffice
author: SuperOffice RnD
so.date: 06.29.2022
keywords: sale, guide
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Create a new sales guide

[!include[Must be admin](../../../learn/includes/req-admin.md)]

This procedure shows you how to create a sales guide from scratch.

1. Define [stages](#create-stages) to include in the sales guide.
2. Define [the sales type](#create-type) (with associated stages) that the sales guide will be linked to.
3. Design the [sales guide](#create-guide).

## <a id="create-stages" />Create stages for the sales guide

A sales guide must be linked to a sale type, which in turn consists of several stages. [How to create stages][2].

For example, a sales guide for sales to new customers may include the stages "First meeting", "Quotation" and "Signing of contract".

Go to the next procedure to link the stages to a sale type.

## <a id="create-type" />Create a sale type for the sales guide

A sales guide must be linked to a sale type. [How to create a sale type][3].

Examples of sale types: "Sale to new customer", "Sale to existing customer", "Cross-sale to existing customer".

1. Check **This sale type is linked to a guide**.
1. Select at least two stages.
1. Go to the next procedure to create the sales guide.

## <a id="create-guide" />Create a sales guide

Once you have created stages and specified a sale type for the sales guide, you can design the sales guide itself by adding follow-ups and/or documents for each stage.

1. Click the **Workflow** button in the Navigator (![icon][img1]).

2. Select the **Sales guide** tab.

3. In the list at the top, select the sale type you want to create a sales guide for. The stages selected for this sale type are displayed in the list underneath.

    * If the sale type is not set up to have a sales guide, click **Click here to turn on guide** at the bottom of the screen.

    * If there are no stages defined for the sale type, click **Click here to add stages** at the bottom of the screen. You can also edit the sale type by clicking the **Edit** button at the top.

4. Select the required stage in the list. The stage's details are shown at the bottom of the screen.

5. [Add one or more follow-ups](#add-a-follow-up-for-a-stage) for the selected stage.

    You do not need to add a document for each stage, but you should add at least one follow-up for each stage.

6. [Add one or more documents](#add-a-document-for-a-stage) for the selected stage.

7. Repeat steps 4-6 for each stage you want to add follow-ups and documents for.

The changes are saved automatically. The sales guide will now be displayed in SuperOffice CRM when a sale is created with the sale type selected in step B.

## <a id="add-fo-stage" />Add a follow-up for a stage

<details><summary>Click here for an example of a follow-up</summary>

**Sale type**: Sale to new customer
**Stage**: First meeting
**Name** of follow-up: First meeting
**Purpose of this follow-up**: Examine the potential customer's requirements and assess if the product can meet their needs
**Follow-up type**: Customer meeting
**Duration**: 1 hour
**Default text**:

Agenda for first meeting:

\- Information about the customer's business and organization
\- Needs, wants, problems
\- Company presentation
\- Other
</details>

**Steps:**

1. Select the required sale type and stage as described above.

2. Click **Add** under **Suggested follow-ups in stage**.

3. In the **Suggested follow-up** dialog, enter the name of the follow-up in the **Name** field. This should be a descriptive name for the follow-up.

4. In the **The purpose of this follow-up** field, enter the text to use as tooltip for the follow-up in the **Sales guide** section tab in SuperOffice CRM.

    > [!NOTE]
    > Some of the options below are, for logical reasons, not relevant for the first follow-up in a sales guide.

5. Check **Automatically suggest this follow-up** if you want SuperOffice CRM to suggest this follow-up when the previous follow-up (in this or the previous stage) is marked as completed.

6. Select a type for the follow-up in the **Follow-up type** list.

7. In the **Start date** field, specify how many days there should be between the previous follow-up and this one.

8. In the **Duration** field, specify how long the follow-up should last. The format is *0h00m*.

9. In the **Default text in follow-up** field, enter a description for the follow-up.

    > [!TIP]
    > The user can change the above information as required.

10. Click **Save**.

11. Repeat this procedure to add more follow-ups in this or other stages.

## <a id="add-doc-stage" />Add a document for a stage

<details><summary>Click here for an example of a document</summary>

**Sale type**: Sale to new customer
**Stage**: First meeting
**Name** of document: Meeting confirmation
**Purpose of this sales step**: Send an email with meeting confirmation and date/time to all participants for the first meeting.
**Template**: Email
**Default subject**: Meeting confirmation (first meeting)
</details>

**Steps:**

1. Select the required sale type and stage as described above.

2. Click **Add** under **Suggested documents in stage**.

3. In the **Suggested document** dialog, enter the name of the document in the **Name** field. This should be a descriptive name for the document.

4. In the **The purpose of this document** field, enter the text to use as tooltip for the document in the **Sales guide** section tab.

5. Select the required template in the **Template** field (see also [Document - Template][4]).

6. Enter the subject to be used in the document in the **Default subject** field.

7. Enter any reference in the **Our ref.** field. For example, a [template variable][1] for sales number, sales title or another field relating to the sale.

8. Click **Save**.

9. Repeat this procedure to add more documents in this or other stages.

<!-- Referenced links -->
[1]: ../../../document/templates/variables/for-sales.md
[2]: ../../../admin/lists/learn/sale-stage.md
[3]: ../../../admin/lists/learn/sale-type.md
[4]: ../../../admin/lists/learn/document-template.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-workflow-active.png

---
uid: help-en-sales-guide-create
title: Create a new sales guide
description: How to create a sales guide in SuperOffice
keywords: create sales guide, new sales guide, sales guide, guide, workflow, sale
author: SuperOffice RnD
date: 01.06.2025
version: 10.5
topic: howto
license: salespremium
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Create a new sales guide

[!include[Must be admin](../../learn/includes/req-admin.md)]

In Settings and maintenance, you define which sale types are to be assigned a sales guide and which stages and activities the sales guides are to contain. What a sales guide looks like can therefore vary.

The best way to define your own workflow is, first and foremost, to discuss and agree on the best practices in your sales process. You can set up multiple sale types with guides if your company uses more than one sales process. For example, you can have a sale type with guide for prospects, for existing customer and one for long-term sales processes that contain many stages and activities.

This procedure shows you how to create a sales guide from scratch.

1. Define [stages](#create-stages) to include in the sales guide.
2. Define [the sale type](#create-type) (with associated stages) that the sales guide will be linked to.
3. Design the [sales guide](#create-guide).

## <a id="create-stages"></a>Create stages for the sales guide

A sales guide must be linked to a sale type, which in turn consists of several stages. [How to create stages][2].

For example, a sales guide for sales to new customers may include the stages "First meeting", "Quotation" and "Signing of contract".

Go to the next procedure to link the stages to a sale type.

## <a id="create-type"></a>Create a sale type for the sales guide

A sales guide must be linked to a sale type. [How to create a sale type][3].

Examples of sale types: "Sale to new customer", "Sale to existing customer", "Cross-sale to existing customer".

1. Check **This sale type is linked to a guide**.
1. Select at least two stages.
1. Go to the next procedure to create the sales guide.

## <a id="create-guide"></a>Create a sales guide

After you have created stages and specified a sale type for the sales guide, you can design the sales guide itself by adding follow-ups and/or documents for each stage.

1. Click <i class="ph ph-arrows-left-right" aria-hidden="true"></i> **Workflow** in the Navigator.

2. Select the **Sales guide** tab.

3. In the list at the top, select the sale type you want to create a sales guide for. The stages selected for this sale type are displayed below.

    * If the sale type is not set up to have a sales guide, click **Click here to turn on guide**.

    * If there are no stages defined for the sale type, click **Click here to add stages**. You can also edit the sale type by clicking the **Edit** button at the top.

4. Select the required stage in the list. The stage's details are shown at the bottom of the screen.

5. [Add one or more follow-ups](#add-doc-stage) for the selected stage.

    You do not need to add a document for each stage, but you should add at least one follow-up for each stage.

6. [Add one or more documents](#add-doc-stage) for the selected stage.

7. Repeat steps 4-6 for each stage you want to add follow-ups and documents for.

The changes are saved automatically. The sales guide will now be displayed in SuperOffice CRM when a sale is created with the sale type selected in step B.

## <a id="add-fo-stage"></a>Add a follow-up for a stage

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

### Example of a follow-up

* **Sale type**: Sale to new customer
* **Stage**: First meeting
* **Name** of follow-up: First meeting
* **Purpose of this follow-up**: Examine the potential customer's requirements and assess if the product can meet their needs
* **Follow-up type**: Customer meeting
* **Duration**: 1 hour
* **Default text**:

Agenda for first meeting:

\- Information about the customer's business and organization
\- Needs, wants, problems
\- Company presentation
\- Other

## <a id="add-doc-stage"></a>Add a document for a stage

1. Select the required sale type and stage as described above.

2. Click **Add** under **Suggested documents in stage**.

3. In the **Suggested document** dialog, enter the name of the document in the **Name** field. This should be a descriptive name for the document.

4. In the **The purpose of this document** field, enter the text to use as tooltip for the document in the **Sales guide** section tab.

5. Select the required [template][4] in the **Template** field.

6. Enter the subject to be used in the document in the **Default subject** field.

7. Enter any reference in the **Our ref.** field. For example, a [template variable][1] for sales number, sales title or another field relating to the sale.

8. Click **Save**.

9. Repeat this procedure to add more documents in this or other stages.

### Example of a document

* **Sale type**: Sale to new customer
* **Stage**: First meeting
* **Name** of document: Meeting confirmation
* **Purpose of this sales step**: Send an email with meeting confirmation and date/time to all attendees for the first meeting.
* **Template**: Email
* **Default subject**: Meeting confirmation (first meeting)

<!-- Referenced links -->
[1]: ../../document/templates/variables/for-sales.md
[4]: ../../document/templates/learn/index.md
[2]: sale-stage.md
[3]: sale-type.md

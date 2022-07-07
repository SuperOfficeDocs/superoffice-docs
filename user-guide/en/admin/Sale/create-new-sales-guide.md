---
uid: help-en-create-new-sales-guide
title: Create new sales guide
description: Create new sales guide
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Create a new sales guide

This procedure shows you how to create a sales guide from scratch.

Before you can create the sales guide itself, you need to define

* [stages](Create-new-sales-guide.md#Create-stages-for-sales-guide) to include in the sales guide
* [the sales type](Create-new-sales-guide.md#Create-sales-type) (with associated stages) that the sales guide will be linked to

Once you have done that, you can start designing the [sales guide](Create-new-sales-guide.md#Create-sales-guide) itself.

## A. Create stages for the sales guide

A sales guide must be linked to a sale type, which in turn consists of several stages. You can create stages by following the procedure under [Add items to the Sale - Stage list](../chap08/Adding-items-to-Sale-Stage-list.md).

A sales guide for sales to new customers might include, for example, the stages "First meeting", "Quotation" and "Signing of contract".

Go to the next procedure to link the stages to a sale type.

## B. Create a sale type for the sales guide

A sales guide must be linked to a sale type. You can create a sale type by following the procedure under [Add items to the Sale - Type, Stages, Quote list](../chap08/Adding-items-to-Sale-Sales-type-(for-stages)-list.md).

Examples of sale types: "Sale to new customer", "Sale to existing customer", "Cross-sale to existing customer".

> [!NOTE]
> You need to check **This sale type is linked to a guide**. You should also select at least two stages.

Go to the next procedure to create the sales guide.

## C. Create a sales guide

Once you have created stages and specified a sale type for the sales guide, you can design the sales guide itself. You do this by adding follow-ups and/or documents for each stage of the sales guide.

Do as follows:

1. Click the **Workflow** button in the Navigator (![icon](../media/knapp-arbeidsflyt-liten.bmp)).

2. Select the **Sales guide** tab.

3. In the list at the top, select the sale type you want to create a sales guide for. The stages selected for this sale type are displayed in the list underneath.

    > [!NOTE]
    > If the sale type is not set up to have a sales guide, you need to click **Click here to turn on guide** at the bottom of the screen. If there are no stages defined for the sale type, you need to click **Click here to add stages** at the bottom of the screen. You can also edit the sale type by clicking the **Edit** button at the top.

4. Select the required stage in the list. The stage's details are shown at the bottom of the screen.

5. Add one or more follow-ups for the selected stage, as described under [Add a follow-up for a stage](Create-new-sales-guide.md#Add-activity-for-stage) below.

    > [!NOTE]
    > You do not need to add a document for each stage, but you should add at least one follow-up for each stage.

6. Add one or more documents for the selected stage, as described under [Add a document for a stage](Create-new-sales-guide.md#Add-document-for-stage) below.

7. Repeat steps 4-6 for each stage you want to add follow-ups and documents for.

The changes are saved automatically. The sales guide will now be displayed in SuperOffice CRM when a sale is created with the sale type selected in step B.

## Add a follow-up for a stage

<!-- Fix reuse ID=a1 -->

**Sale type**: Sale to new customer

**Stage**: First meeting

**Name** of follow-up: First meeting

**Purpose of this follow-up**: Examine the potential customer's requirements and assess whether the product can meet their needs

**Follow-up type**: Customer meeting

**Duration**: 1 hour

**Default text**:

Agenda for first meeting:

\- Information about the customer's business and organisation

\- Needs, wants, problems

\- Company presentation

\- Other

To add follow-ups to a stage:

1. Select the required sale type and stage as described above.

2. Click **Add** under **Suggested follow-ups in stage**. The **Suggested follow-up** dialog opens.

3. Enter the name of the follow-up in the **Name** field. This should be a descriptive name for the follow-up.

4. Enter the purpose of the follow-up, in the **The purpose of this follow-up** field. This text is displayed when you hold the mouse-pointer over the follow-up in the **Sales guide** section tab in SuperOffice CRM.

    > [!NOTE]
    > Some of the options below are, for logical reasons, not relevant for the first follow-up in a sales guide.

5. Check **Automatically suggest this follow-up** if you want SuperOffice CRM to suggest this follow-up when the previous follow-up (in this or the previous stage) has been marked as completed.

6. Select a type for the follow-up in the **Follow-up type** list.

7. In the **Start date** field, specify how many days there should be between the previous follow-up and this one.

<!-- -->

1. In the **Duration** field, specify how long the follow-up should last. The format is *0h00m*.
2. In the **Default text in follow-up** field, enter a description for the follow-up.

> [!TIP]
> The user can change the above information as required.

1. Click **Save** to save your changes in Settings and maintenance.

2. Repeat this procedure to add more follow-ups in this or other stages.

## Add a document for a stage

<!-- Fix reuse ID=a2 -->

**Sale type**: Sale to new customer

**Stage**: First meeting

**Name** of document: Meeting confirmation

**Purpose of this sales step**: Send an e-mail with meeting confirmation and date/time to all participants for the first meeting.

**Template**: E-mail

**Default subject**: Meeting confirmation (first meeting)

To add documents to a stage:

1. Select the required sale type and stage as described above.
2. Click **Add** under **Suggested documents in stage**. The **Suggested document** dialog opens.
3. Enter the name of the document in the **Name** field. This should be a descriptive name for the document.
4. Enter the purpose of the document, in the **The purpose of this document** field. This text is displayed when you hold the mouse-pointer over the document in the **Sales guide** section tab in SuperOffice CRM.
5. Select the required template in the **Template** field (see also [Document - Template](../chap08/Document-template.md)).
6. Enter the subject to be used in the document in the **Default subject** field.
7. Enter any reference in the **Our ref.** field. Here you might enter a [template variable][1] for sales number, sales title or another field relating to the sale.
8. Click **Save** to save your changes in Settings and maintenance.
9. Repeat this procedure to add more documents in this or other stages.

<!-- Referenced links -->
[1]: ../../user/standardcrm/diary/template-variables.md#variables-for-sales

<!-- Referenced images -->

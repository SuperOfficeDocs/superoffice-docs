---
uid: help-en-adding-items-to-relation-list
title: Adding items to the Relation list
description: Adding items to the Relation list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the General - Relation list

When you add an item to the **General - Relation** list in Settings and maintenance, the **Edit list item** dialog is not the same as described under [Add items][1].

[!include[Edit list item](../../includes/edit-list-item.md)] when the list items are relations:

1. Enter the required name of the item in the **Name** field. What you enter here is displayed in the **has relations** column on the **Relations** section tab in the **Company** screen in SuperOffice CRM. It should be a verb in the *active* form, e.g. *owns*.

    > [!NOTE]
    > [!include[Mandatory](../includes/note-mandatory-field.md)]

2. Enter the passive form of the relation in the **Passive form** field. What you enter here is displayed in the **has relations** column on the **Relations** section tab in the **Company** screen in SuperOffice CRM. It should be a verb in the *passive* form, e.g. *owned by*. <!-- Fix reuse ID=a1 -->

    | Type | Active | Passive |
    |---|---|---|
    | Company – Company: | Company ABC Ltd cooperates with Consultancy Firm Co. | Consultancy ABC Ltd cooperates with Company Firm Co. |
    | Company - Contact: | Company ABC Ltd hires Greg Campbell (Consultancy Firm Co.) | Greg Campbell (Consultancy ABC Ltd) is hired by Company Firm Co. |
    | Contact - Company: | Peter Johnson owns Company ABC Ltd | Company ABC Ltd is owned by Peter Johnson. |
    | Contact - Contact: | Mark Johnson (Consultancy Firm Co.) is the son of Peter Johnson (Company ABC Ltd). | Peter Johnson (Company ABC Ltd) is the father of Mark Johnson (Consultancy Firm Co.). |

3. Under **This is a relationship between**, specify whether the relationship refers to a company and/or a contact on the active and passive side respectively. These fields correspond to the fields in the **Relation** dialog in SuperOffice CRM.

4. Under **Example** you can see an example of what the relationship looks like in practice, i.e. in the **Relations** section tab in SuperOffice CRM.

5. Optionally, type in a description of the item in the **Description** field.

6. [!include[Save or cancel](../includes/save-or-cancel.md)]

<!-- Referenced links -->
[1]: adding-items.md

<!-- Referenced images -->

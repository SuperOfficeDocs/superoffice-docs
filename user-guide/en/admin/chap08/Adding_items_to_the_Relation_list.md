---
uid: help-en-adding-items-to-the-relation-list
title: Adding items to the Relation list
description: Adding items to the Relation list
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add items to the General - Relation list

When you add an item to the **General - Relation** list in Settings and maintenance, the **Edit list item** dialog is not the same as described under [Add items](Adding_items.md).

To complete the fields in the **Edit list item** dialog when the list items are relations:

1. Enter the required name of the item in the **Name** field. What you enter here is displayed in the **has relations** column on the **Relations** section tab in the **Company** screen in SuperOffice CRM. It should be a verb in the *active* form, e.g. *owns*.

    > [!NOTE]
    > This is a mandatory field and must therefore be filled in.

2. Enter the passive form of the relation in the **Passive form** field. What you enter here is displayed in the **has relations** column on the **Relations** section tab in the **Company** screen in SuperOffice CRM. It should be a verb in the *passive* form, e.g. *owned by*. <!-- Fix reuse ID=a1 -->
    <table data-cellspacing="0" style="width:100%; max-width:87.487%">
    
    <tbody>
    <tr>
    <td><p>Type</p></td>
    <td><p>Active</p></td>
    <td><p>Passive</p></td>
    </tr>
    <tr>
    <td><p>Company – Company:</p></td>
    <td><p>Company ABC Ltd cooperates with Consultancy Firm Co.</p></td>
    <td><p>Consultancy ABC Ltd cooperates with Company Firm Co.</p></td>
    </tr>
    <tr>
    <td><p>Company - Contact:</p></td>
    <td><p>Company ABC Ltd hires Greg Campbell (Consultancy Firm Co.)</p></td>
    <td><p>Greg Campbell (Consultancy ABC Ltd) is hired by Company Firm Co.</p></td>
    </tr>
    <tr>
    <td><p>Contact - Company:</p></td>
    <td><p>Peter Johnson owns Company ABC Ltd</p></td>
    <td><p>Company ABC Ltd is owned by Peter Johnson.</p></td>
    </tr>
    <tr>
    <td><p>Contact - Contact:</p></td>
    <td><p>Mark Johnson (Consultancy Firm Co.) is the son of Peter Johnson (Company ABC Ltd).</p></td>
    <td><p>Peter Johnson (Company ABC Ltd) is the father of Mark Johnson (Consultancy Firm Co.).</p></td>
    </tr>
    </tbody>
    </table>

3. Under **This is a relationship between**, specify whether the relationship refers to a company and/or a contact on the active and passive side respectively. These fields correspond to the fields in the **Relation** dialog in SuperOffice CRM.

4. Under **Example** you can see an example of what the relationship looks like in practice, i.e. in the **Relations** section tab in SuperOffice CRM.

5. Optionally, type in a description of the item in the **Description** field.

6. Click **Save** to save the changes in Settings and maintenance, or **Cancel** to reject your changes.

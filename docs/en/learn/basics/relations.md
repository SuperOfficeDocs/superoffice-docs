---
uid: help-en-company-contact-relations
title: Company and contact relations in SuperOffice CRM
description: Learn how to view, add, and manage relationships between companies and contacts in SuperOffice CRM, simplifying the tracking of complex business associations and custom connections.
keywords: add relation, delete relation, relation, person, contact, company
author: Bergfrid Skaara Dias
date: 01.20.2025
version: 10.5
topic: howto
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Company and contact relations in SuperOffice CRM

Relations in SuperOffice CRM allow you to establish connections between companies and contacts. Relations always consist of two parties: one active and one passive. For example, "Company A owns Company B," where Company A is the active party and Company B is the passive. This guide provides an overview of how to view, add, and manage these relationships, making it easier to track complex structures, associations, or any custom relationships your business requires.

## Examples of relations

Examples include ownership structures, partnership agreements, or personal relationships between contacts.

| Type | Active | Passive |
|---|---|---|
| Company - company | Company ABC Ltd cooperates with Consultancy Firm Co. | Consultancy ABC Ltd cooperates with Company Firm Co. |
| Company - contact | Company ABC Ltd hires Greg Campbell (Consultancy Firm Co.) | Greg Campbell (Consultancy ABC Ltd) is hired by Company Firm Co. |
| Contact - company | Peter Johnson owns Company ABC Ltd | Company ABC Ltd is owned by Peter Johnson. |
| Contact - contact | Mark Johnson (Consultancy Firm Co.) is the son of Peter Johnson (Company ABC Ltd). | Peter Johnson (Company ABC Ltd) is the father of Mark Johnson (Consultancy Firm Co.). |

## View relations

The **Relations** section tab, available on both Company and Contact screens, displays relationships between the current entity and other companies or contacts.

![Relations (Company screen) -screenshot][img2]

[!include[Relations tab columns](../includes/table-relations-tab-columns.md)]

To view more details or to edit, double-click a row to open the **Relation** dialog.

## <a id="add"></a>Add relation

1. Go to the Company or Contact screen where you wish to add a relation.

1. Select the **Relations** section tab.

1. Click **Add** to open the **Relation** dialog.

    ![Relations dialog -screenshot][img1]

1. **Specify the parties:**

    * **Active:** Select a company or contact.
    * **Passive:** Select the other entity involved in the relation.

1. **Choose relationship type:** Select the type of relation, such as "owns," "employed by," or "partner" from the **Relation** list. The available options depend on whether the relationship is between a contact and a company or between two contacts.

    The **Result** field will auto-update to reflect the relationship based on your selections.

1. Add a description (optional): Include additional information if needed.

1. Click **Save** to create the relation.

## <a id="delete"></a>Delete relation

1. Go to the **Relations** section tab on either the Company or Contact screen.

1. Find the relation you want to delete, right-click, and select **Delete**.

1. In the dialog that appears, click **Yes** to confirm.

## Additional tips

* **Dropdown search:** When selecting the active and passive parties, start typing the company or contact's name to quickly search and find it.

* **Relationship types:** Relationship types are defined in Settings and maintenance. Customizing these allows you to better reflect your organization's specific needs.

## Related content

* [Delete items in SuperOffice CRM][2]
* [Group information in section tabs][1]
* [Add items to the General - Relation list][3]
* [Custom field relations][4]

<!-- Referenced links -->
[1]: ../section-tabs/index.md
[2]: deleting-elements.md
[3]: ../../admin/lists/learn/adding-items-to-relation-list.md
[4]: ../../custom-objects/learn/extra-field.md#relation

<!-- Referenced images -->
[img1]: ../../../media/loc/en/company/relation.png
[img2]: ../../../media/loc/en/company/relations-detail.png

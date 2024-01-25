---
uid: help-en-udef
title: User-defined fields explained
description: Introduction to user-defined fields in SuperOffice
author: Bergfrid Dias
so.date: 01.16.2024
so-version: 10
keywords: udef, custom objects, custom fields, user-defined field
so.topic: concept
language: en
so.audience: user
so.audience.tooltip: SuperOffice CRM
---

# User-defined fields

A *user-defined* field (udef) is a custom field that you add to a standard SuperOffice database table. You can extend the following entities:

* Company
* Contact
* Documents
* Follow-up
* Project
* Sale

User-defined fields are managed in Settings and maintenance, in the **Fields** screen. In the application, user-defined fields are visible in the **More** tab of the entity they were added to. For example, a user-defined field on a company is shown on the **More** tab in the Company screen.

> [!NOTE]
> Everyone can **update** the data stored in a user-defined field. Only an administrator can add (or remove) a user-defined field. You need a Development Tools license to customize the layout of the **More** tab and to use page 1 fields.

## <a id="field-types" />Field types

There are 8 types of user-defined fields:

* **Number**: whole number, unlimited number of digits.
* **Short text**: text with a maximum of 39 characters. Specify in the **Text length** field, which is enabled when you choose this option, the maximum number of characters users can type into this field.
* **Long text**: text with a maximum of 199 characters. Specify in the **Text length** field, which is enabled when you choose this option, the maximum number of characters users can type into this field.
* **Date**: date between 01.01.1970 and 19.01.2038.
* **Unlimited date**: any date.
* **Checkbox**: a checkbox.
* **List**: a list box (drop-down). Select a list from the system in the field below.
* **Decimal**: a number with decimals.

## <a id="limit" />Maximum number of fields

The following limitations apply to the number of user-defined fields you can specify in each of the Company, Contact, Project, and Sale tabs.

* **Number**, **Date**, **Check box**, and **List**: Maximum of 60 in all.
* **Short text** and **Unlimited date**: Maximum of 40 in all.
* **Long text**: Maximum of 9 in all.
* **Decimal**: Maximum of 10 in all.

> [!NOTE]
> Four of the user-defined fields in each group must be indexed.

## <a id="index" />Indexed fields

Indexing is good for user experience and performance. The first 4 fields of each data type are reserved for indexes.

You have to mark the checkbox when creating the field to allow it to be indexed. You can mark up to 4 fields in each of the 4 data types (Long, Double, String[40], String[200]) for each entity. For example, you can index 4 numbers and 4 decimals for a contact, however you cannot at the same time also index a date - because all Long index slots are taken by the numbers.

If you choose not to index at all, you are essentially wasting 16 fields! Thus, the max number of custom fields is reduced to 103.

## <a id="page-1" />Page 1 fields

Among the user-defined fields that are displayed in the **More** tabs in SuperOffice, you can choose *three* that will function as page 1 fields (so called because they are displayed on the "first page" in their respective screens).

**Placement:**

* The **Company** tab in the Company screen
* The **Contact** tab in the Contact screen
* The **Project** tab in the Project screen
* The **Sale** tab in the Sale screen
* The **Details** tab in the Document screen

> [!NOTE]
> Page 1 fields require a Development Tools license and are not applicable if you are using another layout via the [Screen designer][8].

## Examples

### User-defined fields for companies

Your company sells software and user support services. The user support department needs to know how many employees and PCs the various customers have. They also need to know what sort of maintenance agreement the customers have and when they expire.

You can then add these fields to the Company screen:

| Field name | Type | Description |
|---|---|---|
| Number of PCs | Number | A number field where you can register the number of PCs. |
| Number of employees | Number | A number field where you can register the number of employees. |
| Maintenance agreement | List | A list of the various types of maintenance agreement you offer. The list must [be created in the Lists screen][3]. |
| The contract expires | Date | A date field where you can register the expiry date for the contract. |
| Application A; Application B; Application C | Checkbox | Three checkboxes where you can check the applications that the customer has purchased. |

> [!NOTE]
> The fields you add are displayed in the **More** tab in the Company screen. To display them on the company card, [specify them as *page 1 fields*][1].

### User-defined fields for sales

When you create a sale, it may be practical to enter the products you have sold and how many.

You can then add these fields to the Sale screen:

| Field name | Type | Description |
|---|---|---|
| Product | Long text | A text field where you can type in the name of the product that was sold. |
| Quantity | Number | A number field where you can register the number of units sold. |

> [!TIP]
> Here, you can also use a list field if you have created a list of the products that you sell.

### User-defined fields for projects

You want the budget for a project to be easily visible to the project members.

You can then add these fields to the Project screen:

| Field name | Type | Description | Remarks |
|---|---|---|---|
| Budget | Decimal | A number field where you can enter a sum. | [Choose for the field to be displayed on page 1][1]. |

## Related content

* [Add user-defined field][2]

<!-- Referenced links -->
[1]: ../admin/edit-udef-layout.md#page-1
[2]: ../admin/add-udef.md
[3]: ../../admin/lists/learn/adding-user-defined-lists.md
[8]: ../../ui/screen-designer/learn/index.md

<!-- Referenced links -->

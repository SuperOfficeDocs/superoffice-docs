---
uid: help-en-udef
title: Fields web
description: Fields web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# User-defined fields

Several sections of SuperOffice CRM, for example, the **Company** screen, contain a separate tab called **More**. Here you can enter your own fields to customize the program to your organization's requirements. These fields are defined in SuperOffice Settings and maintenance.

All companies and organisations have their own requirements with regard to the information they need to register concerning their customers, sales, projects, contracts, and so on. You can enter your own fields for SuperOffice CRM in the **Fields** screen. This way, you can customise the type of information that can be registered concerning companies, contacts, projects, sales, documents and follow-ups.

> [!NOTE]
> You can specify 3 fields that can be displayed on the "first page" in their respective screens or dialogs. See [Select page 1 fields][1].

## Field types

[!include[List of field types](includes/field-types.md)]

## What benefit do I get from the information that I enter in these fields?

* Using the **Find** search function, you can search for the information you register in these fields and make dynamic selections.
    **For example**: If you register the expiry date of the maintenance agreement that you have with customers, you can create a dynamic selection which shows the customers for which the agreement expires in less than one month.

* You can reuse the information from these fields in documents and e-mails using template variables. Each field that you add is given its own unique ID, which can be used in documents to merge customer-specific information.
    **For example**: If you send e-mail to customers which states that the maintenance agreement will expire soon, the template variable for expiry date can be used to set the correct expiry date in the message that is being sent.

## Where will the fields I create be displayed?

* [The More tab (Company)][6]
* [The More tab (Contact)][7]
* [The More tab (Project)][3]
* [The More tab (follow-ups)][4]
* [The More tab (Document)][5]
* The Details tab in the Sale screen

You can specify *page 1 fields*, i.e. fields that will be displayed on the "first page" in their respective screens or dialogs, in the following places:

[!include[List](includes/list-page-1-field-locations.md)]

## Examples

### User-defined fields for companies

Your company sells software and user support services. The user support department needs to know how many employees and PCs the various customers have. They also need to know what sort of maintenance agreement the customers have and when they expire.

You can then add these fields to the **Company** screen:

| Field name | Type | Description |
|---|---|---|
| Number of PCs | Number | A number field in which you can register the number of PCs. |
| Number of employees | Number | A number field in which you can register the number of employees. |
| Maintenance agreement | List | A list of the various types of maintenance agreement you offer. The list must [be created in the Lists screen][2]. |
| The contract expires | Date | A date field in which you can register the expiry date for the contract. |
| Application A; Application B; Application C | Checkbox | Three checkboxes where you can check the applications that the customer has purchased. |

> [!NOTE]
> The fields you add will be displayed in the **More** tab in the **Company** screen. If you want to display them on the company card itself, [you specify them as *page 1 fields*][1].

### User-defined fields for sales

When you create a sale, it may be practical to enter the products you have sold and how many.

You can then add these fields to the **Sale** screen:

| Field name | Type | Description |
|---|---|---|
| Product | Long text | A text field in which you can type in the name of the product that was sold. |
| Quantity | Number | A number field in which you can register the number of units sold. |

> [!TIP]
> Here, you can also use a list field if you have created a list of the products that you sell.

### User-defined fields for projects

You want the budget for a project to be easily visible to the project members.

You can then add these fields to the **Project** screen:

| Field name | Type | Description | Remarks |
| Budget | Decimal | A number field in which you can enter a sum. | Choose for the field to be displayed on page 1 as described in [Select page 1 fields][1]. |

<!-- Referenced links -->
[1]: page-1-fields.md
[2]: ../../settings/lists/adding-user-defined-lists.md
[3]: ../../clients/sales/project/more-tab-project.md
[4]: ../../clients/sales/diary/dialog-for-followups.md
[5]: ../../clients/sales/document/document-dialog.md
[6]: ../../company/create.md#more-tab
[7]: ../../person/create.md#more-tab

<!-- Referenced images -->
---
uid: help-en-fields-web
title: Fields web
description: Fields web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Fields

All companies and organisations have their own requirements with regard to the information they need to register concerning their customers, sales, projects, contracts, and so on. You can enter your own fields for SuperOffice CRM in the **Fields** screen. This way, you can customise the type of information that can be registered concerning companies, contacts, projects, sales, documents and follow-ups.

> [!NOTE]
> You can specify 3 fields that can be displayed on the "first page" in their respective screens or dialogs. See [Select page 1 fields](page_1_fields_web.md).

<!-- Fix reuse ID=a2 -->

* Using the **Find** search function, you can search for the information you register in these fields and make dynamic selections.  
    **For example**: If you register the expiry date of the maintenance agreement that you have with customers, you can create a dynamic selection which shows the customers for which the agreement expires in less than one month.
* You can reuse the information from these fields in documents and e-mails using template variables. Each field that you add is given its own unique ID, which can be used in documents to merge customer-specific information.  
    **For example**: If you send e-mail to customers which states that the maintenance agreement will expire soon, the template variable for expiry date can be used to set the correct expiry date in the message that is being sent.

<!-- Fix reuse ID=a1 -->

* The **More** tab in the **Company** screen
* The **More** tab on the contact card
* The **More** tab in the **Project** screen
* The **Details** tab in the **Sale** screen
* The **More** tab in the dialog for follow-ups
* The **More** tab in the **Document** dialog

You can specify *page 1 fields*, i.e. fields that will be displayed on the "first page" in their respective screens or dialogs, in the following places:

* The **Company** tab in the **Company** screen
* The **Contact** tab on the contact card
* The **Project** tab in the **Project** screen
* The **Sale** tab in the **Sale** screen
* The **Details** tab in the **Document** dialog

## For example: User-defined fields for companies

Your company sells software and user support services. The user support department needs to know how many employees and PCs the various customers have. They also need to know what sort of maintenance agreement the customers have and when they expire.

You can then add these fields to the **Company** screen:

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.348%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>Field name</p></td>
<td><p>Type</p></td>
<td><p>**Description**</p></td>
</tr>
<tr>
<td><p>Number of PCs</p></td>
<td><p>Number</p></td>
<td><p>A number field in which you can register the number of PCs.</p></td>
</tr>
<tr>
<td><p>Number of employees</p></td>
<td><p>Number</p></td>
<td><p>A number field in which you can register the number of employees.</p></td>
</tr>
<tr>
<td><p>Maintenance agreement</p></td>
<td><p>List</p></td>
<td><p>A list of the various types of maintenance agreement you offer. The list must [be created in the Lists screen](../chap08/Adding_user-defined_lists_web.md).</p></td>
</tr>
<tr>
<td><p>The contract expires</p></td>
<td><p>Date</p></td>
<td><p>A date field in which you can register the expiry date for the contract.</p></td>
</tr>
<tr>
<td><p>Application A</p>
<p>Application B</p>
<p>Application C</p></td>
<td><p>Checkbox</p></td>
<td><p>Three checkboxes where you can check the applications that the customer has purchased.</p></td>
</tr>
</tbody>
</table>

> [!NOTE]
> The fields you add will be displayed in the **More** tab in the **Company** screen. If you want to display them on the company card itself, [you specify them as *page 1 fields*](page_1_fields_web.md).

## For example: User-defined fields for sales

When you create a sale, it may be practical to enter the products you have sold and how many.

You can then add these fields to the **Sale** screen:

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:73.345%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>Field name</p></td>
<td><p>Type</p></td>
<td><p>**Description**</p></td>
</tr>
<tr>
<td><p>Product</p></td>
<td><p>Long text</p></td>
<td><p>A text field in which you can type in the name of the product that was sold. > [!TIP]
> Here, you can also use a list field if you have created a list of the products that you sell.</p></td>
</tr>
<tr>
<td><p>Quantity</p></td>
<td><p>Number</p></td>
<td><p>A number field in which you can register the number of units sold.</p></td>
</tr>
</tbody>
</table>

## 

## For example: User-defined fields for projects

You want the budget for a project to be easily visible to the project members.

You can then add these fields to the **Project** screen:

<table>

<tbody>
<tr>
<td><p>Field name</p></td>
<td><p>Type</p></td>
<td><p>**Description**</p></td>
<td><p>**Remarks**</p></td>
</tr>
<tr>
<td><p>Budget</p></td>
<td><p>Decimal</p></td>
<td><p>A number field in which you can enter a sum.</p></td>
<td><p>Choose for the field to be displayed on page 1 as described in [Select page 1 fields](page_1_fields_web.md).</p></td>
</tr>
</tbody>
</table>

---
uid: help-en-email-filter
title: Email filters
description: Email filters
author: SuperOffice RnD
so.date: 12.12.2023
so.version: 10.2.11
keywords: email
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Email filters

An email filter is a tool used to analyze the content of inbound email, and generate a request based on this content.

You can also add advanced rules for handling email from specific senders. Email filters are often used in connection with web forms that the company has published and that generate a fixed format email message that is imported into SuperOffice Service.

## Example related to inbound email from web forms

For example, you can define fixed expressions to extract information that a customer submitted using the form. Based on a defined rule set, data from the form is entered in the customer database. The request generate from the email/form is then placed into a specific category and a request handler is selected. Then the request is closed and the customer receives a customized receipt based on a reply template. In other words, there are many options for automatic handling of inbound email.

* Email received from a web form generally has a default sender address. You can replace this address with the customer's own email address.

* You can compare the customer's phone number with information in the customer database and link the request to the correct customer on this basis.

* You can overwrite address data if there is a change of address.

* You can send a receipt with tailored information if a customer wants more information about a specific product, and assign the request to the right subcategory and request handler.

## Columns in the list of filters

The **Email filters** tab contains a list of existing email filters. This list contains the following columns:

| Column | Description |
|---|---|
| Description | A description of the email filter. |
| Priority | The email filter's priority. Only one filter per email is enabled. If more than one filter contains search criteria that match an inbound email, the highest priority filter is enabled. |
| Email addresses | The addresses of the mailbox the filter applies to. |
| Search string | The search string that the email filter uses. |

## Properties for generated requests

* **Set owner**: If checked, you can select which user will be assigned emails processed by this filter.

* **Set category**: If you check here and select a category, email processed by this filter will end up in the specified category.

* **Request type:** If you check here and select a type, email processed by this filter will be assigned the specified [request type][3]. (Available in pilot only.)

* **Set priority**: If you check here and select a priority, email processed by this filter will be assigned the specified priority.

* **Set access level**: If you check here and select an access level from the list box, email processed by this filter will be assigned the specified access level. If you select **External**, the generated request will be accessible in SuperOffice Customer Centre.

* **Set messages**: If you check here and select a reply template, the request message will be set up in accordance with the selected template, merged with all the fixed expressions that are found. You can use this to present a form, which is sent by email, and is much tidier. This message will replace the original email.

* **Close request**: If checked, the request is closed immediately and assigned the status **Closed**.

* **Ignore From address**: If checked, SuperOffice Service ignores the original sender address. The request will then not be linked to a contact unless other rules in the email filter create a link to a contact.

* **Block email**: If checked, the email is not imported into SuperOffice Service. It is added instead to the list in the **Blocked email** tab.

* **Permanently delete email**: If checked, the email is deleted permanently.

    > [!NOTE]
    > It is not possible to restore emails that have been permanently deleted.

* **Forward to**: If you check here and enter an email address, the email will be forwarded to this address.

* **Include debug information in the message**: If checked, the message will include debug data that you can use to check that the email filter is working correctly.

* **Mark email as bounced**: If checked, email processed by this filter will be marked as bounced. This may be relevant for emails received from postmaster, mailer-daemon, and so on.

## What would you like to do now?

* [Create email filters][1]
* [Delete email filters][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md
[3]: ../../../../request/learn/type/index.md

<!-- Referenced images -->

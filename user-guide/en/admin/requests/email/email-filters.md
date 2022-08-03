---
uid: help-en-admin-listfilters-listmsfilter
title: admin listFilters listMSFilter
description: admin listFilters listMSFilter
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# email filters

An email filter is a tool used to analyse the content of inbound email, and generate a request based on this content. You can also add advanced rules for handling email from specific senders. email filters are often used in connection with web forms which the company has published and which generate a fixed format email message which is imported into SuperOffice Service.

For example, you can define fixed expressions to extract information that a customer has submitted using the form. Based on a defined rule set, data from the form is entered in the customer database. The request generate from the email/form is then placed into a specific category and a request handler is selected. Then the request is closed and the customer receives a customised receipt based on a reply template.In other words, there are many options for automatic handling of inbound email.

Here are some examples related to inbound email from web forms:

* email received from a web form generally has a default sender address. You can replace this address with the customer's own email address.
* You can compare the customer's phone number with information in the customer database and link the request to the correct customer on this basis.
* You can overwrite address data in the event of a change of address.
* You can send a receipt with tailored information if a customer wants more information about a specific product, and assign the request to the right subcategory and request handler.

The **E-mail filters** tab contains a list of existing email filters. This list contains the following columns:

* **Description**: A description of the email filter.
* **Priority**: The email filter's priority. Only one filter per email is enabled. If more than one filter contains search criteria that match an inbound email, the highest priority filter is enabled.
* **E-mail addresses**: The address(es) of the mailbox the filter applies to.
* **Search string**: The search string that the email filter uses.

## What would you like to do now?

* [Create email filters][1]
* [Delete email filters][2]

<!-- Referenced links -->
[1]: create-email-filter.md
[2]: delete-email-filter.md

<!-- Referenced images -->

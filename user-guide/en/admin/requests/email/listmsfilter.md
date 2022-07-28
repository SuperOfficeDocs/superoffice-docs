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

# E-mail filters

An e-mail filter is a tool used to analyse the content of inbound e-mail, and generate a request based on this content. You can also add advanced rules for handling e-mail from specific senders. E-mail filters are often used in connection with web forms which the company has published and which generate a fixed format e-mail message which is imported into SuperOffice Service.

For example, you can define fixed expressions to extract information that a customer has submitted using the form. Based on a defined rule set, data from the form is entered in the customer database. The request generate from the e-mail/form is then placed into a specific category and a request handler is selected. Then the request is closed and the customer receives a customised receipt based on a reply template.In other words, there are many options for automatic handling of inbound e-mail.

Here are some examples related to inbound e-mail from web forms:

* E-mail received from a web form generally has a default sender address. You can replace this address with the customer's own e-mail address.
* You can compare the customer's phone number with information in the customer database and link the request to the correct customer on this basis.
* You can overwrite address data in the event of a change of address.
* You can send a receipt with tailored information if a customer wants more information about a specific product, and assign the request to the right subcategory and request handler.

The **E-mail filters** tab contains a list of existing e-mail filters. This list contains the following columns:

* **Description**: A description of the e-mail filter.
* **Priority**: The e-mail filter's priority. Only one filter per e-mail is enabled. If more than one filter contains search criteria that match an inbound e-mail, the highest priority filter is enabled.
* **E-mail addresses**: The address(es) of the mailbox the filter applies to.
* **Search string**: The search string that the e-mail filter uses.

## What would you like to do now?

* [Create email filters][1]
* [Delete email filters][2]

<!-- Referenced links -->
[1]: listmsfilter.newmsfilter.md
[2]: listmsfilter.deletemsfilter.md

<!-- Referenced images -->

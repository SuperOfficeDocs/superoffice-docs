---
uid: zapier-list-fields
title: Look up lists between Source and SuperOffice CRM
description: Guide for looking up lists
author: Philip Yates
date: 08.09.2023
keywords: Zapier
topic: howto
language: en
client: Zapier
---

# Look up lists between Source and SuperOffice CRM

In SuperOffice, drop-down fields (such as currency) are associated with a list. When defining the action of a Zap, names must match the SuperOffice list values.

## Example: Sale amount and currency

On the **Create a Sale** action, the **Amount** field has a **Currency** field, which you can set using the drop-down list.

![Zapier: currency field -screenshot][img1]

This is great if all your sales have the same currency, but if the currency varies, you must provide the currency name. The name must match the SuperOffice list values, so "GBP" will match, but "British Pounds" will not, since the SuperOffice list contains "GBP".

To provide the name, choose **Use a Custom Value** at the bottom of the list.

![Use a Custom Value -screenshot][img2]

This will add a new field to the form where you can place the currency name.

![Custom Value for Currency ID -screenshot][img3]

SuperOffice will see the string value "USD", note that this is not a currency id (a number), and look up the currency ID in the SuperOffice currency list using the name you provided.

As a result, your sale is tagged with the right currency in SuperOffice.

This works with all drop-down lists in SuperOffice actions, including Owners, Companies, Projects, Contacts, as well drop-down fields such as business, category, type.

![Provide Owner ID for Custom Value -screenshot][img4]

[img1]:media/create-sale.png
[img2]:media/custom-value.png
[img3]:media/currency-name.png
[img4]:media/owner-id.png

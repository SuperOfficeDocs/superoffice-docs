---
uid: zapier-list-fields
title: Look up lists between Source and SuperOffice CRM
description: Guide for looking up lists
keywords: Zapier lists
author: Miguel Lemos
date: 11.05.2025
content_type: howto
category: integration
topic: Zapier
platform: Zapier
language: en
redirect_from: /en/automation/zapier/howto/listsource
---

# Look up lists between Source and SuperOffice CRM

In SuperOffice, drop-down fields (for example, Currency) are linked to predefined lists. When defining an action in a Zap, the selected names must exactly match the corresponding SuperOffice list values.

## Example: Sale amount and currency

In the **Create a Sale** action, the **Amount** field includes a **Currency** field, which can be set using a drop-down list.

![Zapier: currency field -screenshot][img1]

However, if the currency varies between records, a specific currency name must be provided instead. The name must exactly match the value in the SuperOffice currency list — for example, "GBP" will match, but "British Pounds" will not, since the list entry is "GBP".

To provide the name manually, select **Use a Custom Value** at the bottom of the list.

![Use a Custom Value -screenshot][img2]

Then, enter a currency name manually or link it to an external data source, such as a column in an Excel sheet.

![Custom Value for Currency ID -screenshot][img3]

When the Zap runs, SuperOffice detects that the value "USD" is not a numeric currency ID. It then looks up the corresponding currency ID in the SuperOffice currency list using the provided name.

As a result, the sale is created with the correct currency in SuperOffice.

This lookup behavior applies to all drop-down lists in SuperOffice actions, including: Owners, Companies, Projects, Contacts, as well as category-based fields such as Business, Category, and Type.

[img1]: media/create-sale-amount-currency-fields.png
[img2]: media/currency-pick-custom-value.png
[img3]: media/currency-custom-value.png
---
uid: zapier-crm-tips-gdpr
title: Look up lists between Source and SuperOffice CRM
description: Guide for looking up lists
author: Philip Yates
so.date: 8.9.2023
keywords: Zapier
so.topic: howto
language: en
so.client: Zapier
---

# Look up lists between Source and SuperOffice CRM

When you select SuperOffice CRM as an action in your Zap, there are many list fields in SuperOffice.

For example, on the Create a Sale action the amount field has a currency field, which you can choose to set using the drop-down list:

![Currency Field][img1]

This is great if all your sales have the same currency, but if the currency varies, then you need to provide the currency name. The name must match the SuperOffice list values, so “GBP” will match, but “British Pounds” will not, since the SuperOffice list contains “GBP”.

To provide the name, you need to choose “Use a Custom Value” at the bottom of the list.

![Use a Custon Value][img2]

This will add a new field to the form where you can place the currency name.

![Custom Value for Currency ID][img3]

SuperOffice will see the string value “USD”, note that this is not a currency id (a number), and look up the currency id in the SuperOffice currency list using the name you provided.

The result is that your sale will get tagged with the right currency in SuperOffice.

This works with all drop-down lists in SuperOffice actions, including Owners, Companies, Projects, Contacts, as well as such drop-down fields as business, category, type, and so on.

![Provide Owner ID for Custom Value][img4]

[img1]:media/create-sale.png
[img2]:media/custom-value.png
[img3]:media/currency-name.png
[img4]:media/owner-id.png
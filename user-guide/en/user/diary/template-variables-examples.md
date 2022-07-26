---
uid: help-en-template-variables-examples
title: Template variables examples
description: Template variables examples
author: SuperOffice RnD
so.date: 06.29.2022
keywords: CRM
so.topic: help
language: en
---

# Template variables - examples

In this topic we will show you some examples of how to use template variables. Template variables are used to insert data from SuperOffice into e-mails, quotes, meeting notifications, document templates etc. You can use template variables to personalise messages to customers and set up complex quotes.

> [!NOTE]
> Most of the examples below are available in the default templates in SuperOffice.

## How to personalise an e-mail using template variables

Instead of this text:

"Dear Customer. Would you like to know more about how our product can help your company win new customers? Please call us."

you can send this one:

"Hi Chris. Would you like to know more about how our product can help Car Care Ltd win new customers? Please call Ryan Webster at SuperShop."

The text you enter will look like this:

"Hi **{atfn}**. Would you like to know more about how our product can help **{name}** win new customers? Please call **{cont}** at **{onam}**."

## Signatures

This is an example of a signature that can be used by anyone in your company.

```text
Best Regards,
{auth}
{atit}
{onam}
Address: {opad}, {ozip} {ocit}
Phone: {audp}
Mobile phone: {aupc}
{auem}
{owww} | Best Regards,
John Jones
Sales Manager
SuperShop
Address: High Street 12, 223-344, Springfield
Phone: 22334455
Mobile phone: 99887766
jj@supershop.com
supershop.com
```

## Meeting minutes (header)

This is an example of a header in a meeting minutes (document or e-mail).

```text
{head}
Date / Location: {sdat}, {city}
Present: {attn} ({name}), {auth} ({onam})
Not attending:
Meeting secretary: {auth} ({auem})
Summer sales campaign - planning
Date / Location: 15.12.2019, London
Present: Sara Miller (Liberty Ltd.), John Jones (SuperShop)
Not attending:
Meeting secretary: John Jones (jj@supershop.com)
```

## Order Confirmation (header)

Template variables for quotes and order confirmations can be used within the context of a quote.

```text
Order date: {sdat}
Order number: {qnum}
Delivery terms: {qdev}
Payment terms: {qpev}
Your PO number: {qpon}
Our contact: {cont}
Order date: 15.12.2019
Order number: 550012
Delivery terms: Delivery included
Payment terms: 15 days
Your PO number: 70000882
Our contact: John Jones
```

## Related topics

* [Template variables][1]

<!-- Referenced links -->
[1]: template-variables.md

<!-- Referenced images -->

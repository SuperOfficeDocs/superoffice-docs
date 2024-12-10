---
uid: help-en-template-variables
title: Template variables
description: With template variables you can personalize and automate the input of customer data.
keywords: document, template, variable
author: Bergfrid Dias
date: 12.10.2024
version: 10.3
topic: concept
language: en
---

# Template variables

Template variables are used to insert data from SuperOffice into emails, quotes, meeting notifications, document templates, and so on. You can use template variables to personalize and automate the input of customer data (or data from contact, sale and other) into your content and set up complex quotes

## Example: How to personalize an email using template variables

Instead of this text:

"Dear Customer. Would you like to know more about how our product can help your company win new customers? Please call us."

you can send this one:

"Hi Chris. Would you like to know more about how our product can help Car Care Ltd win new customers? Please call Ryan Webster at SuperShop."

The text you enter will look like this:

"Hi **{atfn}**. Would you like to know more about how our product can help **{name}** win new customers? Please call **{cont}** at **{onam}**."

## How to use template variables

* The whole variable must be formatted using the same font and font size, and you must only use lowercase letters. However, if the **Use case-sensitive template variables** preference is enabled, the template variable can be formatted.

* You can mix normal text and variables in the template document: For example, you can enter template variables that retrieve a company's name and address, type in standard text for the body of the letter and enter the variable for our contact to conclude the letter.

* You can also use fill characters in the template document (see below).

* The date and time in template variables are controlled by the PC's system clock.

* In documents of file type .doc in Office 2003 and older, you must use angled brackets – &lt; &gt; – around variables instead of curly brackets – { } –.

### Example: meeting minutes (header)

This is an example of a header in a meeting minutes (document or email).

**Template:**

```text
{head}
Date / Location: {sdat}, {city}
Present: {attn} ({name}), {auth} ({onam})
Not attending:
Meeting secretary: {auth} ({auem})
```

**Result:**

```text
Summer sales campaign - planning
Date / Location: 15.12.2019, London
Present: Sara Miller (Liberty Ltd.), John Jones (SuperShop)
Not attending:
Meeting secretary: John Jones (jj@supershop.com)
```

## Smart variables from the Company screen

Address variables from the Company screen are so called "smart" template variables. This means that the system selects address data in a specific order:

1. If the **Use as postal address** option is active for a contact in the company, the contact's address data is used.
2. If the above option is not active, the company's address data is used.
3. If the company's postal address is empty, the company street address is used.

## Quote template variables

When using quote and products in SuperOffice, you need to set up quote templates. The templates for quote documents, quote details, and order confirmations differ from ordinary document templates, as they use "mergefields" in addition to standard template variables.

### Example: order confirmation (header)

Template variables for quotes and order confirmations can be used within the context of a quote.

**Template:**

```text
Order date: {sdat}
Order number: {qnum}
Delivery terms: {qdev}
Payment terms: {qpev}
Your PO number: {qpon}
Our contact: {cont}
```

**Result:**

```text
Order date: 15.12.2019
Order number: 550012
Delivery terms: Delivery included
Payment terms: 15 days
Your PO number: 70000882
Our contact: John Jones
```

## Service and Marketing template variables

When generating email templates for requests and mailings (and message templates) in Marketing, you can personalize the email or mailing with template variables. Those variables are slightly different from the ones used in documents.

## Reference

The reference is grouped by area. [Go to reference][1]

<!-- Referenced links -->
[1]: ../../../document/templates/variables/index.md

<!-- Referenced images -->

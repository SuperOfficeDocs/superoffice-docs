---
uid: help-en-template-variables
title: Template variables
description: With template variables you can personalise and automate the input of customer data
author: SuperOffice RnD
so.date: 02.23.2023
keywords: document, template, variable
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Template variables

Template variables are used to insert data from SuperOffice into emails, quotes, meeting notifications, document templates, and so on. You can use template variables to personalize and automate the input of customer data (or data from contact, sale and other) into your content and set up complex quotes

> [!TIP]
> See all the different [template variables][2] you have for the **company card**.

## Examples

Here we show you some examples of how to use template variables. Many of the examples use the default templates in SuperOffice.

### How to personalize an email using template variables

Instead of this text:

"Dear Customer. Would you like to know more about how our product can help your company win new customers? Please call us."

you can send this one:

"Hi Chris. Would you like to know more about how our product can help Car Care Ltd win new customers? Please call Ryan Webster at SuperShop."

The text you enter will look like this:

"Hi **{atfn}**. Would you like to know more about how our product can help **{name}** win new customers? Please call **{cont}** at **{onam}**."

### Signatures

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

### Meeting minutes (header)

This is an example of a header in a meeting minutes (document or email).

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

### Order Confirmation (header)

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

## How to use template variables

* In documents of file type .doc in Office 2003 and older, you must use angled brackets – &lt; &gt; – around variables instead of curly brackets – { } –.
* The whole variable must be formatted using the same font and font size, and you must only use lowercase letters. However, if the **Use case-sensitive template variables** preference is enabled, the template variable can be formatted.
* You can mix normal text and variables in the template document: For example, you can enter template variables that retrieve a company's name and address, type in standard text for the body of the letter and enter the variable for our contact to conclude the letter.
* You can also use fill characters in the template document (see below).
* The date and time in template variables are controlled by the PC's system clock.

> [!TIP]
> After you create a new template document, you must add it using the **Lists** screen in Settings and maintenance to use it in SuperOffice CRM.

## Fill characters

Sometimes you should use fill characters in templates so that a field's contents or formatting will not be changed or deleted if the content of a field is shorter than the length specified by the field variable.

Use the variable padd# to specify the fill character to use. Replace the \# character with the ANSI code of the character you wish to use as a fill character. You will usually find a list of ANSI codes in the manual for the program you are creating templates for.

SuperOffice CRM has default values for fill characters for the most commonly used word-processing and spreadsheet applications. A soft hyphen is usually used because it does not display on the screen or a printout. For applications where the set-up is unknown, SuperOffice CRM uses {padd32}, which is the ANSI code for a space.

> [!TIP]
> Microsoft Word uses {padd31} as a fill character.

If you do not want to use fill characters, use the template variable {padd0}.

> [!NOTE]
> This only works for document formats that are sequential, for example, Notepad and AmiPro templates without graphics.

When you use {padd0} you can write all the template variables without blank characters between the name of the template variable and the closing variable delimiter (}).

## Variables from the company card

> [!NOTE]
> Address variables from the company card are so called "smart" template variables. This means that the system selects address data in a specific order. The variables in **bold text** below (such as **addr** and **city**) are smart template variables.

When you use address variables from the company card, the system will select address data in the following order:

1. If the **Use as postal address** option is active for a contact in the company, the contact's address data is used.
2. If the above option is not active, the company's address data is used.
3. If the company's postal address is empty, the company street address is used.

## Quote template variables

When using quote and products in SuperOffice, you need to set up quote templates and the variables is found in a pdf that also shows how to work with quote templates.

The templates for quote documents, quote details and order confirmations differ from ordinary document templates, as they use "mergefields" in addition to standard template variables.

## Service and Marketing template variables

When generating email templates for requests and mailings (and message templates) in Marketing, you can personalize the email or mailing with template variables. Those variables are slightly different from the ones used in documents.

## Reference

The reference is grouped by area. [Go to reference][1]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[2]:https://docs.superoffice.com/en/document/templates/variables/from-company-card.html

<!-- Referenced images -->

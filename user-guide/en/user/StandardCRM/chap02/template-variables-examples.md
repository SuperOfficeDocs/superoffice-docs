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

<table style=" vertical-align:top; margin-top:5px; width:100%; max-width:79.843%;" data-cellspacing="0">

<tbody>
<tr>
<td><p>Best Regards,</p>
<p>{auth}</p>
<p>{atit}</p>
<p>{onam}</p>
<p>Address: {opad}, {ozip} {ocit}</p>
<p>Phone: {audp}</p>
<p>Mobile phone: {aupc}</p>
<p>{auem}</p>
<p>{owww}</p></td>
<td><p>Best Regards,</p>
<p>John Jones</p>
<p>Sales Manager</p>
<p>SuperShop</p>
<p>Address: High Street 12, 223-344, Springfield</p>
<p>Phone: 22334455</p>
<p>Mobile phone: 99887766</p>
<p>jj@supershop.com</p>
<p>supershop.com</p></td>
</tr>
</tbody>
</table>

## Meeting minutes (header)

This is an example of a header in a meeting minutes (document or e-mail).

<table>

<tbody>
<tr>
<td><p>{head}</p>
<p>Date / Location: {sdat}, {city}</p>
<p>Present: {attn} ({name}), {auth} ({onam})</p>
<p>Not attending:</p>
<p>Meeting secretary: {auth} ({auem})</p></td>
<td><p>Summer sales campaign - planning</p>
<p>Date / Location: 15.12.2019, London</p>
<p>Present: Sara Miller (Liberty Ltd.), John Jones (SuperShop)</p>
<p>Not attending:</p>
<p>Meeting secretary: John Jones (jj@supershop.com)</p></td>
</tr>
</tbody>
</table>

## Order Confirmation (header)

Template variables for quotes and order confirmations can be used within the context of a quote.

<table>

<tbody>
<tr>
<td><p>Order date: {sdat}</p>
<p>Order number: {qnum}</p>
<p>Delivery terms: {qdev}</p>
<p>Payment terms: {qpev}</p>
<p>Your PO number: {qpon}</p>
<p>Our contact: {cont}</p></td>
<td><p>Order date: 15.12.2019</p>
<p>Order number: 550012</p>
<p>Delivery terms: Delivery included</p>
<p>Payment terms: 15 days</p>
<p>Your PO number: 70000882</p>
<p>Our contact: John Jones</p></td>
</tr>
</tbody>
</table>

## Related topics

[Template variables](Template_variables.md)

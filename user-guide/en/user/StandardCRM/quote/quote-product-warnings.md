---
uid: help-en-quote-product-warnings
title: quote product warnings
description: quote product warnings
author: SuperOffice RnD
so.date: 07.04.2022
keywords: CRM
so.topic: help
language: en
---

# Deal with warnings and notices when adding products to a quote

In SuperOffice Settings and maintenance, different rules can be defined for what is allowed and not allowed when you add products to a quote. Depending on how these rules are defined, various icons/warnings may be displayed when you add products to a quote. In some cases, the quote must be approved before sending (see [Approve quote before sending](quote-approve.md)).

> [!NOTE]
> Products are added to and saved in a quote even if warnings and other messages are displayed, but you cannot send the quote while it contains errors and warnings. You must either correct the error or get the quote approved.

<table>

<tbody>
<tr>
<td><p>**Icon**</p></td>
<td><p>**Explanation**</p></td>
<td><p>Solution</p></td>
</tr>
<tr>
<td><p>![icon](../media/Quote-Status-OK.png)</p></td>
<td><p>OK</p></td>
<td><p>-</p></td>
</tr>
<tr>
<td><p>![icon](../media/Quote-Status-OKWithInfo.png)</p></td>
<td><p>OK with information</p></td>
<td><p>A message is displayed for the quote, but the quote can be sent as it is.</p></td>
</tr>
<tr>
<td><p>![icon](../media/Quote-Status-NeedsApproval.png)</p></td>
<td><p>Warning: Needs Approval</p></td>
<td><p>The quote must be approved before it can be sent. See [Approve quote before sending](quote-approve.md).</p></td>
</tr>
<tr>
<td><p>![icon](../media/Quote-Status-Error.png)</p></td>
<td><p>Error</p></td>
<td><p>The error must be corrected before the quote can be sent.</p></td>
</tr>
</tbody>
</table>

A message is also displayed to explain the cause of the error.

<!-- Fix reuse ID=a1 -->

* In the **Add/Edit product** dialog
* In the **Edit quote** dialog
* On product lines in the **Quote** section tab and the **Products** (and alternatives) tab in a quote

<!-- Fix reuse ID=a2 -->

Warnings and messages may be due to, for example:

* Products not in the range
* Inactive price lists
* Product price is below minimum price or cost price
* Total price is zero or negative
* Total discount is too high
* Total earnings are too low

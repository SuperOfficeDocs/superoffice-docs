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

| Icon | Explanation | Solution |
|:-:|---|---|
| ![icon](../media/Quote-Status-OK.png) | OK | - |
| ![icon](../media/Quote-Status-OKWithInfo.png) | OK with information | A message is displayed for the quote, but the quote can be sent as it is. |
| ![icon](../media/Quote-Status-NeedsApproval.png) | Warning: Needs Approval | The quote must be approved before it can be sent. See [Approve quote before sending](quote-approve.md). |
| ![icon](../media/Quote-Status-Error.png) | Error | The error must be corrected before the quote can be sent. |

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

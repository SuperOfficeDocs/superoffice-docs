---
uid: help-en-mergefield-ref
title: Merge field reference
description: Merge field reference
keywords: merge field
author: Bergfrid Dias
date: 07.31.2024
version: 10.3
topic: reference
language: en
---

# Merge field reference

> [!NOTE]
> Numbers, dates, and time are [culture-sensitive][2].
>
> If documents are stored in Google Drive, merge fields are not supported.

## VAT

When you want to correctly calculate VAT you must first subtract ALL discounts, including alternative discount (order discount). This must be done for each quoteline (product).

We call this the "Total price with alternative discount".

We multiply the "Total price with alternative discount" with the VAT (-Percentage). The resulting number we call **VATAmount**.

These values are summed up into the alternative's VATAmount field.

Finally, the alternatives TotalPrice and the alternatives VATAmount are then added together into the field we call **TotalPriceIncVAT**.

<!-- Referenced links -->
[2]: ../learn/quote-templates.md#culture

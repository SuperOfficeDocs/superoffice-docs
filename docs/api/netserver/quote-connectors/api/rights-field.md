---
title: rights_field
description: Quote connector Rights field
author: {github-id}             # Your GitHub alias.
keywords: quote
so.topic: concept         
so.date:
---

# Rights field

**Specification:** "Field1=Right,Reason&Field2=Right,Reason"

## Right

[!include[ALT](./includes/rights.md)]

The rights are mutually exclusive; a field can only have one of these rights.

## Field

The fields will mostly be from the `Quoteline` table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on.

## Reason

The reason is a description that will be used on the field (and label) as a tooltip to explain to the user why this field on this product is different. You don’t have to insert anything here, but a SuperOffice user will expect this.

You cannot use the sign ‘&’ in the description.

The reason will only work when the right is R (read-only).

## Example

"QuoteLine.Image=N&QuoteLine.UnitCost=R,This product has a fixed cost.&QuoteLine.Description=W&QuoteLine.VAT=M"

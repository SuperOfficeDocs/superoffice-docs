---
title: Rights field
uid: quote_connector_rights_field
description: Quote connector Rights field
author: SuperOffice Product and Engineering
keywords: quote
content_type: concept         
date:
redirect_from: /en/api/netserver/plugins/quote-connectors/api/rights-field
---

# Rights field

**Specification:** "Field1=Right,Reason&Field2=Right,Reason"

## Right

[!include[ALT](./includes/rights.md)]

The rights are mutually exclusive; a field can only have one of these rights: R, W, or M.

## Field

The fields will mostly be from the `Quoteline` table, but some added fields that are conceptually part of the quoteline, like Image will also be possible to set rights on.

You do not need to include the table name.

`UnitListPrice` and `QuoteLine.UnitListPrice` are equivalent.

## Reason

The reason is a description that will be used on the field (and label) as a tooltip to explain to the user why this field on this product is different. You don’t have to insert anything here, but a SuperOffice user will expect this.

You cannot use the sign ‘&’ in the description.

The reason will only work when the right is R (read-only).

## Example

"QuoteLine.Image=N&UnitCost=R,This product has a fixed cost.&Description=W&QuoteLine.VAT=M"

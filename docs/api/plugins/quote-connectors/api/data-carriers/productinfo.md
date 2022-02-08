---
title: ProductInfo
uid: quote_connector_carrier_productinfo
description: ERP Quote Connector Interface data carrier - ProductInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# ProductInfo

A product is a thing or service that can be sold or leased to a customer.

The fields that will be copied to the QuoteLines are marked in grey.

The ERPProductKey should be **uniquely identifiable**. So, if you have an ERP system with products that have many prices, you might want to concatenate the product ID and the price id into the Product’s ERPKey to uniquely identify the entity. This way you can decompose the key and look up the information when you need it.

## string ERPProductKey

Reference/foreign key to the product in the product supplier system, if it exists there.

## string ERPPricelistKey

Foreign key to the price list that this product is a part of.

## bool InAssortement

True for products that should currently be offered, false when the product is discontinued, and should not ordinarily be offered.

When false the product no longer appears in search results.

## decimal InStock

Negative numbers will be interpreted as how many are ordered. Might not be available.

Requires the "Provide-Stock-data" capability, and that the ERP system is available.

## string Name

The name to use in the user interface

## string Description

The description to use, with potentially several lines.

Will be used as tool-tip to use in the list user interface too.

## string Code

The product code/article number in the product supplier system.

## string QuantityUnit

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡 , دونم or whatever); Connector handles conversion relative to PriceUnit if they are different.

## string PriceUnit

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡 , دونم or whatever); read-only for lines that originate in defined products.

## string ItemNumber

Line item number, NOR: «Postnummer». Specific numbers from some hierarchy, for example, "1.4.3.2P". Typically used to sort the items in the quote by some standard way.

## string Url

URL to product information web page

## string ERPProductCategoryKey

Either a list ID to an ID from a connector-provided list or, if the connection doesn’t support lists, a text with the actual product category.

## string ERPProductFamilyKey

Either a list ID to an ID from a connector-provided list or, if the connection doesn't support lists, a text with the actual product family.

## string ERPProductTypeKey

Either a list ID to an ID from a connector-provided list or, if the connection doesn’t support lists, a text with the actual product type.

## string Supplier

Name of the supplier of the product

## string SupplierCode

Suppliers part code/number or another key-like field

## string Thumbnail

The thumbnail of the product, if it exists. Base64 encoded string or a valid URI that resolves to an image.

Requires the "Provide-Thumbnail" capability.

## string VATInfo

A field for putting VATInfo you need to show in the final quote document, like the VAT type that is used.

Not used in any business logic in SuperOffice; available to document templates.

## string VAT

Tax/VAT if available from the ERP system.

Could be either the percentage or the actual value.

This is just to help out the layout of the quote in a document, but SuperOffice will not try to calculate this value.

## Decimal UnitCost

The cost price.

Might not be given, use Decimal.MinValue to signal this.

## Decimal UnitMinimumPrice

The minimum price this salesman can offer to his customer. This might be cost price if there is no policy.

Might not be given, use Decimal.MinValue to signal this.

## decimal UnitListPrice

(Basic Price, normal price, standard price.)

This is the basic price from which the discount is computed from.

The ListPrice will stay the same even when a larger amount is ordered.

## ProductExtraDataFieldInfo[] ExtraData

Extra data (fields with labels). Shall be shown in the quoteline dialog.

Additional info that the ERP system would like to store and show in the user interface.

Information placed here is shown in the GUI if the "provide-extra-data" capability is true.

Different products can have different fields.

It will not be possible to directly put info here into the quote document.

BTW, this will be stored in the SuperOffice database as an XML field, like this:

```XML
<Fields>
  <Field Name="Weight" Type="String"><![CDATA[[F:16.6] tons]]></Field>
  <Field Name="Height" Type="String"><![CDATA[ [F:44.0]cm]]></Field>
  <Field Name="Arms" Type="String"><![CDATA[ [I:2]]]></Field>
  <Field Name="Certification" Type="String"><![CDATA[AB-ICE]]></Field>
  <Field Name="Weight" Type="String"><![CDATA40°C]]></Field>
  <Field Name="Security info" Type="Url"><![CDATA[http://www.armystudyguide.com/content/army_board_study_guide_topics/hand_grenades/throwing-of-hand-grenades.shtml]]></Field>
   <Field Name="Security image"><![CDATA[http://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MK2_grenade_DoD.jpg/220px-MK2_grenade_DoD.jpg]]></Field>
</Fields>
```

## string Rights

Field1=right&Field2=right, etc. of any fields that have non-standard field access rights.

[!include[ALT](../includes/rights.md)]

The fields will mostly be from the `Quoteline` table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on.

See [Rights field][1] for more information

Will be used by SuperOffice to control the user interface when showing the record.

## string Rule

The names of one or more calculation rules that are in effect for this line, comma-separated case-insensitive.

Will NOT be used by SuperOffice.

## string ExtraField1

[!include[ALT](./includes/product-extrafield.md)]

## string ExtraField2

[!include[ALT](./includes/product-extrafield.md)]

## string ExtraField3

[!include[ALT](./includes/product-extrafield.md)]

## string ExtraField4

[!include[ALT](./includes/product-extrafield.md)]

## string ExtraField5

[!include[ALT](./includes/product-extrafield.md)]

<!-- Referenced links -->
[1]: ../rights-field.md

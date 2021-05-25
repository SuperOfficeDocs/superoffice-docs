---
title: QuoteLineInfo
uid: quote_connector_carrier_quotelineinfo
description:  ERP Quote Connector Interface data carrier - QuoteLineInfo
so.date:
keywords: quote
so.topic: reference
---

# QuoteLineInfo

Quote Line archive - list of quote lines in an alternative.

![29][img1]

Quote Line dialog - details of one quote line in an alternative.

![30][img2]

QuoteLines are mainly information copied from the Products provider. Products information is sometimes edited by the user before being included in the quote, so most information is duplicated from Product rather than referenced directly.

See also: [discount][1]

## int QuoteLineId

Primary key in CRM database.

## string ERPQuoteLineKey

The foreign key to the quoteline in ERP system (if it has such a representation).

## int QuoteAlternativeId

The alternative this line is part of, the conceptual Parent in CRM database.

## s tring ERPProductKey

Foreign key of product this line is based on.

Can be blank since the QuoteLine doesn’t have to be connected to a product.

## string ERPPriceListKey

Foreign key to the price list that this quoteline is a part of.

Can be blank since the QuoteLine doesn’t have to be connected to a product.

## QuoteStatus Status

If there was a problem with for instance calculation, this field is set to warning or error.

Typically shown as an icon. QuoteStatus is an enum with statuses: OK, OKWithInfo, Warning, Error.

## string Reason

If QuoteStatus is not OK, then this field contains a localized explanation that the user can be shown.

## double Quantity

How many units; this is a decimal field since you might want to offer fractional units (2.5kg, or 0.5PC).

## double DeliveredQuantity

How many units have been delivered or updated by the ERP system.

## int Rank

QuoteLines can be re-ordered, so we must track the ordering.

## string Name

The name of the product.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string Description

A longer description for the product.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string Code

A value the salesmen use to quickly find the correct product.
Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string QuantityUnit

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡 , دونم or whatever); Connector handles conversion relative to PriceUnit if they are different.

## string PriceUnit

What is the unit (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡 , دونم or whatever); read-only for lines that originate in defined products.

## string ItemNumber

No: «Postnummer». Specific numbers from some hierarchy, for instance "1.4.3.2".

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string Url

A URL to the product info. Can be empty.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string  ProductCategoryKey

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string  ProductFamilyKey

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string  ProductTypeKey

Either a List id to an id from a connector provided list, or, if the connection doesn't support lists, a text.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string SupplierCode

The suppliers' code or part number for this product.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string Supplier

The name of the supplier.

Is stored here if the user changes the value from the product in the pricelist, or just enters a QuoteLine without a product link.

## string Thumbnail

The thumbnail of the product, if it exists.

Base64 encoded string or a valid URI that resolves to an image.

## string VatInfo

Tax/VAT information.

Extra info about VAT that the connector might insert, and the users might want to specify on the quote.

This is just to help out the layout of the quote in a document.

## double VAT

Tax/VAT if available from ERP system; this field is not used in any business logic in SuperOffice.

This is just to help out the layout of the quote in a document, but SuperOffice will not try to calculate this value.

## double UnitCost

The cost price per unit for this product. May be filled in by connector if it has the Provide-Cost capability.

## double  UnitMinimumPrice

The minimum price this line can be sold for (to limit discounting). Will come from the connector. List price per unit must exceed the minimum price per unit.

## double UnitListPrice

The standard list price; as given by ERP Connector, OR overridden by user

## ProductExtraDataFieldInfo[] ExtraInfo

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
  <Field Name="Security info" Type="Url" ><![CDATA[http://www.armystudyguide.com/content/army_board_study_guide_topics/hand_grenades/throwing-of-hand-grenades.shtml]]></Field>
   <Field Name="Security image"><![CDATA[http://upload.wikimedia.org/wikipedia/commons/thumb/8/80/MK2_grenade_DoD.jpg/220px-MK2_grenade_DoD.jpg]]></Field>
</Fields>
```

## string Rights

Field1=right&Field2=right, etc. of any fields that have non-standard field access rights.

[!include[ALT](../includes/rights.md)]

The fields will mostly be from the Quoteline table, but some added fields that are conceptually part of the quoteline, like Image will also be possibly to set rights on.

See Rights field for more information

Will be used by SuperOffice to control the user interface when showing the record.

## string Rule

The names of one or more calculation rules that are in effect for this line, comma-separated case-insensitive.

Will NOT be used by SuperOffice.

## string ExtraField1

[!include[ALT](./includes/quote-extrafield.md)]

## string ExtraField2

[!include[ALT](./includes/quote-extrafield.md)]

## string ExtraField3

[!include[ALT](./includes/quote-extrafield.md)]

## string ExtraField4

[!include[ALT](./includes/quote-extrafield.md)]

## string ExtraField5

[!include[ALT](./includes/quote-extrafield.md)]

## double ERPDiscountAmount

The discount the system calculates based on the customer, quantity, or whatever.

Can be overridden by the salesman in the field `DiscountPercent` or `DiscountAmount`.

If `UserValueOverride` is set to *None* then the value is copied to `DiscountAmount`.

Both fields `ERPDiscountPercent` and `ERPDiscountAmount` will be filled out.

## double ERPDiscountPercent

The discount the system calculates based on the customer, quantity, or whatever.

Can be overridden by the salesman in the field `DiscountPercent` or `DiscountAmount`.

Both fields `ERPDiscountPercent` and `ERPDiscountAmount` will be filled out.

If `UserValueOverride` is set to *None* then the value is copied to `DiscountPercent`.

The Percentage is given in percent form. For example, ‘12%’ is represented as ‘12’.

## double DiscountAmount

The discount for the line, in whatever currency the sale is in.

Both ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last.

* If this field is filled out by the user, it overrides any discount suggested by the connector.
* If the user has not filled this in, the system will copy the ERP discount amount to this field.

## double DiscountPercent

The discount for the line, in percent.

Both ‘DiscountPercent’ and ‘DiscountAmount’ shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last.

* If this field is filled out by the user, it overrides any discount suggested by the connector.
* If the user has not filled this in, the system will copy the ERP discount amount to this field.

The Percentage is given in percent form, i.e. ‘12%’ is represented as ‘12’.

## ValueOverrideInfo UserValueOverride

Has the pre-calculated (from ERP) price information been overridden, and how.

If the user has filled out the discountpercentage field, then the UserValueOverride field is set to OverridePercent.

(The DiscountAmount, EarningPercent, EarningAmount, and TotalPrice fields are calculated based on the DiscountPercent.)

## double EarningAmount

The earning, in whatever currency the sale is in.

Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last.

## double EarningPercent

The earning, in percent.

Both ‘EarningAmount and ‘EarningPercent shall be filled out, but the UserValueOverride field must be set to the field the user actually changed last.

The Percentage is given in percent form, i.e. ‘12%’ is represented as ‘12’.

## double SubTotal

(UnitListPrice * Quantity)

Calculated by the ERPconnector

## double TotalPrice

TotalPrice  = SubTotal - DiscountAmount
or
TotalPrice = (UnitCost * Quantity) + EarningAmount

, according to what the user changed last.

## bool IsIncluded

Not yet implemented: `IsNotAnOption`

If true, will be added to the total price.

Shown as a checkbox on the quote line.

Not in V1

## bool IsGroupHeading

Not yet implemented:

Indicates that the line is a Group Heading.

The name will be used as Label.

Totalprice will reflect the sum of all totalprices in the quotelines connected to the group.

The rank shall be ascending thru the whole QuoteAlternative, disregarding any groups

Not in V1

## int ParentQuoteLine

Not yet implemented:

If this quoteLine is a part of a group heading or a Package, this field will have that quoteline’s ID.

Not in V1

<!-- Referenced links -->
[1]: ../../discounts.md

<!-- Referenced images -->
[img1]: media/image029.jpg
[img2]: media/image030.jpg
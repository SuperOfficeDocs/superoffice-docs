---
title: ProductExtraDataFieldInfo
uid: quote_connector_carrier_productextradatafieldinfo
description: ERP Quote Connector Interface data carrier - ProductExtraDataFieldInfo
author: {github-id}
so.date:
keywords: quote
so.topic: reference
---

# ProductExtraDataFieldInfo

A way to show some simple extra data on a product, typically to help the user to identify the correct product. Basically a bucket of additional info that the ERP system would like to store and show in the user interface. Information placed here is shown in the GUI if the "provide-extra-data" capability is true.

## string FieldName

Label for the field

## string FieldValue

Value for the field

## ExtraDataFieldTypeInfo

String, image, url.

How the value should be interpreted.

### Culture

To ensure that values in the `value` field are correctly displayed according to the user’s culture setup, we have a little system for making this work correctly. You just wrap the values in \[\] brackets with a format specifier, like this:

| Valuetype | Symbol | Comment | Example |
|---|---|---|---|
| Date | D | Use [D:mm/dd/yyyy] | [D:01/01/2009] |
| DateTime | DT | Use [DT:MM/DD/YYYY] | DT:00:00:00.0000000]
| double | F | | Use period (.) as decimal separator | [F:123.45] |
| Integer | I | | [I:123] |
| Money | M | Use period (.) as decimal separator | [M:123.98] |

This means that you can show several values in a field, like this:

* *"Between \[D:12/01/2012\] and \[D:12/25/2012\] it is a \[F:99.5\]% chance of meeting a Santa Clause."*
* *"Should be used in temperatures between \[F:-30.0\]°C  and \[F:50.0\] °C."*

For example, with a Norwegian PC setup, the above will translate into the following:

* *"Between 01.12.2012 and 25.12.2012 it is a 99,5% chance of meeting a Santa Clause."*
* *"Should be used in temperatures between 30,0°C  and 50,0 °C."*

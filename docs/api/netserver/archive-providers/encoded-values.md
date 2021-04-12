---
# Mandatory fields.
title: encoded_values       # (Required)
description: Encoded values # (Required) Important for SEO.
author: Tony Yates
so.date: 11.17.2017
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Encoded values

With core NetServer, the archive row column data contains a `RawValue` property of type `Object`, and can safely be cast to the appropriate type.

Using NetServer web services, it depends on whether you are using SuperOffice proxies or not. If you are, the `RawValue` property contains the column value. If not, only the `DisplayValue` exists.

Except for string column values, `DisplayValue` always contains an encoded string that represents the column values. We recommend you use the `SuperOffice.CRM.Globalization.CultureDataFormatter` class to handle these encoded values. SuperOffice.CRM.Globalization.CultureDataFormatter easily parses and returns the column value in the correct data type.

An encoded value is always a string of characters in the format: \[data-type-marker : value\], for example, \[I:3\]. Columns that are of type string will never be in an encoded format.

The data type marker indicates the column data type followed by a colon, then the column data value. The following table lists all encodings.

| Data Type | Marker | Example |
|---|---|---|
| Binary | B | \[B:X98…\] |
| Date | D | \[D:09.11.2017\] |
| DateTime | DT | \[DT:11/09/2017 14:53:18\] |
| Double, Decimal | F | \[F:123.4\] |
| Int | I | \[I:123\] |
| Money | M | \[M:123.45\] |
| Time | T | \[T:14:52\] |
| String | | "Not encoded" |

For each data type, `CultureDataFormatter` has a static `Encode` and `ParseEncoded` method, for example:

* `string = CultureDataFormatter.EncodeInt(int)`
* `int = CultureDataFormatter.ParseEncodedInt(string)`

Although query restrictions do not have to encode parameter values when settings each restriction, they are allowed and NetServer knows how to detect and process them accordingly.

## Continue reading

* [Aggregation][1]

<!-- Referenced links -->
[1]: data-aggregation.md

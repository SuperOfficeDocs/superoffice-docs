---
title: CultureDataFormatter
uid: globalization_culturedataformatter
description: Localization, class CultureDataFormatter
author: {github-id}
so.date: 05.08.2018
so.topic: reference
keywords:
---

# CultureDataFormatter

This is a helper class used to encode, parse and reformat culturally sensitive data used throughout SuperOffice without culture knowledge and a front end with such knowledge. The most common case is when working with [Archive Providers][1] and performing [Mass Operations][2].

Additionally, MDO lists such as Business and Category often contain delimited multicultural strings that require parsing. In the administration pages of SuperOffice, an MDO Item is easily edited in an MDO Item dialog.

![MDOListItem dialog -screenshot][img1]

As seen in the database, the record is stored as:

![MDOListItem record][img2]

## Using CultureDataFormatter

The following code demonstrates how to look up the Business MDO List items. The output of the name contains the complete multicultural string as seen in the database.

```csharp
ISoListProvider provider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("business");

foreach (var item in provider.RootItems)
{
  Debug.WriteLine(item.Name);
  // outputs:
  // "US:\"Legal\";NO:\"Lovlig\";"
}
```

The following code demonstrates how to use the `CultureDataFormatter` class to extract the cultural value using a language code.

```csharp
ISoListProvider provider = SuperOffice.CRM.Lists.SoListProviderFactory.Create("business");

foreach (var item in provider.RootItems)
{
  var engName = CultureDataFormatter.ParseMultiLanguageString(item.Name, "en-US");
  // outputs:
  // "Legal"
}
```

## Encoded Values

With core NetServer, the archive row column data contains a `RawValue` property of type `Object`, and can safely be cast to the appropriate type. However, when using NetServer web services it depends on whether you are using SuperOffice proxies or not. If you are, the `RawValue` property contains the column value. If not, only the `DisplayValue` exists and all values are returned encoded.

Except for string column values, `DisplayValue` always contains an encoded string. The `SuperOffice.CRM.Globalization.CultureDataFormatter` class knows how to handle these values and simply parses and returns the column value in the correct data type.

An encoded value is always a string of characters in the format: `[data-type-moniker : value]`, for example, [I:3]. Columns that are of type string are not encoded.

The data type moniker indicates the column data type followed by a colon, then the column data value. The following table lists all encodings with examples.

|Data type |Moniker |Example|
|---|---|---|
|Binary |B  |[B:X98…]|
|Date   |D  |[D:09.11.2017]|
|DateTime|DT    |[DT:11/09/2017 14:53:18]|
|Double, Decimal|F  |[F:123.4]|
|Int    |I  |[I:123]|
|IntArr |A  |[A:3,4,5]|
|Money  |M  |[M:123.45]|
|Time   |T  |[T:14:52]|
|TimeSpan|TS|[TS:500]|
|String |   |“Not encoded”|

For each data type, `CultureDataFormatter` has a static `Encode` and `ParseEncoded` method, for example:

```csharp
// encode
string = CultureDataFormatter.EncodeInt(int);

// decode
int = CultureDataFormatter.ParseEncodedInt(string);
```

Additional encode methods on the CultureDataFormatter class include:

* EncodeBinary
* EncodeDate
* EncodeDateTime
* EncodeDouble
* EncodeInt
* EncodeIntArr
* EncodeMoney
* EncodeTime
* EncodeTimeSpan
* ParseEncodedBinary
* ParseEncodedDate
* ParseEncodedDateTime
* ParseEncodedDouble
* ParseEncodedInt
* ParseEncodedIntArr
* ParseEncodedMoney
* ParseEncodedTime
* ParseEncodedTimeSpan

As these methods are more optimal, we recommend you chose to use these over the plain Encode method.

<!-- Referenced links -->
[1]: ../../api/archive-providers/index.md
[2]: ../../api/bulk-operations/mass-operations/index.md

<!-- Referenced images -->
[img1]: media/mdolistitemdialog.png
[img2]: media/mdolistitemdatabaserow.png

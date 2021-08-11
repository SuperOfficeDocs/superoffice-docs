---
uid: crmscript_global_string
title: String()
description: CRMScript String constructor
intellisense: Void.String
langref: 1
keywords: String(String), String(Byte[]), String(NSStream), String(Byte[],String), String(NSStream,String)
so.topic: reference
---

# String String()

String constructor. You can pass either a `String` object to copy or a byte array as either `Byte[]` or `NSStream`. You can optionally pass the codepage to use with the byte array.

Returns a `String` object.

## Functions

* String String(String value)
* String String(Byte[] byteArray) - doesn't support Unicode
* String String(Byte[] byteArray, String codepage)
* String String(NSStream byteArray) - doesn't support Unicode
* String String(NSStream byteArray, String codepage)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| byteArray | Byte[] OR<br>NSStream | The bytes containing a string |
| codepage | String | Optional. The codepage to use |

## Examples

```crmscript!
String squash = "yellow crook neck";
String favSquash = String(squash);
String winterSquash = String("butternut");
printLine("Summer favorite: " + favSquash + "\nFall favorite: " + winterSquash);
```

```crmscript!
String fallTreat = "Roasted pumpkin seeds are awesome";
Byte[] secret = fallTreat.toByteArray();
String jackO = String(secret);
printLine(jackO);
```

```crmscript!
String hot = "Ghost";
NSStream stream = decodeBase64AsStream(encodeBase64(hot.toByteArray()));
String hotPepper = String(stream);
printLine("Insanely hot chili pepper: " + hotPepper);
```

For more examples, see the [String datatype section][1].

<!-- Referenced links -->
[1]: ../../datatypes/string-type.md

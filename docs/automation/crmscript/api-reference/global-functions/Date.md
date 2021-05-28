---
uid: crmscript_global_date
title: Date
description: CRMScript Date constructor
intellisense: Void.Date
langref: 1
keywords: Date(Date), Date(String)
so.topic: reference
---

# Date Date()

Date constructor. You can pass either a `Date` object to copy or a `String` to be parsed. The default value is now.

Returns a `Date` object.

## Date Date(Date date)

`Date` object to copy.

## Date Date(String date)

Parse `String` with format **YYYY-MM-DD** and create `Date` object.

## Examples

```crmscript!
Date d;
Date next = Date(d);
printLine(next.toString());
```

```crmscript!
String newYearsDay = "2020-01-01";
Date q1 = Date(newYearsDay);
Date birthDay = Date("2011-01-13");
printLine(q1.toString() + "\n" + birthDay.toString());
```

For more examples, see the [Date datatype section][1].

<!-- Referenced links -->
[1]: ../../datatypes/date-type.md

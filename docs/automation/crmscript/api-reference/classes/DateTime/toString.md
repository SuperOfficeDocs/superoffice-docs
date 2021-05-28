---
uid: crmscript_class_datetime_tostring
title: DateTime.toString()
description: CRMScript method in the DateTime class that returns a string representation
intellisense: DateTime.toString
sortOrder: 236
keywords: toString(), toString(String), toString(String,String,String), toString(Integer,Integer,Bool)
so.topic: reference
---

# String toString()

Returns a string representation of the `DateTime`.

If you do not want the name of the months and the days, use the `toString()`-function with only one parameter, `toString(String format)`

## Functions

* String toString()
* String toString(String format)
* String toString(String format, String months, String weekDays)
* String toString(Integer mode, Integer language, Bool 24HourMode)

## Parameters

| Parameter | Type | Description |
|---|---|---|
| format | String | A specification of the wanted format. See the list of values below. |
| months | String | A comma-separated list of the name of the 12 months in your preferred language |
| weekDays | String | A comma-separated list of the name of the 7 days.
| mode | Integer | The mode of the string representation. See the list of values below. |
  language | Integer | The language to be used in the formatting. See the list of values below. |
| 24HourMode | Bool | Whether to use 24-hours mode. True = 24h, false = 12h. |

### Formats

The following formats are available. Single or in composition.

| Code | Includes | Number of digits |
|---|---|---|
| ISOW1 | week number | 1 or 2 |
| ISOW2 | week number | 2 |
| ISOWY2 | week number and year | week 1 or 2, year 2 |
| ISOWY4 | week number and year | week 1 or 2, year 4 |
| YY2 | year | 2 |
| YY4 | year | 4 |
| MM1 | month | 1 or 2 |
| MM2 | month | 2 |
| DD1 | day | 1 or 2 |
| DD2 | day | 2 |
| WEEKDAY | weekday, with Monday as 1 |
| MONTH | name of month |
| WDAY | name of weekday |
| H24 | hours, 24-hour mode | 1 or 2 |
| HH24 | hours, 24-hour mode | 2 |
| H12 | hours, 12-hour mode | 1 or 2 |
| HH12 | hours, 12-hour mode | 2 |
| MI2 | minutes | 2 |
| SS2 | seconds | 2 |

**AMPM** returns either am or pm.

### Modes

| Code | Name | Format | Example |
|:---:|:---|:---|:---|
| 0 | modeNewDate | YYYY-MM-DD | 2020-05-29 |
| 1 | modeNew2Min | YYYY-MM-DD hh:mm | 2020-05-29 13:37 |
| 2 | modeNew2Sec | YYYY-MM-DD hh:mm:ss | 2020-05-29 13:37:42 |
| 3 | modeTextDate | DD. MMM YYYY (no) | May 29. 2020 |
| | | MMM DD. YYYY (en) | 29. Mai 2020 |
| 4 | modeText2Min | DD. MMM YYYY 11:23 | May 29. 2020 13:37 |
| 5 | modeText2Sec | DD. MMM YYYY 11:23:15 | May 29. 2020 13:37:42 |
| 6 | modeText2MinLong | DD. MMM YYYY hh:mm (no) | 29. Mai 2020 13:37 |
| | | MMM. DD. YYYY hh:mm (en) | May 29. 2020 13:37 |
| 7 | modeShort2Min | MM/DD/YYYY hh:mm (no) | 29/05/2020 13:37 |
| | | DD/MM/YYYY hh:mm (en) | 05/29/2020 13:37 |
| 8 | modeNumeric | YYYYMMDDhhmmss | 20200529133742 |
| 9 | modeTime2Min | hh:mm | 13:37 |
| 10 | modeTime2Sec | hh:mm:ss | 13:37:42 |
| 11 | modeCompressed | YYYYMMDDhhmmss | 20200529133942 |
| 12 | modeRFC1123 | ddd, DD MMM YY hh:mm:ss GMT | Fri, 29 May 20 13:37:42 GMT |
| 13 | modeSoap | YYYY-DD-MMThh:mm:ss | 2020-05-29T13:37:42 |
| 14 | modeRFC822 | ddd, DD MMM YYYY hh:mm:ss +hhmm | Fri, 29 May 2020 13:37:42 +0200 |
| 15 | modeDateFirst | MM.DD.YYYY hh.mm | 29.05.2020 13:37 |
| 16 | modeSlash2Min | MM/DD/YYYY hh.mm | 29/05/2020 13:37 |

**Remarks:**

* 12 is HTTP-date
* 13 is SOAP standard formatting

> [!CAUTION]
> `toString()` **will not adjust to GMT**, so you will have to do it yourself!

### Languages

| Value | Language |
|---|---|
| 0 | Norwegian |
| 1 | English |
| 2 | German |
| 3 | Swedish |
| 4 | Danish |
| 5 | Dutch |

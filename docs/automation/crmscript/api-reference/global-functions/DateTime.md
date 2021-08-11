---
uid: crmscript_global_datetime
title: DateTime()
description: CRMScript DateTime constructor
intellisense: Void.DateTime
langref: 1
keywords: DateTime(DateTime), DateTime(String), DateTime(Integer,Integer,Integer,Integer,Integer,Integer)
so.topic: reference
---

# DateTime DateTime()

DateTime constructor. You can pass either a `DateTime` object to copy, a `String` to be parsed, or 6 Integer values representing all elements of a `DateTime`.

Returns a `DateTime` object.

## DateTime DateTime(DateTime dt)

`DateTime` object to copy.

## DateTime DateTime(Integer year, Integer month, Integer mday, Integer hour, Integer min, Integer sec)

Constructor for DateTime that allows you to specify all elements. It accepts 6 integer values, representing year, month (1-12), day-of-month (1-31), hour (0-23), minute (0-59), and second (0-59). It automatically calculates the weekday.

## DateTime DateTime(String p0)

Parse `String` containing date and time and create a `DateTime` object. It accepts the following formats, based on length:

| Format | Length | Description |
|---|---|---|
| YYYY-MM-DD HH:MM:SS | 19 | |
| YYYY-MM-DD HH:MM | 16 | automatically sets sec = 0 |
| YYYYMMDDHHMMSS | 14 | mysql.timestamp |
| YYYY-MM-DD | 10 | automatically sets the time to 23:59:59 or 0:0:0 depending on endOfDay setting |
| an empty string or "0" - sets stamp to Jan 1. 1970 00:00:00 and isNull() |
| YYYY-MM-DD HH:MM:SS:XXX | 23 | |

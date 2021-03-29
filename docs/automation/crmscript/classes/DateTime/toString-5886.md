---
title: crmscript_ref_DateTime_toString_String_format_String_months_String_weekDays
description: DateTime.toString(String format, String months, String weekDays)
intellisense: DateTime.toString
sortOrder: 239
keywords: toString(String,String,String)
so.topic: reference
---

Returns a String representation of the DateTime, formatted on the form specified in the String format.

If you do not want the name of the months and the days, use the `toString()`-function with only one parameter, `toString(String format)`

The following formats are available. Compose them as you want.


 - ISOW2 returns the week number as a two-digit number
 - ISOW1 returns the week number as one ore two digits
 - ISOWY4  returns the week number as one ore two digits and the year as four digits
 - ISOWY2  returns the week number as one ore two digits and the year as two digits
 - YY4  returns the year in four digits
 - YY2  returns the year in two digits
 - MM2 returns the month in two digits
 - MM1 returns the month in one or two digits
 - DD2 returns the day of month in two digits
 - DD1 returns the day of month in one or two digits
 - MONTH returns the name of month
 - WDAY returns the name of the weekday
 - HH24 returns the hours in two digits in 24hours-mode
 - H24   returns the hours in one or two digits in 24hours-mode
 - HH12 returns the hours in two digits in 12hours-mode
 - H12 returns the hours in one or two digits in 12hours-mode
 - MI2 retrurns the minutes in two digits
 - SS2 returns the seconds in two digits
 - AMPM return either am or pm.




###Parameters:###


 - format: A specification of the wanted format
 - months: A comma-separated list of the name of the 12 months in your preferred language
 - format: A  comma-separated list of the name of the 7 days.


Returns a String in the wanted format.



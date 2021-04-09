---
uid: crmscript_ref_DateTime_toString_String_format
title: DateTime.toString(String format)
intellisense: DateTime.toString
sortOrder: 238
keywords: toString(String)
so.topic: reference
---

Returns a String representation of the DateTime, formatted on the form specified in the String format.

The following formats are available. Single or in composition.


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
 - WEEKDAY returns the weekday, with monday starting at 1
 - HH24 returns the hours in two digits in 24hours-mode
 - H24   returns the hours in one or two digits in 24hours-mode
 - HH12 returns the hours in two digits in 12hours-mode
 - H12 returns the hours in one or two digits in 12hours-mode
 - MI2 returns the minutes in two digits
 - SS2 returns the seconds in two digits
 - AMPM return either am or pm.




## Parameters


 - format: A specification of the wanted format


Returns the object as as String on the wanted format



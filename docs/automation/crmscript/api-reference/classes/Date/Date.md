---
uid: crmscript_ref_Date
title: Date
intellisense: Void.Date
sortOrder: 194
so.topic: reference
---

A class for representing dates as objects.
Constructor can take a Date, and returns a Date.
The default date is now.



## Example


    Date d;
    
    d.addDay(3);
    d.addMonth(2);
    d.addYear(1); // d is 1 year, 2 months and 3 days from today
    print(d.getWeekDay().toString()); // Monday is 0
    print(d.toString()); // yyyy-mm-dd




1. autolist


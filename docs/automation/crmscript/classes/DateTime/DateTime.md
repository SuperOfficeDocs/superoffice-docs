---
uid: crmscript_ref_DateTime
title: DateTime
intellisense: Void.DateTime
sortOrder: 206
so.topic: reference
---

A class for representing date and time as objects.
Constructor can take a DateTime, and returns a DateTime.
The default datetime is now.



###Example code:###


    DateTime d;
    
    d.addDay(2);
    d.addHour(5); // d is 2 days and 5 hours from now
    print(d.getWeekDay().toString());
    
    DateTime t = DateTime(2017, 6, 27, 8, 30, 0);
    
    print(d.diff(t).toString()); // Prints time difference in sec - negative if t is largest




1. autolist


---
title: String toString(Integer mode, Integer lang, Integer maxMode, Bool short)
path: /EJScript/Classes/TimeSpan/Member functions/String toString(Integer mode, Integer lang, Integer maxMode, Bool short)
intellisense: 1
classref: 1
keywords: toString(Integer,Integer,Integer,Bool)
---


* **mode:** Lower unit
* **lang:** Language used for text
* **maxMode:** Upper unit
* **short:** True if you want short version of text (e.g. "m" instead of "minutes").
* **Returns:** A string representation of the timespan, on the given format and in the given language


Modes - These integers can be used for mode and maxMode parameters:
Mode2Year = 0
Mode2Day = 1
Mode2Hour = 2
Mode2Min = 3
Mode2Sec = 4

If the timespan is set to have ie 0 days, 10 hours, and 5 minutes, then toString(3, 1, 1) will return "10 hours, 5 minutes", not "0 days, 10 hours, 5 minutes"



###Language:###
Norwegian = 0
English = 1



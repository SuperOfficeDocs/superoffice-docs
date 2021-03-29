---
title: crmscript_ref_DateTime_toString_Integer_mode_Integer_language_Bool_24HourMode
description: DateTime.toString(Integer mode, Integer language, Bool 24HourMode)
intellisense: DateTime.toString
sortOrder: 237
keywords: toString(Integer,Integer,Bool)
so.topic: reference
---

The method will give a string representation of the DateTime object.



###Parameters:###


 - Integer representing the mode of the string representation. See below for the available modes
 - Integer the language to be used in the formatting. See below for a list of languages
 - 24HourMode if true, 24 hours mode will be used. If false, 12 hours mode will be used


Returns the string representation of the DateTime object



###Modes:###
    0: modeNewDate,          1998-01-12
    1: modeNew2Min,          1998-01-12 11:23
    2: modeNew2Sec,         1998-01-12 11:23:15
    3: modeTextDate,         02. Jan 1998 (in norwegian), Jan 02. 1998 (in english)
    4: modeText2Min,          12. Jan 1998 11:23
    5: modeText2Sec,         12. Jan 1998 11:23:15
    6: modeText2MinLong,   20. Aug 1998 11:23 (in norwegian), Aug. 20. 2008 11:23 (in english)
    7: modeShort2Min,        13/02/1998 12:34 (in norwegian), 02/13/1998 12:34 (in english)
    8: modeNumeric,           19980112112315
    9: modeTime2Min,	       11:23
    10: modeTime2Sec,       11:23:15
    11: modeCompressed,    19980112112315
    12: modeRFC1123,         Thu, 01 Dec 94 16:00:00 GMT   (HTTP-date) NB!! `toString()` will not adjust to GMT, so you will have to do it yourself
    13: modeSoap,              1998-01-12T11:23:15 SOAP standard formatting
    14: modeRFC822,           Sun, 26 Aug 2007 08:08:21 +0200
    15: modeDateFirst,        18.08.2004 10.17
    16: modeSlash2Min        18/08/2004 10.17



###Languages:###
    Norwegian = 0,
    English = 1,
    German = 2,
    Swedish = 3,
    Danish = 4,
    Dutch = 5,



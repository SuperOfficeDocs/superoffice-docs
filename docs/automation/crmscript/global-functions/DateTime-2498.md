---
title: DateTime DateTime(String p0)
path: /EJScript/Global functions/DateTime DateTime(String p_0)
intellisense: 1
langref: 1
sortOrder: 9335
keywords: DateTime(String)
---


Parse string and create datetime object


This function sets the DateTime based on a string.
  It accepts the following formats, based on length:
     1: YYYY-MM-DD HH:MM:SS (19)
     2: YYYY-MM-DD HH:MM (16)   sec = 0
     3: YYYYMMDDHHMMSS (14)     mysql.timestamp
     4: YYYY-MM-DD (10)         p\_endOfDay ? (23,59,59) : (0,0,0)
     5: \<empty string>/"0"      no info, sets to jan 1. 1970 00:00:00, and isNull
     6: YYYY-MM-DD HH:MM:SS:XXX (23)


* **datetime:** DateTime string with format HH:MM:SS
* **Returns:** DateTime object.



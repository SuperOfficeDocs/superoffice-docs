---
uid: crmscript_ref_String_until_String_s
title: String.until(String s)
intellisense: String.until
keywords: until(String)
so.topic: reference
---


This function will return a substring of this string, starting at index 0, ending before
the first instance of s. E.g. if this string is "name := test", then until(":=") will
return "name ". If there is no instance of s in this string, then a copy of this string is returned.
* **s:** String at where to terminate result.
* **Returns:** The first part of the string.



---
uid: crmscript_ref_String_getWord_Integer_num
title: String.getWord(Integer num)
intellisense: String.getWord
keywords: getWord(Integer)
so.topic: reference
---

# String.getWord(Integer num)

Return a numbered word from a string

This function returnes word number num from the string. Word 0 is the first word
in the string, even if it's after some leading whitespace.
E.g. `String("  this is a test")`.getWord(1) yields "is".

* **The:** number of the word to return, starting at 0
* **Returns:** The word


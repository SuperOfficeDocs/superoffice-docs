---
uid: crmscript_ref_String
title: String
intellisense: Void.String
so.topic: reference
---

# String

A class for representing strings as objects.
Constructor can take a string, and returns a string.

## Example

    String s = "47882255";
    
    if (s.isDigit() && s.getLength() == 8){
       print(s + " is a valid phone number");
    }

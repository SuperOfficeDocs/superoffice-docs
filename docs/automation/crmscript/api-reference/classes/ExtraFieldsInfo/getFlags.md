---
uid: crmscript_ref_ExtraFieldsInfo_getFlags
title: ExtraFieldsInfo.getFlags()
intellisense: ExtraFieldsInfo.getFlags
sortOrder: 304
keywords: getFlags()
so.topic: reference
---

# ExtraFieldsInfo.getFlags()

Returns the flags for the current extra field.

These can be accessed by wrapping the returned Integer in a FHBitSet.

## Example

--

    FHBitSet flags;
    
    flags.set(extraField.getFlags());
    
    flags.getBitNo(17);  // returns true if the extra field cannot be empty

--

## Flags

0  = The field is searchable
1  = The field is public (external)
2  = The field is viewed in new-ticket form
3  = The field is set (datetime) when clicked
4  = The field cannot change after being set
5  = The field is a dropdown (extra string fields)
6  = The field is directly readable from database
7  = Do not HTML-escape the value when displaying field
8  = The field is deleted
9  = The field is the id
10 = The field is a foreign id
11 = The field is not writeable
12 = Use default value for field if no value is supplied
13 = List relations
14 = View this field when listing rows
15 = Hide the header for this list if there are no entries
16 = Hide the function buttons for this relation
17 = The field cannot be empty
18 = The field is not shown anywhere
19 = The field is indexed
20 = The field is viewed in relational searches

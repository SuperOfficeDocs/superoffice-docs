---
uid: enum-prefdescvaluetype
title: Enum values for PrefDescValueType
description: Lists the enum values for PrefDescValueType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# PrefDescValueType Enum

1=number, 2=text, 3=bool, 4=list of values; 5=list table ref; 6=contact ID, 7=Person ID, 8=Project ID, 9=Selection ID

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing|
|Number|1|Preference value is a number|
|Text|2|Preference value is a text (max len 99 characters)|
|Bool|3|Preference value is Boolean|
|ListOfValues|4|Preference value is a list of separate value|
|ListTableRef|5|Preference value is a record ID in the given MDO list table; maxValue contains the tablenumberø|
|TimeList|6|Preference value is a time, value is seconds since midnight (28800 = 08:00)|
|ContactID|7|Preference value is a contact ID|
|PersonID|8|Preference value is a person ID|
|ProjectID|9|Preference value is a project ID|
|SelectionID|10|Preference value is a selection ID|
|PosSize|11|Obsolete: Windows position and size|
|TimeZone|12|TimeZone location|
|Time|13|Time, preference value is 13:45:50|
|Password|14|Password, stored as plain text but shown with dots|
|MultiLineText|15|Multi-line text that preserves line breaks|

## Usage

* [PrefDesc](../prefdesc.md).valueType - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 

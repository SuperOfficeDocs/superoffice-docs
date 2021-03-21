---
uid: enum-prefdescvaluetype
title: Enum values for PrefDescValueType
description: Lists the enum values for PrefDescValueType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PrefDescValueType Enum

1=number, 2=text, 3=bool, 4=list of values; 5=list table ref; 6=contact ID, 7=Person ID, 8=Project ID, 9=Selection ID

* Unknown = 0
* Number = 1
* Text = 2
* Bool = 3
* ListOfValues = 4
* ListTableRef = 5
* TimeList = 6
* ContactID = 7
* PersonID = 8
* ProjectID = 9
* SelectionID = 10
* PosSize = 11
* TimeZone = 12
* Time = 13
* Password = 14
* MultiLineText = 15

## Usage

* [PrefDesc](../prefdesc.md).valueType - Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 

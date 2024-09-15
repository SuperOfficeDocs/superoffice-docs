---
uid: enum-udefjustification
title: Enum values for UdefJustification
description: Lists the enum values for UdefJustification.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# UdefJustification Enum

Justification - 0 = default, left, right, center

| Name | Value | Description |
|------|-------|-------------|
|Default|0||
|Left|1||
|Center|2||
|Right|3||

## Usage

* [UDefField](../udeffield.md).justification - Definition table for user-defined fields; one row in this table corresponds to one generation of one field. The user defined fields that are in use, and earlier versions of user defined fields. ColumnId refers to the field type; see UDXXXSmall or UDXXXLarge for the referring ID.  Preferences prefsection=&apos;System&apos;, prefkey=&apos;CurrentUdefVersioncontact&apos;  (or CurrentUdefVersionperson, project, sale), gives you the current version of user defined fields.  prefkey=&apos;AdminUdefVersion&lt;...&gt;&apos; gives you the current version that&apos;s being edited. If Current version = admin version, no editing has been done since the last Publish of user defined field was performed.

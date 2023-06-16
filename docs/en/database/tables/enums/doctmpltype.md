---
uid: enum-doctmpltype
title: Enum values for DocTmplType
description: Lists the enum values for DocTmplType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# DocTmplType Enum

1 = app, 2 = doc, 3 = email, 4 = fax, 5 = phone, 6 = todo - see EAppntRecordTypes

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|The document type is unknown/undecided|
|Appointment|1|(not used for document templates)|
|Document|2|Generic text document (for instance, a letter)|
|Email|3|Email message|
|Fax|4|Facsimile|
|Phone|5|(not used for document templates)|
|Todo|6|(not used for document templates)|
|MergeDraft|7|Template for mailmerge operations|
|MergeFinal|8|Result of a mailmerge operation|
|SavedReport|9|Saved result of running a report (output from Reporter)|

## Usage

* [DocTmpl](../doctmpl.md).record_type - DocTmpl list table. Describes templates available for writing new documents.

---
uid: enum-trlogtranstype
title: Enum values for TrlogTransType
description: Lists the enum values for TrlogTransType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TrlogTransType Enum

Type of event

* Unknown = 0
* Insert = 4352
* Update = 4608
* Delete = 4864
* UpdateOwner = 5120
* OldUpdateContact = 5376
* OldUpdateProject = 5632
* DeleteAreaUserInclusion = 5888
* DeleteAreaUserAssignment = 6144
* PublishUdef = 6400
* UpdateFieldPart1 = 8192
* UpdateFieldPart2 = 8193
* UpdateFieldPart3 = 8194
* UpdateFieldPart4 = 8195
* UpdateFieldPart5 = 8196
* UpdateFieldPart6 = 8197
* UpdateFieldPart7 = 8198
* UpdateFieldPart8 = 8199
* UpdateContact = 10000
* UpdateProject = 20000
* TruncateTable = 21000

## Usage

* [traveltransactionlog](../traveltransactionlog.md).type - Log of all updates made to the database, that need to be replicated.

---
uid: enum-associatetype
title: Enum values for AssociateType
description: Lists the enum values for AssociateType.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AssociateType Enum

Associate type

* NoPersonBit = 1
* AnonymousBit = 2
* NoCalenderBit = 4
* NoSentryBit = 8
* Employee = 0
* Resource = 1
* ExternalPerson = 4
* System = 13
* Anonymous = 7

## Usage

* [associate](../associate.md).type - Employees, resources and other users - except for External persons
* [AssociateHistory](../associatehistory.md).type - Historical information about associates that have been deleted. Most references are NOT declared as foreign keys; this is a historical table that should not be updated when further changes occur in the database

---
uid: enum-refcountflags
title: Enum values for RefcountFlags
description: Lists the enum values for RefcountFlags.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RefcountFlags Enum

Unique, active, read-only, allow blank, …

* Unknown = 0
* Allocate = 1
* Unique = 2
* ReadOnly = 4
* AllowBlank = 8

## Usage

* [RefCounts](../refcounts.md).flags - Number counter for all tables that generate numbers, e.g. templates, contacts...   This table is used for the number allocation system and should not be confused with sequence, used for allocating internal ID&apos;s. This table is replicated during generation of satellites and during local update for travellers, using special logic. By default it contains rows for the SuperOffice standard counters, including one row for each DocTemplate record.  It is permissible to add new rows to this table, and such records are maintainable through the Maintenance client.  Changing the contents of the standard records is not recommended. 

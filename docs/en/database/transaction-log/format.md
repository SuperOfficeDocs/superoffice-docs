---
title: Transaction log format
uid: travel_transaction_log_format
description: Travel transaction log format
author: {github-id}
keywords: database, travel
topic: reference
date:
envir: onsite
client: win
---

# Format

The record definition looks like this:

| C++ DataType | C++ Name | DB DataType | DB Name |
|---|---|---|---|
| Longid  | id        | int      | `traveltransactionlog_id` |
| date_t | time      | int      | `ttime` |
| longid  | mode      | int      | `prev_record_id` |
| Ushort  | type      | smallint | `type` |
| LongId  | assoc_id | int      | `associate_id` |
| Ushort  | tabno     | smallint | `tablenumber` |
| LongId  | rec_id   | int      | `record_id` |

## Prefix on travel

Below all tables in the database reference, you will find, for example, "Prefix on travel: 0x0000007e". This is the ID that SuperOffice CRM 5 adds to new records on travel. Take the last byte, and move it 24 bits to the left, and you have the number added to the allocated `next_id` from sequence during travel. It’s restored to normal low IDs when the traveler performs a homecoming.

## id

This field identifies the record in the `traveltransactionlog` (not the record changed). Its value is taken from [sequence][3], using sequence row 39. The standard SQL statement used to get new IDs is:

```SQL
BEGIN TRANSACTION
UPDATE so.sequence SET next_id = next_id + 1 WHERE id = 39
SELECT next_id - 1 FROM so.sequence WHERE id = 39
COMMIT TRANSACTION
```

If an application requires new IDs for several tables it will be able to group all the update statements inside a single begin/commit transaction block. It is also legal to increment a sequence row by more than 1 if you need more than 1 new row in one table.

> [!NOTE]
> Do not change the order to select/update as this would not be multi-user safe.<br>Also, the actual new ID is not the `next_id` in the table, but `next_id - 1`.

## ttime

This is a standard SuperOffice date/time value, the number of seconds since 1.1.1970 00:00. The PC's local clock is used, which may introduce some inaccuracies in the update logic if two users make near-simultaneous updates to the same record and their PCs do not have synchronized clocks. Ideally, the PC clock should be synchronized with an external source when using Travel functions. The time field is a timestamp that shows when the record update (or insertion or deletion) was done (when the `traveltransactionlog` record was created).

## Prev_record_id

This field is now used for additional information. It is normally set to "0", except in these situations:

* The type is 5120 kTrtRecUpdateOwner (see below).In that case, the mode field contains the previous owner ID.
* The owner ID is an associate ID that contains the owner of a record. It refers to these tables and fields:

| Table | Field |
|---|---|
| Contact     | `associate_id` |
| Project     | `associate_id` |
| Appointment | `associate_id` |
| Sale        | `associate_id` |

The logic is:

1. Prepare and write normal `traveltransactionlog` record
2. If operation = update
    * If `associate_id` is changed and table in (contact, project, appointment, sale)
      * mode = `previous associate_id`
      * type = `kTrtRecUpdateOwner`
      * set `id`, `time`, `tabno`, `rec_id`
      * write `traveltransactionlog`
    end
  end

This functionality is only relevant if you are using [Area Management][2]. Area Management uses the owner associate ID as one of the criteria for determining which area a record belongs to. If the owner ID is changed it might trigger the transfer of that record from one area (satellite) to another, translating an update operation into a delete/insert pair on separate areas.

The extra `traveltransactionlog` record contains the previous owner ID (which is not available anywhere else) so that the area management system can determine what to do.

| Type | Description |
|---|---|
| 5888 | User (`Associate_id`) removed from Area user inclusion |
| 6144 | User (`Associate_id`) deleted from Area user assignment |
| 6400 | `Prev_record_id` = version of user defined fields that’s been published (`udeffield.version`)<br>Tablenumber: contact = 7, person = 8, project = 9, sale = 10. |
| 8192 - 8200 | Used with Field level replication. It’s a bit mask of which fields in the record that has been changed, 1 means fields have been changed. This means if the second field in a record has been changed, then `pref_record_id=2`. |

<!-- Referenced links -->
[2]: ../../travel/area-management/index.md
[3]: ../getting-started/table-id-sequence.md

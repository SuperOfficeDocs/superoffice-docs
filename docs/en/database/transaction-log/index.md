---
title: Travel transaction log
uid: travel_transaction_log
description: Travel transaction log
author: {github-id}
keywords: database, travel
topic: concept
date:
envir: onsite
client: win
---

# Transaction log

SuperOffice has a database-independent synchronization mechanism. It is used by the Satellite replication system and by the Travel system.

All changes to tables are recorded in a [special transaction log table][1] with timestamps showing when the change happened.

The replication system can then look at what has changed since the previous sync and copy the affected records to the Satellite or Remote Travel system.

The logs are updated when a SuperOffice user changes data. They will not be automatically updated by the database when inserting, updating, or deleting from outside SuperOffice.

> [!NOTE]
> They are updated when data manipulation is done through SuperCOM, SuperOffice OleDB provider, or NetServer to SuperOffice. We, therefore, recommend that you use our tools to make updates to the database.

## Purpose of the log

The table `traveltransactionlog` (`crm7.traveltransactionlog` in ODBC databases, also referred to as the "log") is used to keep track of all updates, that is, insertions, deletions, and changes to all data records in SuperOffice.  It is used by the update functions in Travel (local update, async update, central update) and Satellite (up, down files) to determine what to send.

The log contains one record for each change. The record does not actually contain the data that was changed, only a reference to the table and record id of the changed record.

* [Format and fields][2]
* [Keeping track of changes - query the log][3]

<!-- Referenced links -->
[1]: ../tables/traveltransactionlog.md
[2]: format.md
[3]: query-log.md

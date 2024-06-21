---
title: Query the transaction log
uid: query_transaction_log
description: How to query the transaction log - keeping track of changes
author: {github-id}
date:
keywords: database,travel
topic: howto
envir: onsite
client: win
---

# All changes are logged

When you create/modify/delete a row, the change is logged in the [travel transaction log][2] so that travelers and satellites can be synchronized.

Let’s take a look at what was stored in the log when we create the project *Client SDK Work*.

First, we need the project ID for the project we created:

```SQL
SELECT project_id FROM project WHERE name='Client SDK Work'
```

Make a note of the ID.

Now let us get a list of all the transactions that have happened since midnight this morning:

```SQL
SELECT * FROM traveltransactionlog WHERE ttime > '2003.8.7'
```

(use today's date instead of 2003.8.7)

The date is in YYYY.MM.DD HH:MM:SS format. If you leave out the HH:MM:SS they default to zero (midnight).

The transaction log contains a primary key, the time of the transaction (`ttime`), who performed the transaction (`associate_id`), a type indicating what happened, a table number indicating what table was affected, and the record ID of the record in the table that was changed.

![x][img1]

The most common transaction types are:

* New record = 4352
* Update record = 4608

The table IDs are listed in the reference section.

These are the ones relevant to the new project

* Project table  = 11
* Text table = 18
* UDProjectSmall = 142

So we need to scroll down the list of transactions until we find the traces of our new project.

First, we see the project being created (`table=11`, `type=4352`). Then the text description is added to the project (`table=18`, `type=4352`).

You might also see the user-def table having a record inserted (`table=142`, `type=4352`)

This table is very useful if you want to monitor updates to the database or replicate changes to another system. You create a database trigger to replicate changes. SuperOffice does not use triggers or stored procedures because of its database independence. There is nothing to prevent you from adding your own, as long as they do not affect SuperOffice’s access to the tables. Adding constraints or throwing exceptions at SuperOffice will cause the CRM client to stop working.

When a traveler returns, all his updates are added to the end of the transaction log, but the timestamps are maintained. The timestamps should be kept in UTC/GMT - the same as the registered and updated fields on the records themselves. This makes conflict resolution easier to handle.

If there are two concurrent updates, then the last update wins. This is rarely a problem in practice since people tend to "own" a subset of the data that only they modify.

## Example

![x][img2]

When the user leaves on travel, his transactions are logged in a separate range of IDs. When he returns, the transactions are mapped back into the main sequence.

## See also

* [traveltransactionlog table][1]

<!-- Referenced links -->
[1]: ../tables/traveltransactionlog.md
[2]: index.md

<!-- Referenced images -->
[img1]: media/transactionlog.png
[img2]: media/screencap3.png

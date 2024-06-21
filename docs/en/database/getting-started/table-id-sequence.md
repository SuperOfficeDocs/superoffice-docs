---
title: Sequence
uid: ids_in_sequence
description: Sequence - where do IDs come from
author:
date:
keywords: database
topic: concept
---

# Sequence - where do IDs come from

The ID numbers are stored in a table called `SEQUENCE`.

```SQL
SELECT * FROM sequence
```

The `sequence` table has a counter for each table.

The ID is the table ID + 10 (the first 10 tables are used for storing the dictionary data).

The `contact` table is table number 5, so the next available `contact_id` is the row with ID = 15.

If you are adding your own records to the database, you must update the sequence table as well, otherwise, SuperOffice will trample your records.

## Number ranges

There are ranges of ID in use when it comes to the SuperOffice database, and the range depends on where in the hierarchy this database is. We refer to the central database as the mother, and this database ID range starts from 1.

At some point, we need to start the range for the satellites, and we've said the first satellite starts at 0x1000000 (16777216), the second satellite starts ID range at 0x2000000 (33554432), and so on. These high IDs may live in all databases, so you'll find both central and satellite IDs in all types of SO databases.

Now you also have the travel databases, they have a temporary ID range from 0x7E000000 (2113929216). Now, this range is the same for ALL travel databases and the high IDs from these databases are automatically converted to central or satellite IDs when the user syncs his data with its mother database. There should never be high travel IDs in a central or satellite database.

<!-- markdownlint-disable-file MD041 -->
### Use of the Sequence table

The sequence table contains the next unallocated ID for each SuperOffice table.

Each sequential row has its own ID number, which is 10 + the table number in the table listing.

When inserting a new row in a table you will need to allocate the ID value to use for this record.

Reading and updating the next ID value should always be performed as a single transaction because if someone else reads and updates this information simultaneously, a database error will occur when inserting the new row.

**Example:**

Allocate an ID for `Contact` table

([Contact][1] is table 5, + 10 = 15)

```SQL
BEGIN TRANSACTION
UPDATE Sequence SET next_id = next_id + 1 WHERE id = 15;
SELECT next_id - 1 FROM Sequence WHERE id = 15;
COMMIT TRANSACTION
```

<!-- Referenced links -->
[1]: ../contact.md

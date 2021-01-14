---
title: Insert, update, and delete
uid: search_engine_db_actions
SortOrder: 60
---

Other query types.

### Integer insert()

`insert()` adds a new row to an existing table. Here's how you do it:

1. Populate the fields in the new record with `addData()`.
2. Call `insert()`.
3. Optionally do something with the returned ID.

> [!TIP]
> Consider wrapping the insert query in a `try...catch` block.

### Void update()

`update()` changes existing data in the database. Here's how you do it:

1. Populate the fields you want to change.
   * Use `addData()` to add a value
   * Use `addDataField()`  to add a foreign key

2. Optionally use `addCriteria()` to place restrictions on the items to modify.

3. Call `update()`.

> [!CAUTION]
> Writing to the database this way doesn't log the change to the crm7.traveltransactionlog table. It should therefore be avoided in environments with satellites and travelusers.

### Void delete()

`delete()` removes data from the database. Think carefully before you delete anything!

Here's how you do it:

1. Build a complete [select query](./se-select.md).

2. Optionally inspect the result set to check that you are deleting what you intend to.

3. Call `delete()`.

> [!NOTE]
> Best-practice is to use the NetServer agent classes to remove data because they also remove data from related tables and log changes to the traveltransactionlog.

## Adding data for update and insert

> [!NOTE]
> You must write field names prefixed by their table name. For example, `customer.name`.

### Void addData(String field, String value)

Adds data for use in an update or insert query.

```crmscript
SearchEngine se;
se.addData("ticket.status", "deleted");
se.addCriteria("ticket.status", "equals", "postponed");
se.update();
```

### Void addDataField(String field1, String field2)

Adds a data field to the SearchEngine for use in an **update** query.

A data field doesn't contain a value - it's a foreign key to another field. The target field can be within the same table or in a related table.

```crmscript
SearchEngine se;
se.addDataField("ticket.deadline", "ticket.closed_at");
se.update();
```

### Void addDataField(String field1, String field2, String func)

A variant of `addDataField()` specifying an aggregate function to use for `field2`.

The following functions are available:

* any of the functions you can use with `addField()` - listed in the reference section for the [select query](./se-select.md).

* castToVarchar
* date
* time

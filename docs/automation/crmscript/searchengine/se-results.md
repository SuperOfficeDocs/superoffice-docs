---
title: search_engine_results
description: 
author:
so.date:
keywords:
so.topic:
---

# Exploring search results

After building the SearchEngine query and calling `execute()`, it is time to look at the returned data.

## Traversing the result set

### Bool eof()

Check if you have reached the end of the result set.

### Bool first()

Start traversing by pointing to the 1st item in the result set.

### Bool next()

Move the pointer to the next item in the result set unless you have reached the end of the result set.

### String getField(Integer num)

Fetches the value of a field identified **by its number** (starting at 0).
The string is retrieved from the current row/record.

```crmscript!
SearchEngine se;
se.addField("ticket.cust_id.firstname");
se.execute();
se.first();
printLine(se.getField(0));
```

### String getField(String name)

Fetches the value of a field identified **by its name** from the current row.

> [!NOTE]
> Remember to prefix field names with their table name!

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.execute();
se.first();
printLine(se.getField("sale.sale_id"));
```

### String getField(String field, String function)

Fetches the value of a field identified by its name from the current row, invokes a function, and returns the result as a string.

### Putting it all together

Example: get the first name of all customers with active requests

```crmscript!
SearchEngine se;
se.addField("ticket.cust_id.firstname");
se.addCriteria("ticket.status", "OperatorEquals", "1", "OperatorAnd", 0);
for (se.execute(); !se.eof(); se.next()) {
  printLine(se.getField(0) + " has some requests...\n");
}
```

## Getting statistics

You can retrieve statistics both before and after calling `execute()`. These methods will ignore `setLimit()`.

### Integer countColumns()

Gets the number of columns (selected fields) in the SearchEngine query.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
se.setLimit(10);
print(se.countColumns().toString());
```

### Integer countRows()

Gets the number of rows matching the SearchEngine query.

```crmscript!
SearchEngine se;
se.addFields("sale", "sale_id,heading,amount");
print(se.countRows().toString());
```

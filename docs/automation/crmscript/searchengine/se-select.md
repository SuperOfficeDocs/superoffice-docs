---
uid: search_engine_select
title: Building a query
author:
so.date:
keywords:
so.topic:
---

# Building a query

## Select from

The 1st and mandatory part of the query is to set the columns and tables to fetch data from.
You do this by adding 1 or more fields - optionally with a function to use on the field.

> [!CAUTION]
> Make sure that all fields in a query start with the same table. Otherwise, you get a big join, which is probably not what you intended or need.

### Void addField(String field)

Adds a field to the select-part of the query.

```crmscript
SearchEngine se;
se.addField("ticket.cust_id.firstname");
```

### Void addField(String field, String func)

Adds a field to the select-part of the query and sets a function to use on that field.

Functions are listed in the reference section at the end of this page. Use the function names in the left column for `addField()`.

```crmscript
SearchEngine se;
se.addField("ticket.cust_id.firstname", "lower");
```

### Void addFields(String table, String fields)

A shortcut for add multiple fields to a query.

`addFields()` - notice the trailing s - it will add all fields in the comma-separated string `fields`, prefixed by the table name and a dot (.)

```crmscript
SearchEngine se;
se.addFields("ticket", "id,title,category.fullname,cust_id.fullName");
```

This single call to `addFields()` corresponds to the following 4 calls to `addField()`:

```crmscript
SearchEngine se;
se.addField("ticket.id");
se.addField("ticket.title");
se.addField("ticket.category.fullname");
se.addField("ticket.cust_id.fullName");
```

## Where

The 2nd and optional part of the query is to set **conditions** that the data must satisfy.

If you have multiple criteria, you can group and order them by giving each a **priority**. All criteria with the same number will be placed inside the same brackets.

### Void addCriteria(String field, String compOperator, String value)

This is the basic variant of `addCriteria()` and it's often used when you need only 1 condition. It compares `field` to `value` using the operator.

**Comparison operators** are listed in the reference section at the end of this page. Remember that the operator and value must correspond to and be appropriate for the field type.

If the comparison evaluates to **true** and there are no other criteria or restrictions, the row is added to the search result. In other words, you restrict the inclusion of a row based on a field.

```crmscript
SearchEngine se;
se.addCriteria("associate.type", "OperatorEquals", "0");
```

### Void addCriteria(String field, String compOperator, String value, String rowOperator, Integer priority)

This variant of `addCriteria()` extends the condition by also adding a priority and a logical operator. It is typically used when another criterion follows this one.

Row operators are listed in the reference section at the end of this page.

```crmscript
SearchEngine se;
se.addCriteria("ticket.status", "OperatorEquals", "1", "OperatorAnd", 0);
```

Notice that the **priority is a number** and not a string.

### Void addCriteria(String field, String function, String compOperator, String value, String rowOperator, Integer priority)

Same as above while also specifying a function to use on the field.

Functions are listed in the reference section at the end of this page. Use the function names in the 2.nd column for `addCriteria()` - those starting with *Func*.

```crmscript
SearchEngine se;
se.addCriteria("ticket.status", "FuncCount", "OperatorEquals", "1", "OperatorAnd", 0);
```

### Void addComparison(String field1, String compOperator, String field2, String rowOperator, Integer priority)

Similar to `addCriteria()`, but `addComparison()` will compare 2 fields to each other rather than compare a field to a set value.

### Void addComparison(String field1, String func1, String compOperator, String field2, String func2, String rowOperator, Integer priority)

Same as above while also specifying a function to use on each field.

### Void addJoinCriteria(String p0, String p1, String p2, String p3, Integer p4)

> [!NOTE]
> This method doesn't work with NetServer. You need to bypass NetServer if you need to call `addJoinCriteria()`. Bypass is supported for onsite only.

## Group by, having

The next (and optional) part of the query is to combine and filter the data.

For example, you want to list how many customers you have in each country (combine) but ignore countries with less than 5 customers (filter).

> [!NOTE]
> Group by, having, and aggregate functions don't work with NetServer. You need to bypass NetServer if you need to call `setGroup()` and `addHaving()`. Bypass is supported for onsite only.

### Void setGroup(Bool set)

A group-by clause applies to all fields in the query - those added by calling `addField()`.
This will combine all rows that have the same values into summary rows. It is often used with aggregate functions (count,avg,sum,max).

* `setGroup(true)` set the group-by clause
* `setGroup(false)`remove a group-by clause

```crmscript
SearchEngine se;
se.addField("sale.associate_id.name");
se.addField("sale.amount", "avg");
se.bypassNetServer(true);
se.setGroup(true);
```

### Void addHaving(String field, String compOperator, String value, String rowOperator, Integer priority)

A having clause filters the search result by setting a condition similar to `addCriteria()`.
The field you want to place a restriction on must also be in the group-by clause.

### Void addHaving(String field, String func, String compOperator, String value, String rowOperator, Integer priority)

Same as above while also specifying a function to use the field.

It is often used with aggregate functions (count,avg,sum,max) when you can't apply those in the where clause.

```crmscript
SearchEngine se;
se.addField("sale.associate_id.name");
se.addField("sale.amount", "avg");
se.setGroup(true);
se.addHaving("sale.status", "OperatorEquals", "1", "OperatorAnd", 0);
```

## Distinct, order by

The final (and optional) part of the query is to sort the data and/or remove duplicates.

### Void addOrder(String field, Bool ascending)

Lists the result in ascending or descending order based on a field value.

```crmscript
SearchEngine se;
se.addFields("ticket", "status,id,title,created_at");
se.addCriteria("ticket.status", "OperatorEquals", "1", "OperatorAnd", 0);
se.addOrder("ticket.created_at", true);
printLine(se.executeTextTable());
```

### Void addOrder(String field, String function, Bool ascending)

Lists the result in ascending or descending order based on the result from using function f on the field value.

### Void setDBDistinct(Bool p0)

Forces SearchEngine to use DISTINCT in the query.

> [!NOTE]
> Requires NetServer to be bypassed. Not supported for CRM Online.

### Void setDistinct(String field)

Sets which field you want to determine uniqueness based on.

```crmscript
SearchEngine se;
// ...
se.setDistinct("ticked.id");
```

In this example, identical tickets will not be listed. There will be exactly 1 entry with the same ticket ID. Very useful with many-to-many relations.

## House-keeping

### Integer select()

Runs the query and returns the size of the result set as an Integer.

### Void setLimit(Integer number)

If you have a large database, it can be wise to restrict the amount of data you get back.

`setLimit()` puts a cap on the number of rows you receive in the result set.

```crmscript
SearchEngine se;
// ...
se.setLimit(100);
```

### String buildSql()

Returns the SQL query generated by the SearchEngine. This is only an estimate of the actual SQL because the query is sent to NetServer.

Example:

```sql
select a0.status,a0.id,a0.title,a0.created_at from ticket a0 where (a0.status = ?) order by a0.id desc
```

### String buildSql(String p0)

Same as above, but you can specify the type of query:

* select
* insert
* update
* delete

## What's next?

You now know how to build a SearchEngine query, look at the generated SQL, gauge the size of the search result, and limit it if need be. It is now time to turn to [executing the query][1].

## Reference

### Functions

A function specifies what to do with the value of a field.

[!include[ALT](includes/functions.md)]

### Row operators

A row operator is a logical operator used to combine 2 criteria in a search condition.

[!include[ALT](includes/row-operators.md)]

### Comparison operators

A comparison operator evaluates the value of a field as part of a search condition.

Notice that all operators are specified as strings in the argument list.

[!include[ALT](includes/comp-operators.md)]

<!-- Referenced links -->
[1]: se-run.md

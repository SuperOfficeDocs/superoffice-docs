---
uid: search_engine_dot_syntax
title: Dot-syntax
author:
so.date:
keywords:
so.topic:
---

# Dot-syntax

**Universal access** to the SuperOffice database has been dubbed **dot-syntax**. This is a way of specifying columns, tables, and joins across the entire data dictionary (including partner tables). It is extremely powerful and almost unlimited.

> [!NOTE]
> All names are case-insensitive. Aliasing is not supported.

## Formal syntax

```ebnf
column := <table>[<join>, ...].<field>
join := .<foreign_key> | (<table>-><primary_key>) | :<foreign_key>
```

## In layman's terms

* Use a dot (.) to left-outer join along a dictionary relation
* Use a colon (:) to inner join
* Use an arrow (->) when the relation goes from the target table instead of from the current table.

There is always 1 root table, and it is the same for all columns.

When you do a join (regardless of type), the target table becomes the *current* table. From here, you can either terminate with a field or do another join.

You can have as many columns as you want! You can also build an arbitrarily complex and deep query structure. However, if the query takes too long to run, it will time out and the script will end.

If you specify the same join in multiple columns, then you mean fields from the same target (no aliasing).

## Defining your starting point

Any search has to start somewhere. You need to put your boot on the ground before you start exploring. You set your point like this:

```crmscript
// syntax
starttablename.fieldname

// example
ticket.title
```

## Go to a related table

If the current table has foreign keys to other tables, you can reach those tables by automatically joining with dot-syntax.

```crmscript
// syntax
starttablename.fieldname.fieldname

// examples
ticket.cust_id.firstname
ticket.cust_id.company.name
```

## Many-to-many relations

If there is a many-to-many relationship between 2 tables, we need a special notation for the join. The connector is a field in the target table that has a foreign key to the current table.

```crmscript
// syntax
table1.(table2->field2a).field2b

// example
ticket.(ticket_customers->ticket_id).cust_id
```

If we break down the details:

* the `ticket` table (table1) is our current table, origin
* the `ticket_customers` table (table2) is the target table (destination)
* we want to access the `cust_id` field (field2b) in `ticket_customers`
* to join, we use the `ticket_id` field (field2a) in `ticket_customers` and follow this foreign key back to the `ticket` table

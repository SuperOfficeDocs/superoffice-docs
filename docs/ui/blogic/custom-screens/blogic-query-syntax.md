---
title: Query syntax
uid: crmscript_blogic_query_syntax
description: Query syntax
author:
so.date:
keywords:
so.topic:
---

# Query syntax

Custom screens use a line-based query syntax that is specific to SuperOffice. You don't have to construct complicated SQL queries, which may vary from one database vendor to another.

A query is defined by adding select-lines, where-lines, and order-lines. Joins are defined by the fields used in the query.

## Elements

* A set of fields
* A set of criteria (where-conditions)
* A set of orders

## Dot-notation

**Dot-notation** is a way of specifying columns, tables, and joins across the entire data dictionary (including partner tables). It is extremely powerful and almost unlimited.

There is always 1 root table, and it is the same for all columns.

### Defining your starting point

Any search has to start somewhere. You need to put your boot on the ground before you start exploring. You set your point like this:

```crmscript
// syntax
starttablename.fieldname

// example
ticket.title
```

Read more about [joins and relations][1].

## Criteria

Conditions, or **where-clauses**, are constructed from 0 or more lines.

Each line contains a field, an operator, a value, a row-operator, and an indent.

* The **field** is compared to the **value** using the **operator**.
* The **row-operator** is used to relate this line to the next line ("OR" or "AND")
* The **indent** value is used for specifying parentheses around the conditions.

```crmscript
"ticket.status", "OperatorEquals", "1", "OperatorAnd", 0
"ticket.owned_by", "OperatorEquals", "2", "OperatorOr, 1
"ticket.owned_by", "OperatorEquals", "3", "OperatorOr, 1
```

These lines will construct the following SQL:

```sql
"ticket.status = '1' and (ticket.owned_by = 2 or ticket.owned_by = 3)"
```

| Value                | Description                        |
|:---------------------|:-----------------------------------|
| fields.length        | The number of fields to query      |
| fields.n.field       | The field n to fetch               |
| where.length         | The number of where conditions     |
| where.n.field        | The field for where condition n    |
| where.n.operator     | The operator                       |
| where.n.value        | The value                          |
| where.n.valueId      | If true, the active ID for the page will be used for the value |
| where.n.rowOperator  | The row operator                   |
| where.n.critPriority | The indent of the row              |
| order.length         | The number of order fields         |
| order.n.field        | The field to order by              |
| order.n.direction    | The sort order<br>"asc" or "desc" |
| limit                | Limits the number of found rows    |

### Indents

When reading the lines from top to bottom, add parentheses as follows:

* Whenever the indent **increases** from a line to the next, add a **left** parenthesis.
* Whenever the indent **decreases** from a line to the next, add a **right** parenthesis.

## bLogic vs. CRMScript

How you format each line depends on whether you're in a CRMScript or configuring a bLogic element.

Different screen elements offer different functionality and use their own naming conventions.

### Example

**CRMScript:**

```crmscript
SearchEngine se;
se.addField("ticket.id");
se.addField("ticket.title");
se.addField("ticket.category.fullname");
se.addField("ticket.cust_id.company.our_contact.email");

se.addCriteria("ticket.category", "OperatorEquals", "10", "OperatorAnd");
se.addCriteria("ticket.title", "OperatorBeginsWith", "test", "OperatorAnd");

se.addOrder("ticket.id", true); // true = Ascending
```

**Blogic:**

```crmscript
fields.length = 4
fields.0.field = ticket.id
fields.1.field = ticket.title
fields.2.field = ticket.category.fullname
fields.3.field = ticket.cust_id.company.out_contact.email

criteria.length = 2
criteria.0.field = ticket.category
criteria.0.operator = OperatorEquals
criteria.0.value = 10
criteria.0.rowOperator = OperatorAnd
criteria.0.indent = 0
criteria.1.field = ticket.title
criteria.1.operator = OperatorBeginsWith
criteria.1.value = test
criteria.1.rowOperator = OperatorAnd
criteria.1.indent = 1

order.length = 1
order.0.direction = asc
```

<!-- Referenced links -->
[1]: ../../../../crmscript/docs/searchengine/dot-syntax.md

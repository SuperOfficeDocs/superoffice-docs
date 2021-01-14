---
title: Database basics
uid: search_engine_basics
SortOrder: 10
---

A quick intro to relational database terms in general and the SuperOffice database in particular.

> [!TIP]
> If you are familiar with SQL Server or have a general working knowledge about databases, this section is probably not for you.

## Table, row, column

A database is a logical data structure where data is organized into tables. Each table is organized into rows and columns.

A database row, also known as a record, contains a set of related values. The columns are named data of a particular data type - they declare the pieces of information you can put in a record.

## Relationships

**Keys** are very important in relational databases, because they uniquely identify a row within a table and also establish the link between tables.

The **primary key** (PK) is a column (or a group of columns) in table T that uniquely identifies a record (table row) within T.

A **foreign key** (FK) is 1 or more columns in table T containing values that match the primary key of a related table U.

Foreign and primary keys explicitly define the direct relationships between tables.

As a general principle, the SuperOffice database is very lax.

* There are no declared constraints on tables.
* Referential integrity is not strictly enforced.
* We break the 3rd normal form (a database design principle) by storing both the `contact_id` and the `person_id` in the appointment to make the database more efficient.

## Join

To benefit from the combined data from related tables, they must be **joined** to form a set. This operation combines the columns from the different tables by comparing the FK value in a row of table T to the PK value of table U.

### Common joins in SuperOffice

| Table T key              | Table U key            |
|--------------------------|------------------------|
| Appointment.contact_id   | Contact.contact_id     |
| Appointment.person_id    | Person.person_id       |
| Appointment.project_id   | Project.project_id     |
| Appointment.associate_id | Associate.associate_id |
| Person.contact_id        | Contact.contact_id     |
| Associate.person_id      | Person.person_id       |
| Ticket.cust_id           | person.person_id       |

### Types of join

* Natural join - happens if 2 columns have identical names and definition *and* their values are equal

* Inner join - includes only the rows with matching FK and PK in the set (syntax: use a colon)

* Outer join - includes both rows that match and those that don't.
  * A **left** outer join  includes the result of an inner join plus the remaining rows of table T (syntax: use a dot/period)
  * A **right** outer join includes the result of an inner join plus the remaining rows of table U (syntax: use an arrow ->)

## Queries

When you add fields and criteria to SearchEngine, you actually build an SQL query. This is a complete SELECT statement, which specifies:

* the columns and tables to fetch data from
* conditions that the data must meet
* computations that are to be performed on the retrieved column values
* how you want the results ordered

Only the 1st of the above 4 elements is mandatory, the rest are optional.

```sql
SELECT select_list
[ FROM table_source ] [ WHERE search_condition ]
[ GROUP BY group_by_expression ]
[ HAVING search_condition ]
[ ORDER BY order_expression [ ASC | DESC ] ]
```

## Indexes

If you need fast access to a table's rows, it is possible to create an index, a separate structure over selected columns. It is an efficient way to retrieve data, but adds complexity and cost to changing data. An analog equivalent would be the alphabetic list of topics with page-references you find at the back of an encyclopedia.

An index can only be added to database table columns in onsite installations, where customers have direct access to the database server. Indexes can, however, be added to extra fields both in onsite and online in the extra field settings.

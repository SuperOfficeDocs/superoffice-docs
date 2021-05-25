---
title: How to use SELECT in OSQL
uid: osql_select_howto
description: SuperOffice Objectified SQL - SELECT
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# How to use SELECT in OSQL

Here we will show how we may use the SELECT statement of OSQL to retrieve a selected amount of rows and columns.

The SELECT statement is similar to one that is used in SQL. The main difference is the differentiation of keywords.

## Example 1

[!code-csharp[CS](includes/select-1.cs)]

### TablesInfo

To write any OSQL statement, we have to know about the tables that we are going to pull data from. So for us to get the information on a data table, NetServer has provided us the `TablesInfo` class. Through this class, we can pull out information on any table in the SuperOffice database to an appropriate table object.

In the example, the following line will retrieve the contact table information.

[!code-csharp[CS](includes/select-1.cs?range=10)]

### Select object (S class)

Next, it is worth mentioning the functionality of the static `S` class. This class is used to create the objects for SQL types (Select, Insert, Delete), the parameter object, and different math objects.

In the example, we are developing a SELECT statement, so here we will create a `Select` object through the `S` class.

[!code-csharp[CS](includes/select-1.cs?range=13)]

### Build query

Now that you have all the table information you need and you have a select object, you can start building your select query.

Add the **return fields** as shown in the example and you can add a **restriction** and give the restriction parameters through the `Select` class.

You can **sort** your results by using the functionality of `SuperOffice.Util.OrderBySortType` class.

When you have created your query, all that is left is to execute this query on the database.

### Run query

To execute this query, you have to have a connection, a command, and a reader to hold the data like any other normal SQL statement. The only difference is that all these should be NetServer provided objects like in the above example.

### Reader

Finally, when you have executed the query, the data will be held in the reader and you can retrieve the data from the [NetServer data reader][1] as shown in the example.

## Example 2

The above example of the select statement is very simple, so now let us look at a more complex select example.

[!code-csharp[CS](includes/select-2.cs)]

Here, we retrieve contacts information from more than one table to show how we can incorporate a join to the select statement.

The `Select` object has all the methods to create all the join statements that exist in SQL. It is a matter of creating the type of join you want and joining the tables (in a logical way) just as in a normal SQL statement.

### Create objects of tables being joined

[!code-csharp[CS](includes/select-2.cs?range=8-11)]

`Contact`, `Person`, `Email`, and `Country` tables of the database have being used by the `Select` statement to retrieve the data required. With the use of the above statement, objects of these tables have being created.

### newSelect.ReturnFields

To retrieve that data we make use of the `Select` class.

[!code-csharp[CS](includes/select-2.cs?range=14)]

Using the `ReturnFields` property of the `Select` class, we specify the columns that we intend to retrieve from the SELECT statement.

[!code-csharp[CS](includes/select-2.cs?range=16)]

### Restriction

> [!NOTE]
> If you have more than one table, you can use those tables in the restriction statement as well.

When it comes to adding the restrictions, you can:

* Use any field from any table
* Include a AND statement
* Include an OR statement
* Include both

This works just as a normal SQL statement. So though you use the NetServer OSQL statements, the power of normal SQL is not restricted.

To restrict the number of rows returned by the query, we use the `Restriction` property exposed by the `Select` class. This statement is similar to that of a WHERE clause in SQL.

[!code-csharp[CS](includes/select-2.cs?range=19)]

### Join

Since we have used multiple tables to retrieve the data, we are now required to join these tables. This can be with the use of the `JoinRestriction` property:

[!code-csharp[CS](includes/select-2.cs?range=22-24)]

This property consist of methods that are capable of acting as inner join, left outer join, and so on in SQL terms. For this, we need to have knowledge about the database structure since we need to know how the tables are connected. Here we have used the `ContactId` of the `contact` table to join ID to the `person`, `email`, and `country` tables.

### OrderBy

The ORDERBY statement at the end is used to sort the returned rows in the ascending order of the contact’s name.

### SoDataReader

Once the SELECT statement is complete, we may use the `SoDataReader` to retrieve the returned data.

> [!NOTE]
> OSQL also provides **Aggregate functions** as well as **Mathematical functions**, though we have not looked at them in the above examples. These are also available through the `Math` and `FieldExpression` properties of the static class, which holds methods like `Count()`, `Distinct()`, `Max()`, and `Min()`. The only thing that restricts what data you can get out of the SuperOffice database using OSQL, is your knowledge of the database structure, which is a field of study on its own.

<!-- Referenced links -->
[1]: ../so-data-reader.md

---
title: How to use DELETE in OSQL
uid: osql_delete_howto
description: SuperOffice Objectified SQL - DELETE
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# How to use DELETE in OSQL

To delete data using OSQL, we would need to use the `Delete` class located in the `SuperOffice.SQL.Data` namespace.

This example shows how we use the DELETE command in OSQL.

[!code-csharp[CS](includes/delete-1.cs)]

[!include[ALT](includes/setup.md)]

Then we create aliases of the tables, which we need to delete the data. In this example, we have created an alias of the `contacts` table using the `TablesInfo` factory class.

## Instantiate class

Now, need to create an instance of the `Delete` class. This is similar to that of when [creating a Select class][2].

[!code-csharp[CS](includes/delete-1.cs?range=26)]

## Set primary key

Next, we need to set the primary key for the DELETE command:

[!code-csharp[CS](includes/delete-1.cs?range=28)]

The `SetPrimaryKey` method will set the primary key for the DELETE command. However, this will throw an exception if the value is not of `FieldInfo` type and is a primary key.

Now, with the below statement, we would set the value for the primary key (the row we need to delete). The value should be an `Int` type, if not it would throw an exception.

The `ContactId` where it is equal to 122 is deleted in the example as it has been passed to the `Delete` class with the use of the `Parameter` method of the `S` class.

[!code-csharp[CS](includes/delete-1.cs?range=29)]

## Execute

To execute the DELETE command, we would assign the created `Delete` class instance to the `SQlCommand` property of the created instance of the `SoCommand`. Then, we would use `ExecuteNonQuary()` to execute the SQL command against the connection object.

<!-- Referenced links -->
[2]: using-select.md

---
title: osql_update_howto
description: SuperOffice Objectified SQL - UPDATE
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# How to use UPDATE in OSQL

To update data using OSQL, we would need to use the `Update` class located in the `SuperOffice.Data` namespace.

This example shows how we use the UPDATE command in OSQL to modify existing data.

[!code-csharp[CS](includes/update-1.cs)]

[!include[ALT](includes/setup.md)]

Then we create aliases of the tables, which we need to update the data using the `TablesInfo` factory class.

## Instantiate class

Now, we need to create an instance of the `Update` class. This is similar to that of when [creating a Select class][2].

[!code-csharp[CS](includes/update-1.cs?range=27)]

## Set primary key

Next, we need to set the primary key for the UPDATE command:

[!code-csharp[CS](includes/update-1.cs?range=30)]

The `SetPrimaryKey` method will set the primary key for the UPDATE command. However, this will throw an exception if the value is not of `FieldInfo` type and is a primary key.

Now, with the below statement, we would set the value for the primary key (the row we need to update). The value should be an `Int` type, if not it would throw an exception.

The `ContactId` where it is equal to 10 is updated in the example as it has been passed to the `Update` class with the use of the `Parameter` method of the `S` class.

[!code-csharp[CS](includes/update-1.cs?range=31)]

## Assign new values to the fields

The next step is to assign the new values for the fields in the `contact` table. For this, we use the `FieldValuePairs` property exposed in the `Update` class.

The following statements show how we may update different data types that are found in the `contact` table.

[!code-csharp[CS](includes/update-1.cs?range=34-42)]

> [!NOTE]
> All values retrieved from the `FieldValuePairs` property are of database data types such as `Varchar`, `Int`, and `Boolean`.

## Execute

To execute the UPDATE command, we would assign the created `Update` class instance to the `SQlCommand` property of the created instance of the `SoCommand`. Then, we would use `ExecuteNonQuary()` to execute the SQL command against the connection object.

> [!NOTE]
> If you try to update the primary key of the table, it would produce an exception when the compiler reaches the `ExecuteNonQuary` method.

<!-- Referenced links -->
[2]: using-select.md
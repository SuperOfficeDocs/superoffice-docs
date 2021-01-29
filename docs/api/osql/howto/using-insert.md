---
title: osql_insert_howto
description: SuperOffice Objectified SQL - INSERT
author: {github-id}
so.date: 11.05.2016
keywords: 
so.topic: howto
---

# How to use INSERT in OSQL

To insert data using OSQL, we would need to use the `Insert` class located in the `SuperOffice.Data` namespace.

The examples demonstrate how we may insert data using the INSERT statement.

> [!NOTE]
> When inserting data into any table (adding a new row), all the mandatory columns in the database should be filled. Otherwise, a runtime exception will be thrown.

## Example 1

[!code-csharp[CS](includes/insert-1.cs)]

[!include[ALT](includes/setup.md)]

Then we create aliases of the tables, which we need to update the data using the `TablesInfo` factory class.

[!code-csharp[CS](includes/insert-1.cs?range=19)]

### Instantiate class

Now, we need to create an instance of the `Insert` class. This is similar to that of when [creating a Select class][2].

[!code-csharp[CS](includes/insert-1.cs?range=25)]

### Assign values to the fields

To insert values the FieldValuePairs property of the Insert class is used as below.

[!code-csharp[CS](includes/insert-1.cs?range=28-29)]

### Begin transaction

After all the data has been inserted, the next step is to begin a transaction so that the database table will be updated without any inconsistency. For that, an instance of the `SoTransaction` class is created and the transaction is started with the use of the `BeginTransaction()` method found in the created instance of the `SoConnection`.

The created `SoTransaction` instance is then assigned to the `Transaction` property of the created instance of the `SoCommand`.

To execute the INSERT command, we would assign the created `Update` class instance to the `SQlCommand` property of the created instance of the `SoCommand`. Then, we would use `ExecuteNonQuary()` to execute the SQL command against the connection object.

[!code-csharp[CS](includes/insert-1.cs?range=37-43)]

Finally, to complete the above transaction, the `Commit` method is used. It it is found in the created instance of the `SoTransaction`.

The last statement is to close the established `SoConnection` with the use of the `Close` method.

## Example 2

This example shows how we may add a new contact to the `contact` table.

[!code-csharp[CS](includes/insert-2.cs)]

To insert data, we are required to create an instance of the `Insert` class and then use the `fieldValuePairs` property of it. The data has been added using the `Add()` method exposed in the `FieldValuePairs` property:

[!code-csharp[CS](includes/insert-2.cs?range?15-16)]

Special attention should be given when inserting the contact ID. Using the `Sequence` class’s `GetNext` method, the next contact ID is retrieved and assigned to the `ContactId` of the inserting record.

Once all the required fields are filled, add a connection to the database.

Then the created insert statement will be assigned to a created instance of the `SoCommands`’s `SqlCommand` property.

With the `ExecuteNonQuery` method of the `SoCommand`, the insert statement will be executed and the data will be added to the tables.

[!code-csharp[CS](includes/insert-2.cs?range?32-33,36-37,40-41)]

<!-- Referenced links -->
[2]: using-select.md
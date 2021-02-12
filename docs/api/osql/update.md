---
title: osql_update
description: SuperOffice Objectified SQL - UPDATE
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# UPDATE

So far we have been expressing how data is retrieved from the database. Here, we will explain how data is updated.

The example below demonstrates how to write the following SQL query in SuperOffice Objectified SQL.

```SQL
UPDATE CRM.associate SET name = 'Test Update' WHERE (associate_id = 103)
```

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession newSession = SoSession.Authenticate ("SAL0", ""))
{

  //Create a new connection
  SoConnection connection = ConnectionFactory.GetConnection ();
  SoCommand command = connection.CreateCommand ();
  connection.Open ();

  //Create a transaction
  SoTransaction Trans = connection.BeginTransaction ();
  command.Transaction = Trans;
  AssociateTableInfo a = TablesInfo.GetAssociateTableInfo ();
  Update update = S.NewUpdate ();

  //Set the row that needs to be updated
  update.SetPrimaryKey (a.AssociateId);
  update.SetPrimaryKeyValue (S.Parameter (103));
  update.FieldValuePairs.Add (a.Name, S.Parameter ("Test Update"));
  command.SqlCommand = update;
  command.ExecuteNonQuery ();

  //Commit the transaction. The database will not be updated till then.
  Trans.Commit ();
}
```

After opening the connection we have to create an instance of `SoTransaction`. Instead of `Select`, here we create an `Update` object.

You have to specify the table and the primary key that will be updated by using the `SetPrimaryKey` method. By providing the value of that primary key we can select the exact row.

Once the field and the value that is being updated are entered, you can set the `SqlCommand` property of the `SoCommand` instance to the newly created `Update` instance.

> [!NOTE]
> Unless you commit the `Transaction`, the database will not be updated.

See Also: Update SoTransaction TablesInfo

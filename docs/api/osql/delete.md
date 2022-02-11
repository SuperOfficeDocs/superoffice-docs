---
title: DELETE
uid: osql_delete
description: SuperOffice Objectified SQL - DELETE
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# DELETE

Deleting a particular row from a table is also an important action in database handling.

The following example shows how a particular row in the `Associate` table is deleted. You can compare the SQL query with the SuperOffice Objectified SQL.

```SQL
DELETE FROM CRM.associate WHERE (associate_id = 103)
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
  SoTransaction trans = connection.BeginTransaction ();
  command.Transaction = trans;
  AssociateTableInfo a = TablesInfo.GetAssociateTableInfo ();
  Delete delete = S.NewDelete ();
  //Select the exact row to be deleted
  delete.SetPrimaryKey (a.AssociateId);
  delete.SetPrimaryKeyValue (S.Parameter (103));
  command.SqlCommand = delete;
  command.ExecuteNonQuery ();
  trans.Commit ();
}
```

---
title: osql_insert
description: SuperOffice Objectified SQL - INSERT
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: concept
---

# INSERT

Inserting data is a very important transaction in database handling. SuperOffice Objectified SQL has its own classes and methods written to handle this function so that you do not need to worry about the underlying database when inserting data into the database.

The following example shows how to insert data into the database using SuperOffice Objectified SQL.

```SQL
INSERT INTO CRM.associate(associate_id, name, group_idx, lastlogin,
  lastlogout, person_id, checklistlimit, registered_associate_id,
  updated, updated_associate_id, updatedCount, registered)

  VALUES (112, 'INSERT Test', 2, CONVERT(int, GETDATE()),
  CONVERT(int, GETDATE()), 4, CONVERT(int, GETDATE()), 2,
  CONVERT(int, GETDATE()), 2, 4, CONVERT(int, GETDATE()))
```

```csharp
using SuperOffice.Data;
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a new connection
  SoConnection connection = null;
  SoCommand command = null;

  connection = ConnectionFactory.GetConnection();
  command = connection.CreateCommand();
  connection.Open();

  AssociateTableInfo myAssociate = TablesInfo.GetAssociateTableInfo();
  Insert insert = S.NewInsert();

  //Add the fields for which the values need to be assigned.
  insert.FieldValuePairs.Add(myAssociate.AssociateId,S.Parameter(Sequence.GetNext(myAssociate)));
  insert.FieldValuePairs.Add(myAssociate.Name,S.Parameter("Insert Test"));
  insert.FieldValuePairs.Add(myAssociate.GroupIdx,S.Parameter(2));
  insert.FieldValuePairs.Add(myAssociate.Lastlogin,S.Parameter(DateTime.Now));
  insert.FieldValuePairs.Add(myAssociate.Lastlogout,S.Parameter(DateTime.Now));
  insert.FieldValuePairs.Add(myAssociate.PersonId,S.Parameter(4));
  insert.FieldValuePairs.Add(myAssociate.Checklistlimit,S.Parameter(DateTime.Now));
  insert.FieldValuePairs.Add(myAssociate.RegisteredAssociateId,S.Parameter(2));
  insert.FieldValuePairs.Add(myAssociate.Updated,S.Parameter(DateTime.Now));
  insert.FieldValuePairs.Add(myAssociate.UpdatedAssociateId,S.Parameter(2));
  insert.FieldValuePairs.Add(myAssociate.UpdatedCount,S.Parameter(2));
  command.SqlCommand = insert;

  //Execute the query
  int res = command.ExecuteNonQuery();
}
```

We have initially created a connection using `SoConnection` class.

An instance of the `Insert` class needs to be created and `FieldValuePairs` need to be added.

Once the command is executed, new data will be inserted into the database.

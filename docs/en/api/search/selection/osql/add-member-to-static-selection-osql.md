---
title: How to add members to a static selection using OSQL
uid: add_members_static_selection_osql
description: How to add members to a static selection using OSQL
author: SuperOffice Product and Engineering
date: 05.11.2016
keywords: search, osql, selectionmember
content_type: howto
redirect_from:
  - /en/api/search/selection/osql/index
  - /en/api/netserver/search/selection/osql/add-member-to-static-selection-osql
  - /en/api/netserver/search/selection/osql
---

# How to add members to a static selection using OSQL

[!include[import OSQL namespaces](../../../includes/using-osql.md)]

At this level of the NetServer, you need to have a very good understanding of the SuperOffice database so you create the correct table info objects to insert or update the database table.

## Example 1

```csharp
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //get a connection to connect to the DB.
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating a SoCommand instance
  SoCommand myComm = myConn.CreateCommand();

  //open the connection
  myConn.Open();

  //Creating DataSets with the Tables of the Database
  SelectionMemberTableInfo selectionMemTableInfo =
  TablesInfo.GetSelectionMemberTableInfo();

  //Creating an instance of the Insert class
  Insert newInsert = S.NewInsert();

  //lets add two member to the static selection we choose
  //add the first member
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionmemberId, S.Parameter(Sequence.GetNext(selectionMemTableInfo)));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionId,S.Parameter(65));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.ContactId,S.Parameter(21));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.PersonId,S.Parameter(55));

  //Begin Transaction
  SoTransaction newTrans = myConn.BeginTransaction();
  myComm.Transaction = newTrans;

  //Executing the Insert Statement
  myComm.SqlCommand = newInsert;
  myComm.ExecuteNonQuery();

  //Committing the transaction and closing the session
  newTrans.Commit();
  myConn.Close();
}
```

In this example, we are only adding members to a static selection so we have created a `SelectionMemberTableInfo` object since we know that the data gets inserted into the `SelectionMember` table.

If you analyze the above code carefully, you can observe that we have used a class called `Sequence` to get the next sequence of the `SelectionMember` table. This class will help you to get the next sequence number of any table if you provide the correct table info.

## Example 2

In example 1, you may have noticed that we have only added one member to the static selection. If we want to add more than one member, we cannot do it with only the above mechanisms you will have to use some other ways to do it.

```csharp
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //get a connection to connect to the DB.
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating a SoCommand instance
  SoCommand myComm = myConn.CreateCommand();

  //open the connection
  myConn.Open();

  //Creating DataSets with the Tables of the Database
  SelectionMemberTableInfo selectionMemTableInfo =
  TablesInfo.GetSelectionMemberTableInfo();

  //Creating an instance of the Insert class
  Insert newInsert = S.NewInsert();
  Insert secondInsert = S.NewInsert();

  //lets add two member to the static selection we choose
  //add the first member
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionmemberId , S.Parameter(Sequence.GetNext(selectionMemTableInfo)));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionId, S.Parameter(65));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.ContactId, S.Parameter(21));
  newInsert.FieldValuePairs.Add(selectionMemTableInfo.PersonId, S.Parameter(55));

  //add the second member
  secondInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionmemberId, S.Parameter(Sequence.GetNext(selectionMemTableInfo)));
  secondInsert.FieldValuePairs.Add(selectionMemTableInfo.SelectionId, S.Parameter(65));
  secondInsert.FieldValuePairs.Add(selectionMemTableInfo.ContactId, S.Parameter(21));
  secondInsert.FieldValuePairs.Add(selectionMemTableInfo.PersonId, S.Parameter(56));

  //create a batch save object
  BatchSave myBatchSave = new BatchSave();

  //add the insert statements to the created batch save object
  myBatchSave.Add(newInsert);
  myBatchSave.Add(secondInsert);

  //Begin Transaction
  SoTransaction newTrans = myConn.BeginTransaction();
  myComm.Transaction = newTrans;

  //assign the batch save object as teh SQL command
  myComm.SqlCommand = myBatchSave;

  //Executing the batch save
  myComm.ExecuteNonQuery();

  //Committing the transaction and closing the session
  newTrans.Commit();
  myConn.Close();
}
```

If you analyze this example, you can observe that we have made 2 additional changes:

* We created a new insert object and added the second member through that
* We created a new object calling the batch save

This new **batch save object** holds the secret to adding more than one member to a static selection. A batch save object can hold many SQL statements for us. It acts as an array of SQL statements. In this case, it holds 2 insert statements for us. So when we add our SQL statements to the batch save object and then assign the batch save object as our SQL command in the SO command object. Now when we execute our query the NetServer will do the rest for us. It will add the 2 records to the `SelectionMember` table with the correct selection member ID.

[!include[ALT](../includes/note-hardcoding-id.md)]

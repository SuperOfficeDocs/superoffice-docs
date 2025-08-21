---
uid: update-person-osql
title: Update a person with new name, address, position using OSQL
description: How to update a person with new name, address, position using OSQL.
keywords: person, contact, API, OSQL, update
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/contact/howto/osql/update-person-osql
  - /en/api/netserver/osql/howto/contact/update-person-osql
---

# Update a person with a new name, address, position using OSQL

[!include[import OSQL namespaces](../../../includes/using-osql.md)]

## Code

The following example uses OSQL exclusively.

```csharp
using SuperOffice.CRM.Data;
using SuperOffice.Data.SQL;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating and SoCommand instance
  SoCommand myComm = myConn.CreateCommand();
  myConn.Open();

  //Begin Transaction
  SoTransaction newTrans = myConn.BeginTransaction();
  myComm.Transaction = newTrans;

  //retrieve the person table info
  PersonTableInfo newPerTable = TablesInfo.GetPersonTableInfo();

  //retrieve the address table info
  AddressTableInfo newAddTable = TablesInfo.GetAddressTableInfo();

  //Creating an Instance of the Update Class of the person table
  Update newPerUpdate = S.NewUpdate();

  //Creating an Instance of the Update Class of the address table
  Update newAddUpdate = S.NewUpdate();

  //Retrieve the person with personid "17" to make the update
  newPerUpdate.SetPrimaryKey(newPerTable.PersonId);
  newPerUpdate.SetPrimaryKeyValue(S.Parameter(17));

  //Retrieve the address of the personid "17" to make the update.
  //here we assume that we know the address id of the person
  newAddUpdate.SetPrimaryKey(newAddTable.AddressId);
  newAddUpdate.SetPrimaryKeyValue(S.Parameter(9));

  //Making the necessary updates in the persons table
  newPerUpdate.FieldValuePairs.Add(newPerTable.Firstname, S.Parameter("Johan"));
  newPerUpdate.FieldValuePairs.Add(newPerTable.Lastname, S.Parameter("White"));
  newPerUpdate.FieldValuePairs.Add(newPerTable.PositionIdx, S.Parameter(1));

  //Making the necessary updates in the address table
  newAddUpdate.FieldValuePairs.Add(newAddTable.Address1, S.Parameter("No: 73"));
  newAddUpdate.FieldValuePairs.Add(newAddTable.Address2, S.Parameter("West Gate Street"));
  newAddUpdate.FieldValuePairs.Add(newAddTable.Address3, S.Parameter("Lexington"));
  newAddUpdate.FieldValuePairs.Add(newAddTable.City, S.Parameter("Kentucky"));

  //create a batch save instance
  BatchSave myBatchSave = new BatchSave();
  myBatchSave.Add(newPerUpdate);
  myBatchSave.Add(newAddUpdate);

  //Make the Database Update
  myComm.SqlCommand = myBatchSave;
  myComm.ExecuteNonQuery();

  //Commit the transaction and close the session
  newTrans.Commit();
  myConn.Close();
}
```

## Walk-through

If we have to update several tables, we need several update instances. Above, we have 2 update instances for the 2 tables. We have given the update values separately in the update instances we have created for the 2 tables. When we have more than one command to be executed against the database, we have to use the batch save instance since it can hold many SQL commands.

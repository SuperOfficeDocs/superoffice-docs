---
uid: get-person-from-contact-sodatareader
title: Retrieve a list of people using SODataReader
description: How to retrieve a list of people using SODataReader.
keywords: person, contact, SoReader, SODataReader, API, OSQL
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/contact/howto/osql/get-persons-from-contact-sodatareader
  - /en/api/netserver/osql/howto/contact/get-persons-from-contact-sodatareader
---

# Retrieve a list of people using SODataReader

[!include[ALT](../../../includes/note-using-sodatareader.md)]

```csharp
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice.CRM.Data;
using(SuperOffice.SoSession session =
SuperOffice.SoSession.Authenticate("SAL0", ""))
{
  //Using the Select Statement in order to retrieve Data
  //Creating DataSets with the Tables of the Database
  ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();
  PersonTableInfo newPerTable = TablesInfo.GetPersonTableInfo();

  //Retrieving Data from a the tables in to a Instance of the Select Class
  Select newSelect = S.NewSelect();

  //Choosing the columns that should be retrieved
  newSelect.ReturnFields.Add(newPerTable.Firstname,newPerTable.Lastname);

  //Restricting the rows that should be returned
  newSelect.Restriction = newConTable.ContactId.In(S.Parameter(21));

  //Joining the multiple tables
  newSelect.JoinRestriction.InnerJoin(newConTable.ContactId.Equal(newPerTable.ContactId));

  //Ordering the retrieved Data
  newSelect.OrderBy.SortOrder.Add(newPerTable.Firstname, SuperOffice.Util.OrderBySortType.ASC);

  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating and SoCommand instance and assigning the earlier created Select statement
  SoCommand myComm = myConn.CreateCommand();
  myComm.SqlCommand = newSelect;

  //open the connection
  myConn.Open();

  //Loading the Data into the DataReader
  SoDataReader myReader = myComm.ExecuteReader();

  //Retrieving the Data from the Reader
  while (myReader.Read())
  {
    //lets iterate through record returned and access the individual fields returned 
    mbPersonName.Items.Add((string)myReader[newPerTable.Firstname] + " " + myReader[newPerTable.Lastname]);
  }

  //Closing the Reader and Disposing the session
  myReader.Close();
  session.Dispose();
}
```

For us to get a list of persons for a given contact, we need the `contact` table and the `persons` table. In the above example, first, we have created 2 table info objects we need. Once we have the table info objects we can start building our select statement.

We start by specifying the return fields, the restriction we want (`Contact_Id = 21`) and then we join the 2 tables. Here we join the `contact` table and the `persons` table with contact ID.

Then we can order the results of our select statement, in this case by the `FirstName` in the ascending order. You can leave the ordering out if you prefer.

Now we can execute the reader and get our results to an `SoReader` object. Once you have the records in the reader, you can loop through the results and access individual fields returned. Here, we have concatenated the first name and the last name of the person records returned and assigned to a combo box.

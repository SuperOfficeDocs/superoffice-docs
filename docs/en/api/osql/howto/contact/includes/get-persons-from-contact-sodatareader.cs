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
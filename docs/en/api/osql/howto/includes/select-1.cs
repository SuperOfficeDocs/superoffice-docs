using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  //Using the Select Statement to retrieve Data
  //Creating DataSets with the Tables of the Database
  ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();
  //Retrieving Data from the tables into an Instance of the Select Class
  Select newSelect = S.NewSelect();
  //Choosing the columns that should be retrieved
  newSelect.ReturnFields.Add(newConTable.ContactId, newConTable.Department, newConTable.Name);
  //Restricting the rows that should be returned
  newSelect.Restriction = newConTable.ContactId.In(S.Parameter(5), S.Parameter(6));
  //Ordering the retrieved Data
  newSelect.OrderBy.SortOrder.Add(newConTable.Name, SuperOffice.Util.OrderBySortType.ASC);
  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();
  //Creating and SoCommand instance and assigning the earlier created Select statement
  SoCommand myComm = myConn.CreateCommand();
  myComm.SqlCommand = newSelect;
  myConn.Open();
  //Loading the Data into the DataReader
  SoDataReader myReader = myComm.ExecuteReader();
  //Retrieving the Data from the Reader
  while (myReader.Read())
  {
    int conID = myReader.GetInt32(0);
    string conDept = myReader.GetString(1);
    string conName = myReader.GetString(2);
  }

  //Closing the Reader and Disposing the session
  myReader.Close();
}
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
//Using the Select Statement to retrieve Data
//Creating DataSets with the Tables of the Database
ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();
PersonTableInfo newPerTable = TablesInfo.GetPersonTableInfo();
EmailTableInfo newEMLTable = TablesInfo.GetEmailTableInfo();
CountryTableInfo newCouTable = TablesInfo.GetCountryTableInfo();
//Retrieving Data from a the tables in to a Instance of the Select Class
Select newSelect = S.NewSelect();
//Choosing the columns that should be retrieved
newSelect.ReturnFields.Add(newConTable.ContactId, newConTable.Department, newConTable.Name, newPerTable.Firstname, newPerTable.Lastname, newPerTable.PhonePresent, newEMLTable.EmailAddress, newEMLTable.Description, newCouTable.EnglishName);
//Restricting the rows that should be returned
newSelect.Restriction = newConTable.ContactId.In(S.Parameter(5),S.Parameter(6)).And (newPerTable.ContactId.LessThan(S.Parameter(9)));
//Joining the multiple tables
newSelect.JoinRestriction.InnerJoin(newConTable.ContactId.Equal(newPerTable.ContactId));
newSelect.JoinRestriction.LeftOuterJoin(newConTable.ContactId.Equal(newEMLTable.ContactId));
newSelect.JoinRestriction.LeftOuterJoin(newConTable.CountryId.Equal(newCouTable.CountryId));
//Ordering the retrieved Data
newSelect.OrderBy.SortOrder.Add(newConTable.Name, SuperOffice.Util.OrderBySortType.ASC);
using(SoSession mySession = SoSession.Authenticate("SAM", "sam"))
{
  if (mySession == null) return;
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
    string conDept = myReader.GetString(1);
    string conName = myReader.GetString(2);
    string perName = myReader.GetString(3) + " " + myReader.GetString(4);
    string perPhone = myReader.GetInt16(5).ToString();
    string conEmail = myReader.GetString(6);
    string conEmlDesc = myReader.GetString(7);
    string conCou = myReader.GetString(8);
  }
  //Closing the Reader and Disposing the session
  myReader.Close();
  mySession.Dispose();
}

using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAM", "sam"))
{
  if (mySession == null) return;

  //Using the Insert Statement to Add new Data
  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating and SoCommand instance and assigning the earlier created Select statement
  SoCommand myComm = myConn.CreateCommand();
  myConn.Open();

  //Begin Transaction
  SoTransaction newTrans = myConn.BeginTransaction();
  myComm.Transaction = newTrans;

  //Creating DataSets with the Tables of the Database
  ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();

  //Creating an Instance of the Update Class
  Update newUpdate = S.NewUpdate();

  //Retrieve the Contact with ContactID "10" to make the update
  newUpdate.SetPrimaryKey(newConTable.ContactId);
  newUpdate.SetPrimaryKeyValue(S.Parameter(10));

  //Making the necessary update                                
  NewUpdate.FieldValuePairs.Add(newConTable.ActiveInterests, S.Parameter(3));
  newUpdate.FieldValuePairs.Add(newConTable.AssociateId, S.Parameter(5));
  newUpdate.FieldValuePairs.Add(newConTable.BusinessIdx, S.Parameter(7));
  newUpdate.FieldValuePairs.Add(newConTable.CategoryIdx, S.Parameter(4));
  newUpdate.FieldValuePairs.Add(newConTable.CountryId, S.Parameter(4));
  newUpdate.FieldValuePairs.Add(newConTable.Department, S.Parameter("Testing"));
  newUpdate.FieldValuePairs.Add(newConTable.Name, S.Parameter("Tester"));
  newUpdate.FieldValuePairs.Add(newConTable.Number1, S.Parameter("01214578"));
  newUpdate.FieldValuePairs.Add(newConTable.OrgNr, S.Parameter("7845"));

  //Make the Database Update
  myComm.SqlCommand = newUpdate;
  myComm.ExecuteNonQuery();

  //Commit the transaction and close the session
  newTrans.Commit();
  myConn.Close();
}
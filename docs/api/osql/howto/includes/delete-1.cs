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
  //Creating an Instance of the Delete Class
  Delete newDelete = S.NewDelete();
  newDelete.SetPrimaryKey(newConTable.ContactId);
  newDelete.SetPrimaryKeyValue(S.Parameter(122));
  myComm.SqlCommand = newDelete;
  myComm.ExecuteNonQuery();
  newTrans.Commit();
  myConn.Close();
}
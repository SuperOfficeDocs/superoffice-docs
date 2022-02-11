using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Creating DataSets with the Tables of the Database
  AppointmentTableInfo newAppTab = TablesInfo.GetAppointmentTableInfo();

  //Creating an instance of the Insert class
  Insert newInsert = S.NewInsert();

  //Inserting the necessary fields of the Table
  newInsert.FieldValuePairs.Add(newAppTab.AppointmentId, S.Parameter(Sequence.GetNext(newAppTab)));
  newInsert.FieldValuePairs.Add(newAppTab.AssociateId, S.Parameter(103));
  newInsert.FieldValuePairs.Add(newAppTab.ContactId, S.Parameter(20));
  newInsert.FieldValuePairs.Add(newAppTab.PersonId, S.Parameter(10));
  newInsert.FieldValuePairs.Add(newAppTab.GroupIdx, S.Parameter(1));
  newInsert.FieldValuePairs.Add(newAppTab.DoBy, S.Parameter(new DateTime(2007, 4, 20)));
  newInsert.FieldValuePairs.Add(newAppTab.Status, S.Parameter(SuperOffice.Data.AppointmentStatus.NotStarted));
  newInsert.FieldValuePairs.Add(newAppTab.Done, S.Parameter(new DateTime(2007, 4, 20)));
  newInsert.FieldValuePairs.Add(newAppTab.TaskIdx, S.Parameter(10));
  newInsert.FieldValuePairs.Add(newAppTab.Updated, S.Parameter(new DateTime(2007, 4, 20)));
  newInsert.FieldValuePairs.Add(newAppTab.UpdatedAssociateId, S.Parameter(103));
  newInsert.FieldValuePairs.Add(newAppTab.UpdatedCount, S.Parameter(1));

  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();

  //Creating and SoCommand instance and assigning the earlier created Select statement
  SoCommand myComm = myConn.CreateCommand();
  myConn.Open();

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
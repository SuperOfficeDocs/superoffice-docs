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
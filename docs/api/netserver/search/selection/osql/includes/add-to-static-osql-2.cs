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
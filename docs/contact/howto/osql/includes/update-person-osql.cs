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
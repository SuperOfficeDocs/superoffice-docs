using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("sam", "sam"))
{
  //Creating DataSets with the Tables of the Database
  ContactTableInfo newConTab = TablesInfo.GetContactTableInfo();

  //Creating an instance of the Insert class
  Insert newInsert = S.NewInsert();

  //Inserting the necessary fields of the Table
  newInsert.FieldValuePairs.Add(newConTab.ContactId, S.Parameter(Sequence.GetNext(newConTab)));
  newInsert.FieldValuePairs.Add(newConTab.Name, S.Parameter("EuroCenter"));
  newInsert.FieldValuePairs.Add(newConTab.UpdatedCount,S.Parameter(0));
  newInsert.FieldValuePairs.Add(newConTab.SoundEx,S.Parameter("HUTTETU"));
  newInsert.FieldValuePairs.Add(newConTab.UpdatedAssociateId,S. Parameter(0));
  newInsert.FieldValuePairs.Add(newConTab.Updated, S.Parameter(DateTime.Now));
  newInsert.FieldValuePairs.Add(newConTab.BusinessIdx,S.Parameter(0));
  newInsert.FieldValuePairs.Add(newConTab.CategoryIdx,S.Parameter(0));
  newInsert.FieldValuePairs.Add(newConTab.CountryId, S.Parameter(50));
  newInsert.FieldValuePairs.Add(newConTab.Department, S.Parameter("Parks dept"));
  newInsert.FieldValuePairs.Add(newConTab.OrgNr, S.Parameter("2547869"));
  newInsert.FieldValuePairs.Add(newConTab.Registered, S.Parameter(DateTime.Now));
  newInsert.FieldValuePairs.Add(newConTab.RegisteredAssociateId, S.Parameter(103));

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

  //Committing the transaction and clossing the session
  newTrans.Commit();
  myConn.Close();
}
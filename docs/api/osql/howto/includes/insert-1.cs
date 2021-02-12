using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAM", "sam"))
{
  if (mySession == null) return;
  //Using the Insert Statement in to Add new Data
  //Establishing a Database Connection
  SoConnection myConn = ConnectionFactory.GetConnection();
  //Creating and SoCommand instance and assigning the earlier created Select statement
  SoCommand myComm = myConn.CreateCommand();
  myConn.Open();
  //Creating DataSets with the Tables of the Database
  RedLetterDayTableInfo newRedLetDatTab = TablesInfoGetRedLetterDayTableInfo();
  //Setting the Required Date
  DateTime baseTime = new DateTime(2007, 2, 4);
  //Creating an instance of the Insert class
  Insert newInsert = S.NewInsert();
  //Inserting the necessary fields of the Table
  newInsert.FieldValuePairs.Add(newRedLetDatTab.RedletterdayId, S.Parameter(Sequence.GetNext(newRedLetDatTab)));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.Reddate, S.Parameter(baseTime));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.CountryId, S.Parameter(1));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.Reds, S.Parameter(0));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.Colored, SParameter(0));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.Color, S.Parameter(0));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.Text, S.Parameter("Testers day"));
  newInsert.FieldValuePairs.Add(newRedLetDatTab.UpdatedCount, S.Parameter(0));
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
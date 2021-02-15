using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice.CRM.Data;
using SuperOffice.CRM.Entities;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  // Retrieving the SAINT values of the Contact with contact_id=30
  SoConnection _con = null;
  SoCommand _cmd = null;
  _con = ConnectionFactory.GetConnection();
  _cmd = _con.CreateCommand();
  _con.Open();
  StatusValueTableInfo statusInfo = TablesInfo.GetStatusValueTableInfo();

  // The SQL command is SELECT * FROM statusvalue WHERE contact_id=30 and isSignalled=1
  Select select = S.NewSelect();
  select.ReturnFields.Add(statusInfo.All);
  select.Restriction = statusInfo.ContactId.Equal(S.Parameter(50)).And(statusInfo.IsSignalled.Equal(S.Parameter(1)));
  _cmd.SqlCommand = select;
  SoDataReader reader = _cmd.ExecuteReader();
  int statusValue_id=0;

  //Displaying few of the retrieved fields in the first ListBox
  while (reader.Read())
  {
    statusValue_id = int.Parse(reader[0].ToString());
    listBox1.Items.Add("StatusValue_id = "+ statusValue_id.ToString());
    listBox1.Items.Add("StatusDef_id= " + reader[1].ToString());
    listBox1.Items.Add("contact_id= " + reader[2].ToString());
    listBox1.Items.Add("peron_id=" + reader[3].ToString());
    listBox1.Items.Add("project_id= "+ reader[4].ToString());
    listBox1.Items.Add("extract1_id= " + reader[5].ToString());
    listBox1.Items.Add("extract2_id= " + reader[6].ToString());
    listBox1.Items.Add("isSignalled= " + reader[7].ToString());
  }

  //setting the IsSignalled field of the above record to 0
  if (statusValue_id != 0)
  {
    Update update = S.NewUpdate();
    update.SetPrimaryKey(statusInfo.StatusValueId);
    update.SetPrimaryKeyValue(S.Parameter(statusValue_id));
    update.FieldValuePairs.Add(statusInfo.IsSignalled, S.Parameter(0));
    SoTransaction Trans = _con.BeginTransaction();
    _cmd.Transaction = Trans;
    _cmd.SqlCommand = update;
    _cmd.ExecuteNonQuery();
    Trans.Commit();
  }

  //Retrieving the same record to check whether the row is updated
  Select select2 = S.NewSelect();
  select2.ReturnFields.Add(statusInfo.All);
  select2.Restriction = statusInfo.ContactId.Equal(S.Parameter(50));
  _cmd.SqlCommand = select2;
  reader = _cmd.ExecuteReader();

  //Displaying the results in the second list box
  while (reader.Read())
  {
    statusValue_id = int.Parse(reader[0].ToString());
    listBox2.Items.Add("StatusValue_id = " + statusValue_id.ToString());
    listBox2.Items.Add("StatusDef_id= " + reader[1].ToString());
    listBox2.Items.Add("contact_id= " + reader[2].ToString());
    listBox2.Items.Add("person_id=" + reader[3].ToString());
    listBox2.Items.Add("project_id= " + reader[4].ToString());
    listBox2.Items.Add("extract1_id= " + reader[5].ToString());
    listBox2.Items.Add("extract2_id= " + reader[6].ToString());
    listBox2.Items.Add("isSignalled= " + reader[7].ToString());
  }
}
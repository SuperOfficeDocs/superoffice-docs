using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice.Data.SQL;
using SuperOffice;
using System.Collections.Specialized;
using System.Collections;
private void btnShowContacts_Click(object sender, EventArgs e)
{
  try
  {
    using (SoSession session = SoSession.Authenticate(this.txtUserName.Text.Trim(), this.txtPWD.Text.Trim()))
    {
      // Retriveing tableInfo for the ContactTable
      ContactTableInfo newConTable = TablesInfo.GetContactTableInfo();
      // Retrieving data in to an instance of the Select Class
      Select newSelect = S.NewSelect();
      // Choosing the columns that should be retrieved
      newSelect.ReturnFields.Add(newConTable.ContactId, newConTable.Department, newConTable.Name);
      // Ordering the retrieved Data
      newSelect.OrderBy.SortOrder.Add(newConTable.ContactId, SuperOffice.Util.OrderBySortType.ASC);
      // Establishing a database connection
      SoConnection myConn = ConnectionFactory.GetConnection();
      // Creating SoCommand instance and assigning the Select statement
      SoCommand myComm = myConn.CreateCommand();
      myComm.SqlCommand = newSelect;
      myConn.Open();
      // Loading the data into the DataReader
      SoDataReader myReader = myComm.ExecuteReader();
      ArrayList arrConData = new ArrayList();
      // Retrieving the Data from the Reader
      while (myReader.Read())
      {
        int conID = myReader.GetInt32(0);
        string conDept = myReader.GetString(1);
        string conName = myReader.GetString(2);
        // Creating a user defined contact object to be stored
        // in the ArrayList
        ContactData contact = new ContactData(conID, conName, conDept);
        arrConData.Add(contact);
      }

      // Setting the results to the data grid
      this.grdContactData.DataSource = arrConData;
      // Closing the reader
      myReader.Close();
    }
  }
  catch (Exception exception)
  {
    // Clear textboxes and the data grid
    this.clearAll();
    MessageBox.Show("Invalid user.");
  }
}
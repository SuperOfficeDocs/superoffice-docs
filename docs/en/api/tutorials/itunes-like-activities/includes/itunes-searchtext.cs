private void searchText()
{
  // iterate through the DataGridViewRow collection of the gridview
  foreach (System.Windows.Forms.DataGridViewRow datarow in this.grdActivityData.Rows)
  {
    //  checking the 'Description' column of the current row to see if it contains the search text
    if (datarow.Cells["Description"].Value.ToString().Contains(this.txtSearch.Text.Trim()))
    {
      // make the datarow visible if it contains the search text
      datarow.Visible = true;
    }
    else
    {
      this.grdActivityData.CurrentCell = null;
      datarow.Visible = false;
    }
  }
}
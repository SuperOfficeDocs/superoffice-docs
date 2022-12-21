//Converting the data which can be used to construct Excel Graphs
DataTable newDataTbl = (DataTable)coreWebTestList;
DataTable newDataTbl2 = new DataTable();
newDataTbl2.TableName = "Sales Information";
newDataTbl2.Columns.Add("Project Name");
newDataTbl2.Columns.Add("Amount");
newDataTbl2.Columns.Add("Earning %");
foreach (DataRow datRow in newDataTbl.Rows)
{
  DataRow dr = newDataTbl2.NewRow();
  dr[0] = datRow.ItemArray[0].ToString();
  dr[1] = float.Parse(datRow.ItemArray[1].ToString().Substring(3,
  datRow.ItemArray[1].ToString().Length - 4));
  dr[2] = float.Parse(datRow.ItemArray[2].ToString().Substring(3,
  datRow.ItemArray[2].ToString().Length - 4));
  newDataTbl2.Rows.Add(dr);
}

//Write the data into the DataGrid
DataView newDateView = new DataView(newDataTbl2);
GridView1.DataSource = newDateView;
GridView1.DataBind();

//Write the Data into an XML file using the XmlTextWriter class
FileStream newFs = new FileStream("C:\\SaleData.xml", FileMode.Create);
XmlTextWriter newTextWriter = new XmlTextWriter(newFs, Encoding.Unicode);
newDataTbl2.WriteXml(newTextWriter);
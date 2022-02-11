//Converting the data into an acceptable form
CoreWebList<SalesData> coreWebTestList = new CoreWebList<SalesData>();
foreach (ArchiveRow row in newSalePro.GetRows())
{
  ArrayList frArrLst = new ArrayList();
  foreach (KeyValuePair<string, ArchiveColumnData> column in row.ColumnData)
  {
    string displayValue = column.Value != null ? column.Value.DisplayValue.ToString() : "-";
    frArrLst.Add(displayValue);
  }
  SalesData frSaleData = new SalesData(frArrLst[0].ToString(),
  frArrLst[1].ToString(), frArrLst[2].ToString());
  coreWebTestList.Add(frSaleData);
  frArrLst.Clear();
}
---
title: Graphic report using Excel
uid: graphic_report_excel
description: Graphic report using Excel
author: SuperOffice Product and Engineering
date: 
keywords: 
content_type: tutorial
---

# Graphic report using Excel

This tutorial shows how we can make use of NetServer and retrieve data and generate an excel report based on such data.

1. Use archive provider to read information
2. Use a data table converter to build a DataTable
3. Save the data table as an XML file
4. Open the XML file using Excel.

## Implementation

### SaleProvider

We have used Providers available through the **SuperOffice.CRM.ArchiveLists** namespace to retrieve the data.

```csharp
//Setting the Parameters that needs to be passed to Agent method 
//Parameter - providerName - The name of the archive provider to use
IArchiveProvider newSalePro = new SaleProvider();

//Parameter - columns - An array of the names of the columns wanted.
string[] columns = new string[] { "project/name", "amount", "earningPercent" };
newSalePro.SetDesiredColumns(columns);

//Parameter - entities - Which entities to include
string[] entities = new string[] { "sale", "contact" };
newSalePro.SetDesiredEntities(entities);

//Parameter - restriction - Archive restrictions
ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
archiveRest[0] = new ArchiveRestrictionInfo("contactid", "=", "113");
newSalePro.SetRestriction(archiveRest);

//Parameter - page - Page number, page 0 is the first page
//Parameter - pageSize - Page size 
int page = 1;
int pageSize = 10;
newSalePro.SetPagingInfo(pageSize, page);

//Parameter - sortOrder - Sort order for the archive
ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
archiveSrtOrd[0] = new ArchiveOrderByInfo("project/name",
SuperOffice.Util.OrderBySortType.DESC);
newSalePro.SetOrderBy(archiveSrtOrd);
```

What we have done above is created a `SaleProvider` and assign values to the provider using certain methods available through it.

### Retrieve and convert data

Once this is done, the next step is to retrieve the data and get the data converted to a way acceptable by .Net which can be used to generate the excel report. This is necessary since the data returned by the provider consists of data that is not of the basic data types. The following code segment is used for this purpose.

```csharp
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
```

### CoreWebList

What we have done is first to create an instance of our explicit conversion class called CoreWebList. Container class for Sales data which is called **SaleData** is passed in.

```csharp
//Explicit conversion class that converts the list to be converted to a data table.
public class CoreWebList<T> : List<T>
{
  //Variable declarations
  private static bool _enforceKeys;
  //Class Constructor
  public CoreWebList()
  {
    _enforceKeys = false;
  }
  
  //Get / Set method
  public bool DataTableEnforceKeys
  {
    get { return _enforceKeys; }
    set { _enforceKeys = value; }
  }
  
  //List to data table conversion method
  static explicit operator DataTable(CoreWebList<T> wblist)
  {
    DataTableConverter<T> converter = new DataTableConverter<T>(_enforceKeys);
    return converter.GetDataTable(wblist);
  }
}
```

### SalesData container

The SalesData Container is as follows.

```csharp
//The Container class for the Sale information
public class SalesData
  {
  string _proName;
  string _SalAmnt;
  string _SalEarnPer;

  //Class constructor
  public SalesData(string proName, string salAmnt, string salEarnPer)
  {
    _ proName = proName;
    _SalAmnt = salAmnt;
    _SalEarnPer = salEarnPer;
  }

  //Conversion methods for each property 
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string ProName
  {
    get { return _ proName; }
    set { _ proName = value; }
  }
  
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string SalAmnt
  {
    get { return _SalAmnt; }
    set { _SalAmnt = value; }
  }
  
  [Conversion(ConvertDataTable = true, KeyFields = true, DBNull = false)]
  public string SalEarnPer
  {
    get { return _SalEarnPer; }
    set { _SalEarnPer = value; }
  }
}
```

The above code makes use of our custom attribute class which acquires the metadata about the properties of our container class that is built at runtime.

### Do the conversion

The next step is to build the class which does the conversion. We have identified it as

[!code-csharp[CS](includes/datatableconverter.cs)]

### Get results into a spreadsheet

The final step of the code would be to get the result into an excel sheet that can be used to generate graphs and charts. For this we use the XmlTextWriterClass.

```csharp
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
```

## Result in Excel

What we have done first in the above code is to convert the required strings (Amount and EarningPercentage columns) into their relevant numeric type. This has been done by using a looping through each of the rows of the converted data table. The modified values would then be added to another variable which can be used to display the data on the Data Grid as well to pass the data into the Xml writer. The XML file used by Excel is stored as `C:\\SaleData.xml`.

**SaleData.Xml opened in Microsoft Office Excel:**

![02][img1]

To run the sample code, the `Database` element of the *web.config* file should be modified to reflect the SuperOffice Database of the machine that the site is been run on.

The final step before running the site is to add the following references:

* SOCore.dll
* SODataBase.dll
* SuperOffice.CRMWeb.dll
* SuperOffice.Services.dll
* SuperOffice.Services.Impl.dll

<a href="../../../assets/downloads/api/graphicreportusingexcel.zip" download>Click to download source code (zip)</a>

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/image022.jpg

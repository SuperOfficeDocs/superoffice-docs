---
title: graphic_report_excel
description: Graphic report using Excel
author: {github-id}
so.date: 
keywords: 
so.topic: tutorial
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

[!code-csharp[CS](includes/graphic-saleprovider.cs)]

What we have done above is created a `SaleProvider` and assign values to the provider using certain methods available through it.

### Retrieve and convert data

Once this is done, the next step is to retrieve the data and get the data converted to a way acceptable by .Net which can be used to generate the excel report. This is necessary since the data returned by the provider consists of data that is not of the basic data types. The following code segment is used for this purpose.

[!code-csharp[CS](includes/excel-get-and-convert.cs)]

### CoreWebList

What we have done is first to create an instance of our explicit conversion class called CoreWebList. Container class for Sales data which is called **SaleData** is passed in.

[!code-csharp[cs](includes/coreweblist.cs)]

### SalesData container

The SalesData Container is as follows.

[!code-csharp[CS](includes/salesdata.cs)]

The above code makes use of our custom attribute class which acquires the metadata about the properties of our container class that is built at runtime.

### Do the conversion

The next step is to build the class which does the conversion. We have identified it as

[!code-csharp[CS](includes/datatableconverter.cs)]

### Get results into a spreadsheet

The final step of the code would be to get the result into an excel sheet that can be used to generate graphs and charts. For this we use the XmlTextWriterClass.

[!code-csharp[CS](includes/excel-write.cs)]

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

<!-- [Source code (zip)](GraphicReportUsingExcel.zip) -->

<!-- Referenced links -->
[1]:

<!-- Referenced images -->
[img1]: media/image002.jpg

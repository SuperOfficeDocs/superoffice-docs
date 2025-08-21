---
uid: saint-contactrow-customsearch
title: Search for contacts with a given SAINT counter
description: Search for contacts with a given SAINT counter ContactRow.CustomSearch
keywords: sale, SAINT, API, row, customsearch, ContactRow, countervalue, amountclassid
author: Bergfrid Skaara Dias
date: 11.05.2021
version: 10
content_type: howto
redirect_from:
  - /en/sale/saint/howto/row/search-saint-contactrow-customsearch
  - /en/api/netserver/rows/howto/saint/search-saint-contactrow-customsearch
---

# Search for contacts with a given SAINT counter using ContactRow.CustomSearch

We might need to retrieve a list of companies with more than 2 successful sales. In this situation we do not want to restrict the amount-class, so we may specify the `amountclassid =0`. In the following example, we will explain how this is done.

## Code

```csharp
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{

  //Create an instance of the CustomSearch class
  ContactRows.CustomSearch myRows = new ContactRows.CustomSearch();

  //Get instances of ContactTableInfo and CounterValueTableInfo
  ContactTableInfo nweConTbl = TablesInfo.GetContactTableInfo();
  CounterValueTableInfo cvTable = TablesInfo.GetCounterValueTableInfo();

  //Join the contact table with with countervalue table
  myRows.JoinRestriction.InnerJoin(nweConTbl.ContactId.Equal(cvTable.ContactId));

  //Set Restrictions so that sale_status = 2 and amountClassId = 0 and totalReg > 2
  myRows.Restriction = cvTable.SaleStatus.Equal(S.Parameter(2)).
  And(cvTable.AmountClassId.Equal(S.Parameter(0))).
  And(cvTable.TotalReg.GreaterThan(S.Parameter((uint)2)));

  //Set IsDistinct property True to remove duplicates
  myRows.IsDistinct = true;
  ContactRows newRows = ContactRows.GetFromCustomSearch(myRows);

  //Display the returned rows
  foreach (ContactRow myRow in newRows)
  {
    listBox1.Items.Add(myRow.Name);
  }
}
```

## Walk-through

In this example, we have created an instance of the `CustomSearch` class. You can join the `contact` table with the `countervalue` table as done above. The exact SQL statement we run above is:

```SQL
SELECT DISTINCT CRM.contact.contact_id
FROM CRM.contact
INNER JOIN CRM.countervalue ON CRM.countervalue.sale_status = 2
AND CRM.countervalue.amountClassId = 0 AND
CRM.countervalue.totalReg > 2
```

> [!NOTE]
> It is not necessary to set the `IsDistinct` property to True. But the join statement returns a large number of rows with the same `contact_id`, and therefore it would be better to set the `IsDistinct` property to True.

---
uid: get-invitation-services
title: How to get a list of invitations (services)
description: How to get a list of invitations using NetServer services
keywords: diary, calendar, appointment, API, web services, archiveprovider
author: Bergfrid Skaara Dias
date: 03.18.2022
content_type: howto
redirect_from:
  - /en/diary/howto/services/get-invitations-services
  - /en/api/netserver/web-services/howto/diary/get-invitations-services
---

# How to get a list of invitations (services)

The code below is used to retrieve a list of [invitations][1] for a specific associate with [NetServer services][2].

## Code

```csharp
using SuperOffice;
using SuperOffice.CRM.ArchiveLists;

using(SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Create an instance of the InvitationProvider
  IArchiveProvider newInvPro = new InvitationProvider();

  //Set the order by rule for the Provider
  newInvPro.SetOrderBy(new ArchiveOrderByInfo("appointmentId", SuperOffice.Util.OrderBySortType.DESC));

  //Set the columns we want to retrive
  newInvPro.SetDesiredColumns("appointmentId", "date", "associate/contactFullName", "endDate" );

  //Set the page size
  newInvPro.SetPagingInfo(100, 0);

  //Add the restriction the provider should be based on
  newInvPro.SetRestriction( 
    new ArchiveRestrictionInfo("associateId", "=", "5"),
    new ArchiveRestrictionInfo("date",">",DateTime.Today.ToString()));

  //Looping through the provider in order to get the results we are going out of the loop
  int rowNo = 1;
  foreach (ArchiveRow archiveRow in newInvPro.GetRows())
  {
    if (rowNo == 1)
    {
      foreach (KeyValuePair<string, ArchiveColumnData> column in archiveRow.ColumnData)
      {
        Console.Write(column.Key + "\t");
      }
      Console.WriteLine();
    }
    // extract and display the displayValue of each cell
    // (you need to parse culturally sensitive values such as dates to get the correct client display format)
    foreach (ArchiveColumnData archiveCell in archiveRow.ColumnData.Values)
    {
      Console.Write(archiveCell.DisplayValue + "\t");
    }
    Console.WriteLine();
    ++rowNo;
  }
}
```

## Walk-through

In the code, we have used an instance of the [InvitationProvider][3] and some of its methods to restrict and arrange the output returned by the provider.

| Method | Description |
|---|---|
| SetOrderBy | sorts the output by ID |
| SetPageInfo | limits the number of rows returned to the first 100 rows |
| SetDesiredColumns | is used to identify which columns should be returned by the provider |
| SetRestriction | sets the query restriction for the provider |
| GetRows | can be used to retrieve the rows returned by the provider |

The provider returns a collection of `ArchiveRow` types. By looping through each `ArchiveRow` we can get details of an invitation for the associate. The result of executing the above code is shown below.

```text
associate/contactFullName    date        endDate           appointmentId
StateZeroDatabase       [D:07/05/2007]    [D:07/05/2007]    [I:186]
StateZeroDatabase       [D:07/26/2007]    [D:07/26/2007]    [I:179]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:172]
StateZeroDatabase       [D:06/14/2007]    [D:06/14/2007]    [I:161]
StateZeroDatabase       [D:04/28/2007]    [D:04/28/2007]    [I:150]
```

<!-- Referenced links -->
[1]: ../../../../diary/learn/invitation/index.md
[2]: ../../index.md
[3]: ../../../archive-providers/reference/invitation.md

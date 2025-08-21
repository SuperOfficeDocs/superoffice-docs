---
title: How to use ActivityArchive filters
uid: activity_archive_filters 
description: How to use ActivityArchive filters
author: SuperOffice Product and Engineering
keywords: 
content_type: howto
date:
category: 
area: api-services
redirect_from: /en/api/netserver/search/iarchiveagent/using-activityarchive-filters
---

# How to use ActivityArchive filters

The following example shows the use of ActivityArchive filters. Unlike other archives, the `ActivityArchive` allows us to take columns from multiple archives.

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice.CRM.Archives;

using (SoSession newSession = SoSession.Authenticate("sam", "sam"))
{
  //Initializing the Archive Agent
  using(ArchiveAgent newArcAgt = new ArchiveAgent())
  {
    //Setting the Parameters that needs to be passed to Agent method  
    //Parameter - providerName - The name of the archive provider to use
    string archiveProviderName = ContactActivityArchiveProvider.ProviderName;

    //Parameter - columns - An array of the names of the columns wanted.
    string[] archiveColumns = new string[] { "contact/name", "associate/fullName", "person/fullName", "saleId", "currency" };

    //Parameter - sortOrder - Sort order for the archive
    ArchiveOrderByInfo[] archiveSrtOrd = new ArchiveOrderByInfo[1];
    archiveSrtOrd[0] = new ArchiveOrderByInfo("saleId", SuperOffice.Util.OrderBySortType.DESC);

    //Parameter - restriction - Archive restrictions
    ArchiveRestrictionInfo[] archiveRest = new ArchiveRestrictionInfo[1];
    archiveRest[0] = new ArchiveRestrictionInfo("contact/contactId", "=", 68);

    //Parameter - entities - Which entities to include
    string[] desiredEntities = { "contact", "sale", "document", "person", "appointment" };

    //Parameter - page - Page number, page 0 is the first page
    int page = 1;

    //Parameter - pageSize - Page size
    int pageSize = 10;

    // Get a page of results for an archive list, 
    // explicitly specifying the restrictions, orderby and chosen columns
    ArchiveListItem[] arcLstItm = newArcAgt.GetArchiveListByColumns(
      archiveProviderName, archiveColumns, archiveSrtOrd, archiveRest, desiredEntities, page, pageSize);

    int rowNo = 1;
    foreach (ArchiveListItem archiveRow in arcLstItm)
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
      // (you need to parse culturally sensitive values such as dates
      // to get the correct client display format)
      foreach (ArchiveColumnData archiveCell in archiveRow.ColumnData.Values)
      {
        Console.Write(archiveCell.DisplayValue + "\t");
      }
      Console.WriteLine();
      ++rowNo;
    }
  }
}
```

As we can see, `GetArchiveListByColumns()` requires 7 parameters to be passed into it. These are explained in detail on the [IArchiveProvider][1] page. Below we touch on what's different.

## archiveProviderName

`ContactActivityArchiveProvider.ProviderName`

## archiveColumns

`{ "contact/name", "associate/fullName", "person/fullName", "saleId", "currency" }`

>[!NOTE]
> The ActivityArchive allows us to take columns from multiple archives. Here we retrieve the name of the contact from the `Contact` entity, the full name of the associate from the `Associate` entity, the full name of the person from the `Person` entity, and `SaleId` and `Currency` from the `Sale` entity. These retrieves would be impossible if we were to have an Appointment column or a Document column.

## archiveSrtOrd

Here we are sporting by the `saleId` with the highest ID first in the list. Any row that doesn’t have a `saleId` will be sorted as value 0 and would be shown at the end of the list.

## archiveRest

What we have done here is set the restriction, as ContactID, which is obtained from the `Contact` entity, should equal to the specified value (68). This means that we are retrieving all the Appointments, Documents, and Sales records that have the `contactId` as "68".

## desiredEntities

The entities correspond to checkboxes in the Archive GUI. If we remove "document" from this list, the `Document` records are never fetched from the database and the `Documents` rows will disappear from the results.

Once all parameters have been created, we may use them with the `GetArchiveListByColumns` method, which returns an array of `ArchiveListItem`.

The next step we need to do is to loop through the above array just like we did in the [first example][1].

## Output

```text
person/fullName  contact/name    associate/fullName   currency    saleId
0-Feil           Software AS     Brede Bredesen       SEK         [I:19]
0-Feil           Software AS     Arne Arnesen         SEK         [I:10]0-Feil           Software AS     Arne Arnesen         NOK         [I:9]
0-Feil           Software AS     Arne Arnesen         NOK         [I:8]
0-Feil           Software AS     Arne Arnesen         SEK         [I:7]
```

<!-- Referenced links -->
[1]: iarchiveagent.md

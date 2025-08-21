---
title: How to perform an archive provider query
uid: how_to_query_with_archive_providers
description: How to perform an archive provider query
author: Tony Yates
date: 11.17.2017
keywords: archive provider query, query database
content_type: howto
category: api
topic: archive providers
redirect_from: /en/api/netserver/archive-providers/how-to-query
---

# How to perform an archive provider query

It is necessary to query data from a database when writing applications. Archive providers are designed for this. They handle the complex business logic of filtering and flattening the complex relationships in the database into a simple flat table.

While archive providers make complex queries possible through web services, they of course work in and with their lower-level data types executed in the belly NetServer.

## NetServer Core vs web services

This section shows how to query an archive provider both using the core NetServer API, as well as the NetServer Web Services API.

There are subtle differences between core and web services APIs, but for the most part, they are the same. One of the biggest differences is how value types are returned (integers, Double, and DateTime).

Both examples represent a query that selects all sales where the sale project ID is set to 47.

<!-- markdownlint-disable MD051 -->
### [NetServer Core](#tab/query-ns-core)

[!code-csharp[NetServer Core](includes/query-ns-core.cs)]

### [NetServer Web Services](#tab/query-ns-ws)

[!code-csharp[NetServer Web Services](includes/query-ns-ws.cs)]

***
<!-- markdownlint-restore -->

## Example

The following example demonstrates how a `PersonProvider` is used to query data from the database.

```csharp
using SuperOffice;
using SuperOffice.CRM.ArchiveLists;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  SuperOffice.CRM.ArchiveLists.IArchiveProvider personArchive = new PersonProvider();

  //Get the list of columns handled by this provider
  List<ArchiveColumnInfo> availableColumns = personArchive.GetAvailableColumns();

  //Get the list of Entities supported by this provider
  List<ArchiveEntityInfo> availableEntities = personArchiveGetAvailableEntities();

  //Display the list of column names and entity names in two list boxes
  foreach (ArchiveColumnInfo columninfo in availableColumns)
  {
    FieldsListBox.Items.Add(columninfo.Name);
  }
  foreach (ArchiveEntityInfo entityinfo in availableEntities)
  {
    entitiesListBox.Items.Add(entityinfo.Name);
  }

  //Set the columns that needs to be returned
  personArchive.SetDesiredColumns("personId", "fullName","personUdef:SuperOffice:6", "personUdef:SuperOffice:1");

  //set the paging properties of the provider.
  personArchive.SetPagingInfo(10, 0);
  personArchive.SetOrderBy(new ArchiveOrderByInfo("contactId", SuperOfficeUtil.OrderBySortType.DESC),
  new ArchiveOrderByInfo("personUdef:SuperOffice:6", SuperOffice.UtilOrderBySortType.ASC));

  //An array of restrictions with an implicit and in between them.
  personArchive.SetRestriction(new ArchiveRestrictionInfo("personId", ">","50"),
  new ArchiveRestrictionInfo("personUdef:SuperOffice:6", "=", "1"));

  //Display the retrieved data in another list box
  int rowNo = 1;
  foreach (ArchiveRow row in personArchive.GetRows())
  {
    if (rowNo == 1)
    {
      foreach (KeyValuePair<string, ArchiveColumnData>column inrowColumnData)
      {
        resultsListbox.Items.Add(column.Key);
      }
    }
    foreach (KeyValuePair<string, ArchiveColumnData> column inrowColumnData)
    {
      resultsListbox.Items.Add(column.Value.ToString());
    }
    ++rowNo;
  }
}
```

Here we have initially created an archive provider of type Person. PersonProvider is a specially designed archive provider:

1. Retrieve the list of columns that can be handled by this archive provider through the `GetAvailableColumns` method.
2. Retrieve the Entities that are supported by this archive provider via the `GetAvailableEntities` method.
3. `GetAvailableColumns()` and `GetAvailableEntities` return data lists of type `ArchiveColumnInfo` and `ArchiveEntityInfo` respectively.

In the above example, we have retrieved the `ColumnInfo` and `EntityInfo` from the `PersonProvider` and displayed them in 2 list-boxes.

![PersonProvider -screenshot][img1]

Finally, we have retrieved the set of rows satisfying the above query and displayed them in another Listbox.

![Result -screenshot][img2]

## NetServer REST WebApi

Using the `Sale` endpoint and issue an `OData` query (see [documentation][1]):

```http
GET /Cust12345/api/v1/Sale?$select=saleId,heading,projectId&$filter=projectId eq 47 HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
```

## NetServer REST Agent Service

Using the RESTful Agent Find endpoint (see [documentation][2]):

```http
POST /Cust12345/api/v1/Agents/Find/FindFromRestrictionsColumns HTTP/1.1
Host: sod.superoffice.com:443
Authorization: Bearer 8A:Cust12345.AS5...sy9
Accept: application/json
Content-Type: application/json

{
  "ProviderName": "FindSale",
  "DesiredColumns": [
    "saleId",
    "heading",
    "projectId"
  ],
  "Restrictions": [
    {
      "Name": "projectId",
      "Operator": "=",
      "Values": [
        "47"
      ],
      "IsActive": true
    }
  ],
  "Page": 0,
  "PageSize": 100
}
```

<!-- Referenced links -->
[1]: ../reference/restful/rest/Sale/v1SaleEntity_GetAll.md
[2]: <xref:SuperOffice.CRM.Services.FindAgent.FindFromRestrictionsColumns(SuperOffice.CRM.ArchiveLists.ArchiveRestrictionInfo[],System.String,System.String[],System.Int32,System.Int32)>

<!-- Referenced images -->
[img1]: media/query-1.jpg
[img2]: media/query-2.jpg

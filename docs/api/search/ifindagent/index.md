---
# Mandatory fields.
title: ifindagent 
description: IFindAgent
author: {github-id}             # Your GitHub alias.
keywords: search
so.topic: howto                # article, howto, reference, concept, guide
so.date:
so.category: search
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# IFindAgent

This is the common interface for the `FindAgent`. In the NetServer services layer, the searches are done using this [agent][2].

This is very similar to the use of the `ArchiveAgent` in the data layer [Archive Services][1]. However, the `FindAgent` supports a larger set of restrictions.

The following example demonstrates how searches are done via the `FindAgent`.

## Code

```csharp
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;
using SuperOffice;

using (SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Setting up the parameters that need to be passed to Agent method
  //Parameter - ProviderName
  string providerName = "person";

  //Parameter - page - Page number, page 0 is the first page
  int page = 0;

  //Parameter - pageSize - Page size
  int pageSize = 10;

  //Parameter - restriction
  ArchiveRestrictionInfo[] restrictions = new ArchiveRestrictionInfo[1];
  restrictions[0] = new ArchiveRestrictionInfo("firstName", "begins", "s");

  //Create a Find Agent
  using(FindAgent agent = new FindAgent())
  {
    //Find the Results of the Find Agent
    FindResults result = agent.FindFromRestrictions(restrictions,providerName,pageSize,page);

    //Display the results in the console window
    ArchiveColumnInfo[] columns = result.ArchiveColumns;
    ArchiveListItem[] rows = result.ArchiveRows;

    Array.ForEach(columns, delegate(ArchiveColumnInfo column) { Console.Write(column.ToString()); });
    Console.WriteLine();

    Array.ForEach(rows, delegate(ArchiveListItem row)
    {
      foreach (KeyValuePair<string, ArchiveColumnData> data in row.ColumnData)
      {
        Console.Write((data.Value != null ? data.Value.DisplayValue : "-") + "\t");
      }
      Console.WriteLine();
    });
    Console.WriteLine();
  }
}
```

## Walk-through

Here we are trying to find all persons at companies with names starting with "S". Though there are several methods defined by the `FindAgent`, here we have used the `FindFromRestrictions` method. This method executes the find operation and returns a page of results. The restrictions are passed directly as a parameter of the method. There are other methods such as `Find()` that fetches the restrictions or criteria for the find from a restriction storage provider.

The columns of the results are determined based on the restriction. So as the first parameter we have passed an array of restrictions specifying the search. Each restriction must match a column in the provider, and that column must have its `canRestrictBy` property set to true, otherwise, an exception will be thrown.

We must also pass the name of the archive provider. This archive provider executes the search and returns the resulting rows and columns. The page size and the page number decide the size of the result pages and which result page to return respectively.

The output of this example is as follows:

```text
personId    firstName   lastName    middleName  contactId   fullName
[I:91]      Svein       Svendsen                [I:39]      Svein Svendsen
[I:92]      Stein       Steinsen                [I:39]      Stein Steinsen
[I:93]      Sigrid      Sørflaten               [I:40]      Sigrid Sørflaten
[I:94]      Synøve      Solbakken               [I:40]      Synøve Solbakken
[I:153]     Sal0                                [I:2]       Sal0 
[I:154]     Sal1                                [I:2]       Sal1 
[I:155]     Sal2                                [I:2]       Sal2 
[I:156]     Sal3                                [I:2]       Sal3 
```

<!-- Referenced links -->
[1]: ../iarchiveagent/index.md
[2]: ../../services/agents/index.md

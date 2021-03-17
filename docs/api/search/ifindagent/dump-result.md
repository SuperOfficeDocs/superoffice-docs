---
title: dump_result
description: DumpResult helper method
author: {github-id}
so.date: 06.24.2016
keywords:
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# DumpResult helper method

```csharp
using SuperOffice;
using SuperOffice.CRM.Services;
using SuperOffice.CRM.ArchiveLists;

private void DumpResult( ArchiveColumnInfo[] columns, ArchiveListItem[] rows )
  {
    Array.ForEach( columns, delegate( ArchiveColumnInfo column ) { Console.Write( column.ToString() ); } );
    Console.WriteLine();
    Array.ForEach( rows, delegate( ArchiveListItem row )
    {
      foreach(KeyValuePair data in row.ColumnData)
      {
        Console.Write( ( data.Value != null ? data.Value.DisplayValue : "-" ) + "\t" );
      }
      Console.WriteLine();
    } );
    Console.WriteLine();
  }
```

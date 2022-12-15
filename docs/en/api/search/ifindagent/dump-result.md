---
title: DumpResult helper method
uid: dump_result
description: DumpResult helper method
author: {github-id}
so.date: 06.24.2016
keywords:
so.topic: howto
# so.envir:
# so.client:
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

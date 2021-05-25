---
title: Retrieve a list
uid: get_list
description: Retrieve a list
author: {github-id}
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Retrieve a list

## Example 1 - print

The following example retrieves 2 typed lists and prints them using the `PrintMdoProvider` method (shown at the end).

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
SoSession _session = SoSession.Authenticate( "SAL1", "" );
ISoListProvider mdoProvider = SoLists.GetCurrencyList();
PrintMdoProvider( "Currency", mdoProvider );
mdoProvider = SoLists.GetCategoryList();
PrintMdoProvider( "Category", mdoProvider );
_session.Close();
```

## Example 2 - search

You can specify searches and get the result back as a list, suitable for easy enumeration.

Here we search for projects beginning with S. As in the previous example, we use the `PrintMdoProvider` method for output.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
SoSession _session = SoSession.Authenticate( "SAL1", "" );
ISoListProvider provider = SoLists.GetProjectList( "S" );
Assert.IsEmpty( provider.HistoryItems, "There should be no items in the history list" );
Assert.IsNotEmpty( provider.RootItems, "There should be items in the project list" );
PrintMdoProvider( "Projects beginning with S", provider );
_session.Close();
```

## Example 3 - archive

The archives are also available in list form.

```csharp
using SuperOffice;
using SuperOffice.CRM.Lists;
SoSession _session = SoSession.Authenticate( "SAL1", "" );
ArchiveRestrictionInfo contactId = new ArchiveRestrictionInfo( "contactId", "equals", "51" );
ISoListProvider provider = SoLists.GetArchiveList(
    ContactActivityArchiveProvider.ProviderName,
    ArchiveActivityRow.ColumnIcon + "," +     ArchiveActivityRow.ColumnDate + "," +     ArchiveActivityRow.ColumnText,
    contactId );
PrintMdoProvider( ContactActivityArchiveProvider.ProviderName, provider );
_session.Close();
```

## PrintMdoProvider

[!code-csharp[CS](includes/printmdoprovider.cs)]

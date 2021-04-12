---
title: caching_lists
description: Caching lists
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords:
so.topic: concept
---

# Lists

Under the **lists** categorization, the following classes can be added:

* AssociateCache
* CategoryCache
* MDOListTableCache
* PriorityCache
* ProbCache
* RedLetterDayCache

## Example

The following code shows how we may use the different classes grouped as lists relating to caching.

```csharp
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Cache;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAM", "sam"))
{
  //Retrieve the Category from the cache
  CategoryCache newCatCache = CategoryCache.GetCurrent();

  //Using of methods which are available in the Category Cache
  string catName = newCatCache.GetNameFromId(2);
  CategoryRow myCat = newCatCache.GetRowFromId(2);

  //Retrieve a property of a category which are in the cache
  string myCatName = myCat.Name;

  //Modifying values in the CategoryCache
  myCat.Name = "Tester";
  myCat.Save();

  //Disposes the cache
  newCatCache. Dispose();
}
```

The aim here is to retrieve the current instance of the `CategoryCache`. For this, we use the `GetCurrent` method.

Once the instance is retrieved, we may access the information in the cache and update it as shown above. Once the cache has been updated, the database will be updated accordingly.

> [!NOTE]
> When updating values of the cache, the relevant row should be retrieved first. Once the row is retrieved, we may update it like when we update row types exposed in NetServer.

Though we have used the `Dispose` method, it is not necessary to explicitly call `Dispose()`, since the caches implement the `IDisposable` interface, which releases allocated un-managed resources.

See also: [Rows][1]

<!-- Referenced links -->
[1]: ../rows/index.md

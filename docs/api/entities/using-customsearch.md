---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: using_customsearch       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: CustomSearch # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# CustomSearch

Another method of retrieving Entities or Entity Collections is using the `CustomSearch` class.

To use `CustomSearch`, we need to use the following namespaces in addition to `SuperOffice.CRM.Entities`:

* SuperOffice.CRM.Rows
* SuperOffice.CRM.Data
* SuperOffice.Data

```csharp
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Data;
using SuperOffice.Data;
using SuperOffice;

using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  PersonCollection.CustomSearch newSearch = new PersonCollection.CustomSearch();
  PersonTableInfo pTable = newSearch.TableInfo;
  newSearch.Restriction = pTable.ContactId.Equal(S.Parameter(5));
  PersonCollection perColl = PersonCollection.GetFromCustomSearch(newSearch);
  string[] perFirstName = new string[perColl.Count];
  int i = 0;
  foreach (Person per in perColl)
  {
    //Retriving First and Last names from the Collection
    perFirstName[i] = per.Firstname + " " + per.Lastname;
    i = i + 1;
  }
}
```

1. Create an instance of the `CustomSearch` class and use it to retrieve a Person Collection Entity.
2. Create a cache of the Person table. Use the restriction clause to limit the number of rows cached.
3. Use the cache table to retrieve any information required.

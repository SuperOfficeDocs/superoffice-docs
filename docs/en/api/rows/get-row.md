---
title: Retrieve a Row with basic properties
uid: rows_get_row
description: SuperOffice database get row with basic properties
author: SuperOffice Product and Engineering
date: 11.05.2016
keywords:
content_type: howto
redirect_from: /en/api/netserver/rows/get-row
---

# Retrieve a Row with basic properties

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Create a New Row
  ContactRow myContactRow = ContactRow.GetFromIdxContactId(4);

  //Retrieve properties of basic data type
  string name = myContactRow.Name;
  string department = myContactRow.Department;
  int countryId = myContactRow.CountryId;
  bool isDeleted = myContactRow.IsDeleted;
}
```

Here some of the properties of a `ContactRow` are retrieved. `ContactRow` accesses the `contact` table in the database and we are retrieving data in a row with row ID equal to 4.

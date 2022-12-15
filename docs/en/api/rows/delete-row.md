---
title: Delete a Row
uid: delete_row
description: SuperOffice database delete row
author: {github-id}
so.date: 11.05.2016
keywords:
so.topic: howto
---

# Delete a Row

To delete a Row, we have to use the `Delete()` method of that row.

The following example shows you how easily this can be done.

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;
using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve the row to be deleted
  ContactRow myContactRow = ContactRow.GetFromIdxContactId(125);

  //Delete the row
  myContactRow.Delete();
}
```

Before we delete any row, we have to retrieve the Row. Once a Row is retrieved, we can simply use the `Delete()` method and remove that particular row from the database.

> [!NOTE]
> There is no "undelete" option. Hence, **once it’s saved the record is gone forever**.

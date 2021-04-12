---
title: foreign_key_set_get
description: How to set and get foreign keys
author: {github-id}
so.date: 
keywords: 
so.topic: howto
---

# How to set and get foreign keys

The following example shows how to set a foreign key to a Contact and how to retrieve a Contact using its foreign key.

## Code

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows.Util;
using SuperOffice.CRM.Rows;
using SuperOffice.CRM.Data;
using SuperOffice.Data;;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  // Retrieve a ContactRow
  ContactRow myContactRow = ContactRow.GetFromIdxContactId(2);

  //get a foreignAppRow from the database. if the row is not found a new row is created
  ForeignAppRow appRow = RowForeignKeyHelper.GetForeignAppRow("ERP");

  //get a foreignDeviceRow using RowForeignKeyHelper
  ForeignDeviceRow devRow = RowForeignKeyHelper.GetForeignDeviceRow(appRow.ForeignappId, "ERP", "");

  //Create an instance of the RowForeignKeyHelper
  RowForeignKeyHelper fkHelp = new RowForeignKeyHelper(myContactRow);

  //Set a foreignkey for this contact
  fkHelp.Set(devRow.ForeigndeviceId, "ERP_id", "1234");

  //Save the changes
  fkHelp.Save();

  //Get ERP_id from a contact row
  String ERP_id = myContactRow.ForeignKey.Get(devRow.ForeigndeviceId, "ERP_id");

  //Search for a contact using the customsearch
  ContactRow.CustomSearch searchContact = new ContactRow.CustomSearch();
  ForeignKeyTableInfo fkInfo = TablesInfo.GetForeignKeyTableInfo();

  //Set the foreignkey value as a restriction
  searchContact.Restriction = fkInfo.Subkey.Equal(S.Parameter("ERP_id")).And(fkInfo.Subvalue.Equal(S.Parameter("1234"))).And(fkInfo.ForeigndeviceId.Equal(S.Parameter(3)));
  ContactRow getContact = ContactRow.GetFromCustomSearch(searchContact);

  //The ID should be equal to 2
  int id = getContact.ContactId;
}
```

## Walk-through

In this example, we set a foreignkey of the contact with ID 2. We have retrieved a `ForignAppRow` by passing the Appname. If such a row does not exist in the `foreignapp` table, a new row will be created.

After setting the application device you know the ID of the foreign device that you wish to associate your keys with. A key always associates with a foreign device; hence it is important to know the foreign device ID. You can set a foreign key to a Contact with the help of `RowForeignKeyHelper`.

All the changes are added to the database when the `RowforeignKeyHelper` is saved. You can retrieve its foreignkey value via the contact. For that, you need to know the foreign device ID and the foreignKey.

In the latter part of this example, we have retrieved a contact using custom search and the foreignkey is used as a restriction.

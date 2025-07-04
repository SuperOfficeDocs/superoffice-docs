---
uid: row-sample-contactaddress
title: ContactAddress
description: SuperOffice database ContactAddress
keywords: address, ContactRow, AddressRow
author: Tony Yates
date: 11.05.2016
version: 8
content_type: howto
redirect_from: /en/globalization-and-localization/address/howto/rows/update-address
---

# ContactAddress

```csharp
using SuperOffice;
using SuperOffice.CRM.Rows;

using(SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate( "Sal1", "" ))
{
  OwnerContactLinkRow owns = new OwnerContactLinkRow.IdxOwnerContactLinkId( 1 );
  int contactId = owns.ContactId;
  Assert.IsTrue( contactId > 0, "Found owner contact ID" );
  ContactRow c = new ContactRow.IdxContactId( contactId );
  AddressRow a = AddressRow.CreateNew();
  a.Sentries.Add( c.Sentries ); // re-use contact sentry on the address
  a.OwnerId = c.ContactId;
  a.AtypeIdx = AddressType.ContactPostalAddress;
  a.Address1 = "line one-two-three";
  a.City = "Some city";
  a.Zipcode = "1234";
  a.Save();
  // contact update is allowed, but restricted address insert is allowed.

  // this will throw exception, since OwnerContact's name is protected by sentry
  c.Name = "new name";

  // this will also throw exception, since OwnerContact's contact row must not be deleted
  c.Delete();
}
```

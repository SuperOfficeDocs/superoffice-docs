---
title: globalization_addressformatter
description: Localization, class AddressFormatter
author: {github-id}             # Your GitHub alias.
so.date: 05.08.2018
so.topic: reference
keywords: globalization
---

# The AddressFormatter class

The `AddressFormatter` class to help you work with the complexities of address formats. It provides the following functions to format addresses:

* FormatContact
* FormatPerson
* FormatQuote

Reading the `FormattedAddress` data structure is very straightforward. Simply loop over the `FormattedAddress` lines and print out each `IFormattedField` from `FormattedFields`.

The following code example demonstrates using `AddressFormatter` to get a formatted representation of a contacts address, then loops over each line and prints out each address field.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using SuperOffice.CRM.Globalization;
using SuperOffice.CRM.Security;

using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  // get company ID 4
  Contact company = Contact.GetFromIdxContactId(4);

  // format the address of the contact to the format of the
  // country that the contact belongs to

  var formatedAddress = AddressFormatter.FormatContact(company);

  foreach (FormattedFields fs  in formatedAddress)
  {
    foreach (IFormattedField f in fs)
    {
       Console.WriteLine(f.Name +  " " + f.Value);
    }

    Console.WriteLine();
  }
}

// outputs
//---------
//StreetAddress1: A-gata 23
//StreetZipcode: 0123
//StreetCity: OSLO
```

Now, look at a `ContactRow`. Because it only contains properties from the `contact` table, it does not contain an `Address` property. To get a `FormattedAddress` from a `ContactRow`, the `AddressFormatter` expects an `AddressRow` as well.

```csharp
using SuperOffice.CRM.Globalization;
using SuperOffice.CRM.Security;
using SuperOffice.CRM.Rows;
using SuperOffice;
using(SoSession session = SoSession.Authenticate("SAL0", ""))
{
  // retrieve the contact row no 4

  ContactRow conRow = ContactRow.GetFromIdxContactId(4);
  // get the postal address of the contact row no 4

  AddressRow postalAddress = AddressRow.GetFromIdxOwnerIdAtypeIdx(4, SuperOffice.Data.AddressType.ContactPostalAddress);
  // get the street address of the contact row no 4

  AddressRow streetAddress = AddressRow.GetFromIdxOwnerIdAtypeIdx(4, SuperOffice.Data.AddressType.ContactStreetAddress);
  // format the address according to the country that the contact belongs to

  FormattedAddress formatedAddress = AddressFormatter.FormatContact(conRow, postalAddress, streetAddress);
}
```

You can see we have done the same thing using only rows. The `FormatContact` method converts the postal and street address to the format of the country that the contact belongs to. The example uses the `AddressRow.GetFromIdxOwnerIdAtypeIdx` method to get the desired contact address type.

**Pre-defined address field names for person and contact:**

[!include[ALT](./includes/pre-defined-address-fields.md)]

Writing address information back to this data structure is not useful. There is no way to persist changes to a **FormattedAddress** back to the database. Therefore, when writing code inside NetServer core use the Contact and Person entity types to persist address changes. Both entity types expose an `Address` property with relevant properties for dealing with respective address formats.

```csharp
// Example Person Address
Person person = Person.GetFromIdxPersonId(3);
person.Address.Address1 = "A-gata 23";
person.Address.City     = "OSLO";
person.Address.Zipcode  = "0123";
person.Save();
// Example Contact Address
Contact contact = Contact.GetFromIdxContactId(3);
contact.PostalAddress.Address1 = "";
contact.PostalAddress.Address2 = "";
contact.PostalAddress.Address3 = "";
contact.PostalAddress.City     = "";
contact.PostalAddress.County   = "";
contact.PostalAddress.Zipcode  = "";
//----------------------------------
contact.StreetAddress.Address1 = "";
contact.StreetAddress.Address2 = "";
contact.StreetAddress.Address3 = "";
contact.StreetAddress.City     = "";
contact.StreetAddress.County   = "";
contact.StreetAddress.Zipcode  = "";
contact.Save();
```

Working with address information in SuperOffice CRM had never been easier. Hopefully, now you understand the FormattedAddress structure, its' madness, and know better how to deal with it in future projects.

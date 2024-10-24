---
uid: crmscript-addresses
title: Address localization in CRMScript
description: Working with addresses in CRMScript.
keywords: address, NSLocalizedAddress, NSLocalizedField
author: Bergfrid Dias
date: 02.16.2022
version: 9
topic: howto
---

# Address localization in CRMScript

SuperOffice data structures are generic to support multiple address variants. All CRMScript address fields belong to a structure called `NSLocalizedAddress`.

> [!NOTE]
> Some company addresses contain only a postal address while others contain both postal and street addresses. You need to check the `AddressType` to know which type of address information it is!

## NSLocalizedField properties

| Property | Description |
|:--|:--|
| AddressType | Determines which type of address a field belongs to |
| Name | Key |
| Value | Corresponding value from the database |

## Howto

* [Get address info][1]
* [Set address info][2]

## Helper class

Our friends over at Ganske Enkelt have been kind enough to share CRMScript code similar to the [NetServer C# code][3] that you can incorporate into your Customer Service solutions.

```crmscript
CRMScript
#setLanguageLevel 3;

//Helperclass for working with Addresses in SuperOffice CRM and CS.
//Frode Lillerud, Ganske Enkelt AS

Map validAddressTypes;
validAddressTypes.insert("PostalAddress1", "");
validAddressTypes.insert("PostalAddress2", "");
validAddressTypes.insert("PostalAddress3", "");
validAddressTypes.insert("PostalCity", "");
validAddressTypes.insert("PostalCounty", "");
validAddressTypes.insert("PostalState", "");
validAddressTypes.insert("PostalZipcode", "");
validAddressTypes.insert("StreetAddress1", "");
validAddressTypes.insert("StreetAddress2", "");
validAddressTypes.insert("StreetAddress3", "");
validAddressTypes.insert("StreetCity", "");
validAddressTypes.insert("StreetCounty", "");
validAddressTypes.insert("StreetState", "");
validAddressTypes.insert("StreetZipcode", "");

//Get the addresses of a contact as values in a map.
Map GetContactAddresses(NSContactEntity contact)
{
  NSAddress contactAddress = contact.GetAddress();
  NSLocalizedField[][] fields = contactAddress.GetLocalizedAddress();

  Map addr;
  for (Integer i=0; i < fields.length(); i++)
  {
    for (Integer j=0; j<fields[i].length(); j++)
    {
      addr.insert(fields[i][j].GetName(), fields[i][j].GetValue());
    }
  }
  return addr;
}

NSContactEntity SetContactAddresses(NSContactEntity contact, Map addresses)
{
  //For troubleshooting - detect illegal address types.
  for (addresses.first(); !addresses.eof(); addresses.next())
    if (!validAddressTypes.exists(addresses.getKey()))
      exitWithMessage("Illegal address type: " + addresses.getKey());

  NSAddress contactAddress = contact.GetAddress();
  NSLocalizedField[][] fields = contactAddress.GetLocalizedAddress();

  for (Integer i = 0; i < fields.length(); i++)
  {
    for (Integer j = 0; j < fields[i].length(); j++)
    {
      if (addresses.exists(fields[i][j].GetName()))
      {
        fields[i][j].SetValue(addresses.get(fields[i][j].GetName()));
      }
    }
  }
  contactAddress.SetLocalizedAddress(fields);
  contact.SetAddress(contactAddress);
  return contact;
}
```

<!-- Referenced links -->
[1]: get-address.md
[2]: set-address.md
[3]: ../../../../globalization-and-localization/address/addresshelper.md

<!-- Referenced images -->

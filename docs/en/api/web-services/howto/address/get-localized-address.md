---
uid: get-localized-address
title: Read the LocalizedAddress
description: Read the LocalizedAddress
keywords: globalization, address
author: Tony Yates
date: 05.15.2017
version: 8
content_type: howto
redirect_from:
  - /en/globalization-and-localization/address/howto/services/get-localized-address
  - /en/api/netserver/web-services/howto/address/get-localized-address
---

# Read the LocalizedAddress

Reading the `LocalizedAddress` data structure is very straightforward. Simply loop over the `LocalizedField` lines and print out each field on each line.

The following code example demonstrates this using a `ContactAgent` to get a company and then looping over and printing out each address field.

```csharp
using(ContactAgent ca = new ContactAgent())
{
  ContactEntity ce = ca.GetContactEntity(2);

  foreach (LocalizedField[] addressLine in ce.Address LocalizedAddress)
  {

    foreach (LocalizedField addressField in addressLine)
    {
      Console.WriteLine("Item: {0}, Value: {1}", addressField.Name, addressField.Value);
    }
  }
}
```

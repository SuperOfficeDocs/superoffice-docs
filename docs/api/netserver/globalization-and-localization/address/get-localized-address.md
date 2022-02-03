---
title: Read the LocalizedAddress
uid: get_localized_address
description: Read the LocalizedAddress
author: Tony Yates
so.date: 05.15.2017
keywords: globalization
so.topic: howto
# so.envir:
# so.client:
---

## Read the LocalizedAddress

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

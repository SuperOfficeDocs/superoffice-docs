---
uid: localization-addresshelper
title: AddressHelper class
description: AddressHelper class
keywords: AddressHelper class
author: Tony Yates
date: 10.09.2025
content_type: reference
category: localization
topic: address
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/globalization-and-localization/address/addresshelper
language: en
---

# AddressHelper class

Each of the extension methods to [set LocalizedAddress][1] depends on a helper class called `AddressHelper`. The sole purpose of this class is to make it easy to get an Address as a Dictionary and transform a Dictionary into an Address.

```csharp
public class AddressHelper
{
  public Dictionary<string, string> GetAddressAsDictionary(Address address)
  {
    ValidateAddress(address);
    var result = new Dictionary<string, string>(14);

    foreach (var line in address.LocalizedAddress)
    {
      foreach (var field in line)
      {
        result.Add(field.Name, field.Value);
      }
    }
    return result;
  }

  public void SetAddressFromDictionary(Address address, Dictionary<string, string> addressInfo)
  {
    ValidateAddress(address);

    foreach (var line in address.LocalizedAddress)
    {
      foreach (var field in line)
      {
        if (addressInfo.ContainsKey(field.Name))
          field.Value = addressInfo[field.Name];
        }
      }
    }

  private void ValidateAddress(Address address)
  {
    if ( address == null
      || address.LocalizedAddress == null
      || address.LocalizedAddress.Length == 0)
      throw new Exception("Must provide a formatted Address");
  }
}
```

<!-- Referenced links -->
[1]: ../../web-services/howto/address/set-localized-address.md

---
uid: crmscript-get-address
title: Get address info
description: How to get address info with CRMScript.
keywords: address, NSLocalizedField
author: Bergfrid Dias
date: 02.16.2022
version: 9
topic: howto
---

<!-- markdownlint-disable-file MD013 -->

# Get address info

## NSLocalizedField[][] getFormattedAddress()

Fetches the formatted address of the company.

```crmscript!
Company c;
c.load(2);
NSLocalizedField[][] address;
address = c.getFormattedAddress();

for (Integer i = 0; i < address.length(); i++) {
  for (Integer j = 0; j < address[i].length(); j++) {
    print(address[i][j].GetLabel() + ":" + address[i][j].GetName() + ":" + address[i][j].GetValue() + ":" + address[i][j].GetTooltip() + ":" + address[i][j].GetValueLength().toString() + ":" + address[i][j].GetAddressType() + " ");
  }
  print("\n");
}
```

## Get address using the contact agent

```crmscript
NSContactAgent contactAgent;

NSContactEntity contact = contactAgent.GetContactEntity(2);
NSAddress address = contact.GetAddress();
NSLocalizedField[][] fields = address.GetLocalizedAddress();
```

Then you can use a double for-loop to iterate and print fields (as we did in the previous example).

<!-- Referenced links -->

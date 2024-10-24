---
uid: crmscript-set-address
title: Set address info
description: How to set address info with CRMScript.
keywords: address, NSLocalizedField, ContactAgent
author: Bergfrid Dias
date: 02.16.2022
version: 9
topic: howto
---

# Set address info

Writing address information back to this data structure can be challenging if the consumer application has a less dynamic address structure than SuperOffice CRM. You need to format their address data structure into one that SuperOffice understands.

> [!TIP]
> You can use the **pre-defined field names** to locate the same info in a corresponding external data structure. You can also flatten the address into a Map.

## Void setFormattedAddress(NSLocalizedField[][] addr)

Sets the formatted address of the company.

```crmscript
Company c;
c.load(2);
NSLocalizedField[][] address;
address[0][0].SetValue("NO-" + address[0][0].GetValue());
c.setFormattedAddress(address);
c.save();
```

Adds "NO-" to the 1st address field.

## Set address using the contact agent

```crmscript
NSContactAgent contactAgent;
NSContactEntity contact = contactAgent.GetContactEntity(2);

NSAddress address = contact.GetAddress();

NSLocalizedField[][] localAdr = address.GetLocalizedAddress();
localAdr[1][0].SetValue("Götabergsgatan 22");
localAdr[2][0].SetValue("Götabergsgatan 22");

address.SetLocalizedAddress(localAdr);
contact.SetAddress(address);
contactAgent.SaveContactEntity(contact);
```

<!-- Referenced links -->

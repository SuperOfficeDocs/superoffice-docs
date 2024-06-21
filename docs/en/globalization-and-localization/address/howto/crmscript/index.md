---
uid: crmscript-addresses
title: Address localization in CRMScript
description: Working with addresses in CRMScript.
author: Bergfrid Dias
date: 02.16.2022
keywords: address, NSLocalizedAddress, NSLocalizedField
topic: howto
---

# Address localization in CRMScript

SuperOffice data structures are generic to support multiple address variants. All CRMScript address fields belong to a structure called `NSLocalizedAddress`.

> [!NOTE]
> Some company addresses contain only a postal address while others contain both postal and street addresses. You need to check the `AddressType` to know which type of address information it is!

## NSLocalizedField properties

| Property    | Description |
|:------------|:------------|
| AddressType | determines which type of address a field belongs to |
| Name        | key         |
| Value       | corresponding value from the database |

## Howto

* [Get address info][1]
* [Set address info][2]

## Helper class

Our friends over at Ganske Enkelt have been kind enough to share CRMScript code similar to the [NetServer C# code][3] that you can incorporate into your Customer Service solutions.

[!include[ALT](includes/address-helper.md)]

<!-- Referenced links -->
[1]: get-address.md
[2]: set-address.md
[3]: ../../addresshelper.md

<!-- Referenced images -->

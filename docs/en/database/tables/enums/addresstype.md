---
uid: enum-addresstype
title: Enum values for AddressType
description: Lists the enum values for AddressType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# AddressType Enum

Bit mask, combines address type (EAddressType) and owner type (EOwnerType)

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing |
|ContactPostalAddress|1|The address is a contact's postal address|
|ContactStreetAddress|2|The address is a contact's street address|
|PersonPrivateAddress|16387|The address is a person's private address|
|QuoteBillingAddress|8196|The address is the shipping address for a quote|
|QuoteShippingAddress|8197|The address is the shipping address for a quote|

## Usage

* [address](../address.md).atype_idx - Contact and Person addresses

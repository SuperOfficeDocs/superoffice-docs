---
uid: enum-phonetype
title: Enum values for PhoneType
description: Lists the enum values for PhoneType.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# PhoneType Enum

Bit mask, combines phone type (EPhoneType) and owner type (EOwnerType)

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown - used when initializing |
|ContactPhone|1|Telephone number for a contact.|
|ContactFax|3|Facsimile number for a contact|
|PersonDirectPhone|16385|Direct dial telephone for a person|
|PersonDirectFax|16387|Direct facsimile number for a person|
|PersonPrivate|16388|Private telephone for a person|
|PersonMobile|16389|Cellular telephone for a person|
|PersonPager|16390|Pager number for a person|

## Usage

* [phone](../phone.md).ptype_idx - Contact and Person phonenumbers (+fax)

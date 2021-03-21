---
uid: enum-recipientsorting
title: Enum values for RecipientSorting
description: Lists the enum values for RecipientSorting.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RecipientSorting Enum

Which sorting should be used on the document mailing recipient list, used when generating PDF

* None = 0
* CountryZipCode = 1
* CompanyName = 2
* CompanyNumber = 3
* PersonLastname = 4

## Usage

* [s_shipment](../s-shipment.md).sorting - Contains info about one shipment. The addresses are stored in s_shipment_addr

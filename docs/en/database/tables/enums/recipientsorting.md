---
uid: enum-recipientsorting
title: Enum values for RecipientSorting
description: Lists the enum values for RecipientSorting.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# RecipientSorting Enum

Which sorting should be used on the document mailing recipient list, used when generating PDF

| Name | Value | Description |
|------|-------|-------------|
|None|0|No sorting|
|CountryZipCode|1|Sort by country and zip code|
|CompanyName|2|Sort by company name|
|CompanyNumber|3|Sort by company number|
|PersonLastname|4|Sort by person last name|

## Usage

* [s_shipment](../s-shipment.md).sorting - Contains info about one shipment. The addresses are stored in s_shipment_addr

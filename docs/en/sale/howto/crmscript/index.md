---
uid: crmscript-sale
title: Sales
description: Working with sales in CRMScript
author: Bergfrid Dias
so.date: 06.09.2023
keywords: sale
so.topic: concept
---

# Sales

## CRMScript classes

There are no native CRMScript classes pertaining to sales. Use the NetServer classes:

* [NSSaleAgent][10]
* [NSSale][11]
* [NSSaleEntity][12]
* [NSSaleStakeholder][13]
* [NSSaleStageEntity][14]
* [NSSaleType][15]

## Frequently used fields

| Field | Description |
|:--|:--|
| sale_id | ID |
| heading | Short description |
| associate_id | Owner |
| source_id | Origin of the lead |
| amount | Total sale amount |
| project_id | Optional project reference |
| contact_id | Company |
| saleType_id | Type of sale |
| status | EnumSaleStatus 1 = open, 2 = sold, 3 = lost, 4 = stalled |
| done | EnumSaleDone 0 = unknown, 1 = no, 2 = yes |

For a complete list of fields, see the [database reference][3].

## Timestamp values

| Field | Description |
|:--|:--|
| registered | UtcDateTime of registration |
| updated | UtcDateTime of last update |
| saledate | Expected closing time or when it was lost/won (DateTime) |
| nextDueDate | Closest future activity date<br>If nothing is planned: the most recent activity |

## How-tos and examples

* [Retrieve a sale][2]

<!-- Referenced links -->
[2]: get.md
[3]: ../../../database/tables/sale.md
[10]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSaleAgent.yml
[11]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSale.yml
[12]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSaleEntity.yml
[13]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSaleStakeholder.yml
[14]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSaleStageEntity.yml
[15]: ../../../automation/crmscript/reference/CRMScript.NetServer.NSSaleType.yml

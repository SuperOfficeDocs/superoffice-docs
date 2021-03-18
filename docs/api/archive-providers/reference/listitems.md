---
uid: ListItems
title: ListItems
description: Archive provider for the list of ListItems
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ListItems"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ListItemsProvider">SuperOffice.CRM.ArchiveLists.ListItemsProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of ListItems

Blah...
<para />
blah....
<para />
...
<para />
........

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|
|"deleted"|Deleted|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|udlistDefinitionId|int|UDListDefinitionId|  |
|listItemsId|int|ID: ID|  |
|listItemsName|string|Full name: Name|  |
|listItemsRank|int|Rank: Rank|  |
|listItemsTooltip|string|Description: Description|  |
|listItemsDeleted|int|Deleted: Deleted|  |
|listItemsLocation|bool|Location: Location|  |
|listItemsProbability|int|Probability: Probability|  |
|listItemsRecordType|int|Record type : Shows the record type|  |
|listItemsEmailTemplateType| *None* |Template type: Shows the template type|  |

## Sample

```http!
GET /api/v1/archive/ListItems?$select=listItemsName,listItemsTooltip
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


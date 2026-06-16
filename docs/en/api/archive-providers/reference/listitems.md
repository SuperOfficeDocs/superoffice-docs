---
uid: ListItems
title: ListItems
description: Archive provider for the list of ListItems
keywords: ListItems archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ListItems"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ListItemsProvider">SuperOffice.CRM.ArchiveLists.ListItemsProvider</see> inside NetServer's SODatabase assembly.

Archive provider for the list of ListItems

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|[[SR_VFC_ALL]]|
|"deleted"|[[SR_ARCHIVE_DELETED]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|udlistDefinitionId|int|SR\_LISTITEMARCHIVE\_UDLISTDEFINITIONID|  |
|listItemsId|int|SR\_LISTITEMARCHIVE\_ID: SR\_LISTITEMARCHIVE\_ID\_TOOLTIP|  |
|listItemsName|string|SR\_LISTITEMARCHIVE\_NAME: SR\_LISTITEMARCHIVE\_NAME\_TOOLTIP|  |
|listItemsRank|int|SR\_LISTITEMARCHIVE\_RANK: SR\_LISTITEMARCHIVE\_RANK\_TOOLTIP|  |
|listItemsTooltip|string|SR\_LISTITEMARCHIVE\_TOOLTIP: SR\_LISTITEMARCHIVE\_TOOLTIP\_TOOLTIP|  |
|listItemsDeleted|int|SR\_LISTITEMARCHIVE\_DELETED: SR\_LISTITEMARCHIVE\_DELETED\_TOOLTIP|  |
|listItemsLocation|bool|SR\_LISTITEMARCHIVE\_LOCATION: SR\_LISTITEMARCHIVE\_LOCATION\_TOOLTIP|  |
|listItemsProbability|int|SR\_LISTITEMARCHIVE\_PROBABILITY: SR\_LISTITEMARCHIVE\_PROBABILITY\_TOOLTIP|  |
|listItemsRecordType|int|SR\_ACTIVITYARCHIVE\_RECORDTYPE: SR\_ACTIVITYARCHIVE\_RECORDTYPE\_TOOLTIP|  |
|listItemsEmailTemplateType| *None* |SR\_ADMIN\_LISTS\_TEMPLATETYPE: SR\_ADMIN\_LISTS\_TEMPLATETYPE\_TOOLTIP|  |

## Sample

```http!
GET /api/v1/archive/ListItems?$select=listItemsName,listItemsTooltip
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: SelectionMemberStatic
title: SelectionMemberStatic
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "SelectionMemberStatic"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "SelectionMemberStatic"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SelectionMemberStaticProvider">SuperOffice.CRM.ArchiveLists.SelectionMemberStaticProvider</see> inside NetServer's SODatabase assembly.

Provider for the Selection Member table

This provider is intended to be used when working with static selections.
It will only return fields from the SelectionMember table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"selectionMember"|[Selection Member]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|selectionId|int|Selection ID: The database ID of the selection|  |
|selectionMemberId|int|Selection member ID: The database ID of the selection member record|  |
|rowKind| *None* |Icon indicating whether the row comes from a static or a dynamic selection|  |
|targetTableNumber|int|TargetTableNumber: TargetTableNumber| x |
|targetRecordId|int|TargetRecordId: TargetRecordId| x |
|contactId|int|Company ID: Database ID of company| x |
|personId|int|Contact ID: Database ID of the contact row| x |

## Sample

```http!
GET /api/v1/archive/SelectionMemberStatic?$select=selectionMemberId,rowKind
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


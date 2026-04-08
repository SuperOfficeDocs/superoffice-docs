---
uid: ErpField
title: ErpField
description: 
keywords: ErpField archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ErpField"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpFieldProvider">SuperOffice.CRM.ArchiveLists.ErpFieldProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"erpfield"|ErpField|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|Id|stringorPK|Id: Id| x |
|ErpConnectionActorTypeId|int|ErpConnectionActorTypeId: ErpConnectionActorTypeId| x |
|ErpFieldKey|string|ErpFieldKey: ErpFieldKey| x |
|DisplayName|string|ERP field: ERP field| x |
|DisplayDescription|string|Description: Description| x |
|FieldType|int|FieldType: FieldType| x |
|ListName|string|ListName: ListName| x |
|DefaultValue|string|DefaultValue: DefaultValue| x |
|MaxLength|int|MaxLength: MaxLength| x |
|Access|int|Access: Access| x |
|HasFirstSyncDefaultValue|int|HasFirstSyncDefaultValue: HasFirstSyncDefaultValue| x |
|FirstSyncDefaultValue|string|Default value: Default value| x |
|PromptUser|bool|Ask user: Ask user| x |
|Mandatory|bool|Mandatory: Mandatory| x |
|CrmFieldKey|string|CrmFieldKey: CrmFieldKey| x |
|SyncToCrm|int|SyncToCrm: SyncToCrm| x |
|SyncToErp|int|SyncToErp: SyncToErp| x |
|ShowInGui|int|ShowInGui: ShowInGui| x |
|ShowInSearch|int|ShowInSearch: ShowInSearch| x |
|Rank|int|Rank: Rank| x |
|ListReference|string|ListReference: ListReference| x |
|MissingInERP|int|MissingInERP: MissingInERP| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |
|ConnectionId|int|ConnectionId: ConnectionId| x |
|ActorTypeErp|string|ActorTypeErp: ActorTypeErp| x |
|PromptOrHasDefault|bool|PromptOrHasDefault: PromptOrHasDefault| x |

## Sample

```http!
GET /api/v1/archive/ErpField?$select=MaxLength,Mandatory
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


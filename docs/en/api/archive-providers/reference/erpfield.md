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
|DisplayName|string|SR\_ADMIN\_EIS\_ERPFIELD: SR\_ADMIN\_EIS\_ERPFIELD| x |
|DisplayDescription|string|SR\_ADMIN\_ERP\_SYNC\_DESCRIPTION: SR\_ADMIN\_ERP\_SYNC\_DESCRIPTION| x |
|FieldType|int|FieldType: FieldType| x |
|ListName|string|ListName: ListName| x |
|DefaultValue|string|DefaultValue: DefaultValue| x |
|MaxLength|int|MaxLength: MaxLength| x |
|Access|int|Access: Access| x |
|HasFirstSyncDefaultValue|int|HasFirstSyncDefaultValue: HasFirstSyncDefaultValue| x |
|FirstSyncDefaultValue|string|SR\_ADMIN\_ERP\_SYNC\_DEFAULT\_VALUE: SR\_ADMIN\_ERP\_SYNC\_DEFAULT\_VALUE| x |
|PromptUser|bool|SR\_ADMIN\_ERP\_SYNC\_ASK\_USER: SR\_ADMIN\_ERP\_SYNC\_ASK\_USER| x |
|Mandatory|bool|SR\_ADMIN\_ERP\_SYNC\_MANDATORY\_1: SR\_ADMIN\_ERP\_SYNC\_MANDATORY\_1| x |
|CrmFieldKey|string|CrmFieldKey: CrmFieldKey| x |
|SyncToCrm|int|SyncToCrm: SyncToCrm| x |
|SyncToErp|int|SyncToErp: SyncToErp| x |
|ShowInGui|int|ShowInGui: ShowInGui| x |
|ShowInSearch|int|ShowInSearch: ShowInSearch| x |
|Rank|int|Rank: Rank| x |
|ListReference|string|ListReference: ListReference| x |
|MissingInERP|int|MissingInERP: MissingInERP| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |
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


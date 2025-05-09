---
uid: ErpEntity
title: ErpEntity
description: 
keywords: ErpEntity archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "ErpEntity"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ErpEntityProvider">SuperOffice.CRM.ArchiveLists.ErpEntityProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ErpEntity"|ERP entity|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ConnectionId| *None* |ERP connection ID: ERP connection ID| x |
|SearchText| *None* |Search text: Search text| x |
|ErpActorType| *None* |Actor type: Actor type| x |
|Connected| *None* |Connected: Connected| x |
|OnlyParentConnected| *None* |OnlyParentConnected: OnlyParentConnected| x |
|ErpKey| *None* |ErpKey: ErpKey| x |

## Sample

```http!
GET /api/v1/archive/ErpEntity?$select=ErpActorType,Connected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


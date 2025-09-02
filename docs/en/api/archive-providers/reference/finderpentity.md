---
uid: FindErpEntity
title: FindErpEntity
description: 
keywords: FindErpEntity archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "FindErpEntity"

This provider name is implemented by the class <see cref="T:SuperOffice.ErpSync.FindErpEntityProvider">SuperOffice.ErpSync.FindErpEntityProvider</see> inside NetServer's SODatabase assembly.

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
GET /api/v1/archive/FindErpEntity?$select=ErpActorType,Connected
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


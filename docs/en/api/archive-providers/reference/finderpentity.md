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
|"ErpEntity"|[[SR_CONNECTION_ERP_ENTITY]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ConnectionId| *None* |SR\_CONNECTION\_ID: SR\_CONNECTION\_ID| x |
|SearchText| *None* |SR\_EIS\_ERP\_SEARCH\_TEXT: SR\_EIS\_ERP\_SEARCH\_TEXT| x |
|ErpActorType| *None* |SR\_EIS\_ERP\_ACTOR\_TYPE: SR\_EIS\_ERP\_ACTOR\_TYPE| x |
|Connected| *None* |SR\_EIS\_CONNECTED: SR\_EIS\_CONNECTED| x |
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


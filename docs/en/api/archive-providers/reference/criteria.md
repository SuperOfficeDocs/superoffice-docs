---
uid: Criteria
title: Criteria
description: 
keywords: Criteria archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Criteria"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.CriteriaProvider">SuperOffice.CRM.ArchiveLists.CriteriaProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"criteria"|criteria|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|key| *None* |SR\_CRITERION\_KEY: SR\_CRITERION\_KEY\_TOOLTIP| x |
|active| *None* |SR\_CRITERION\_ACTIVE: SR\_CRITERION\_ACTIVE\_TOOLTIP| x |
|icon| *None* |SR\_CRITERION\_ICON: SR\_CRITERION\_ICON\_TOOLTIP| x |
|criterion| *None* |SR\_CRITERION\_NAME: SR\_CRITERION\_NAME\_TOOLTIP| x |
|operator| *None* |SR\_CRITERION\_OPERATOR: SR\_CRITERION\_OPERATOR\_TOOLTIP| x |
|value| *None* |SR\_CRITERION\_VALUE: SR\_CRITERION\_VALUE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/Criteria?$select=icon,criterion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: Criteria
title: Criteria
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Criteria"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.CriteriaProvider">SuperOffice.CRM.ArchiveLists.CriteriaProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"criteria"|[criteria]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|key| *None* |Key: Unique key, based on criterion name and any subcriteria| x |
|active| *None* |Enabled: Specifies whether the criterion is enabled| x |
|icon| *None* |Icon: Criterion icon, based on icon of current column| x |
|criterion| *None* |Name: The name of the search criterion| x |
|operator| *None* |Operator: The operator used by this search criterion| x |
|value| *None* |Value: The value used by the search criterion.| x |

## Sample

```http!
GET /api/v1/archive/Criteria?$select=icon,criterion
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


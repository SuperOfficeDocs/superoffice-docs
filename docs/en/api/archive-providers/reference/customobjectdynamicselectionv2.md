---
uid: CustomObjectDynamicSelectionV2
title: CustomObjectDynamicSelectionV2
description: CustomObject selection archive with OR-able selection groups. Each group is represented with the <see cref="T -SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderSingleCriteriaGroup" />.
keywords: CustomObjectDynamicSelectionV2 archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "CustomObjectDynamicSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderV2">SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderV2</see> inside NetServer's SODatabase assembly.

CustomObject selection archive with OR-able selection groups. Each group is represented with the <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionDynamicProviderSingleCriteriaGroup" />.

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |

## Sample

```http!
GET /api/v1/archive/CustomObjectDynamicSelectionV2:y_car?$select=x_name
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


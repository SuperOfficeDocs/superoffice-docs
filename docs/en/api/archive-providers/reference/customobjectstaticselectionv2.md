---
uid: CustomObjectStaticSelectionV2
title: CustomObjectStaticSelectionV2
description: Static archive Provider for a Selection of CustomObject archive.
keywords: CustomObjectStaticSelectionV2 archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "CustomObjectStaticSelectionV2"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionStaticProviderV2">SuperOffice.CRM.ArchiveLists.Archive.CustomObjectSelectionStaticProviderV2</see> inside NetServer's SODatabase assembly.

Static archive Provider for a Selection of CustomObject archive.

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |

## Sample

```http!
GET /api/v1/archive/CustomObjectStaticSelectionV2:y_car?$select=x_name
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


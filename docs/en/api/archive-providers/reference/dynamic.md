---
uid: Dynamic
title: Dynamic
description: 
keywords: Dynamic archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Dynamic"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.DotSyntaxProvider">SuperOffice.CRM.ArchiveLists.DotSyntaxProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities

See <xref:rest_api_search_dynamic> for more information.

## Supported Columns

Columns are defined by the caller. See <xref:rest_api_search_dynamic> for more information.


## Sample

```http!
GET /api/v1/archive/Dynamic?$select=
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


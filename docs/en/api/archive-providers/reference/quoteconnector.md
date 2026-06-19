---
uid: QuoteConnector
title: QuoteConnector
description: 
keywords: QuoteConnector archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "QuoteConnector"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectorProvider">SuperOffice.CRM.ArchiveLists.QuoteConnectorProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"connector"|??Connector|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|name| *None* |SR\_CONNECTOR\_NAME: SR\_CONNECTOR\_NAME\_TOOLTIP| x |
|className| *None* |SR\_CLASS\_NAME: SR\_CLASS\_NAME\_TOOLTIP| x |
|assemblyName| *None* |SR\_ASSEMBLY\_NAME: SR\_ASSEMBLY\_NAME\_TOOLTIP| x |
|location| *None* |SR\_CONNECTOR\_LOCATION: SR\_CONNECTOR\_LOCATION\_TOOLTIP| x |
|filename| *None* |SR\_SINGULAR\_FILENAME| x |
|version| *None* |SR\_TRAYAPP\_ABOUT\_VERSION: SR\_TRAYAPP\_ABOUT\_VERSION\_TOOLTIP| x |
|licensed|bool|SR\_QUOTE\_HASERPLICENSE: SR\_QUOTE\_HASERPLICENSE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/QuoteConnector?$select=assemblyName,location
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


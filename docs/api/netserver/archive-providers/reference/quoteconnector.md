---
uid: QuoteConnector
title: QuoteConnector
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "QuoteConnector"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "QuoteConnector"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.QuoteConnectorProvider">SuperOffice.CRM.ArchiveLists.QuoteConnectorProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"connector"|[??Connector]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|name| *None* |Name: Name (from code) of the Quote Connector| x |
|className| *None* |Class name (C#: The name of C# type that implements the Quote Connector| x |
|assemblyName| *None* |Assembly name: Name of the DLL ('assembly') the Quote Connector has been loaded from| x |
|location| *None* |Source: The source that the Quote Connector was loaded from| x |
|filename| *None* |File name | x |
|version| *None* |Version: Version of module| x |
|licensed|bool|Licensed: A valid license exists for this module, or it does not need a license| x |

## Sample

```http!
GET /api/v1/archive/QuoteConnector?$select=assemblyName,location
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


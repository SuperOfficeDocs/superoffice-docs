---
uid: cs-soap-ports-admin-getagent
title: getAgent
description: Services SOAP interface port admin getAgent
keywords: admin port, getAgent method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/admin/getAgent
---

# getAgent

## Description

> [!CAUTION]
> This method should normally not be used.

Gets the binary file of the agent available on the server.

## In parameters

| Parameter | Description |
|---|---|

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| binaryData | The binary executable |

## Example

```csharp
admin.adminService adminService = new admin.adminService();
System.Byte[] data;

if(adminService.getAgent( out data ) == "0")
{
  //...storeDataToDisk...
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

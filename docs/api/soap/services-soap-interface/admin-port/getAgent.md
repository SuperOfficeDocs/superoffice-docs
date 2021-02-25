---
title: cs_soap_ports_admin_getagent
description: Services SOAP interface port admin getAgent
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
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
[1]: ../error-codes.md

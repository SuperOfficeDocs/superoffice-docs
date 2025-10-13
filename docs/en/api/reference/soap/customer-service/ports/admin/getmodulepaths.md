---
uid: cs-soap-ports-admin-getmodulepaths
title: getModulePaths
description: Services SOAP interface port admin getModulePaths
keywords: admin port, getModulePaths method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/admin/getModulePaths
---

# getModulePaths

## Description

Returns a list of the name and paths to all executable cgi-bin modules of Service (`customer= <http://cs.mydomain.com/scripts/customer.exe>`). Useful if you need to redirect to a specific frame or screen in Service.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
|  paths | An array of names and modules:<br />module – the name<br />path – the path |

## Example

```csharp
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0"))
{
  admin.ModulePathStruct[] tmpPaths;
  adminService.getModulePaths(sessionKey, out tmpPaths);
  foreach(admin.ModulePathStruct i in tmpPaths)
  {
    cout << "module: " << i.module << " path: " << i.path << endl;
  }
}
```

<!-- Referenced links -->
[1]: ../../error-codes.md

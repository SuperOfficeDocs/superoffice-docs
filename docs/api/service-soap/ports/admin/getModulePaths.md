---
title: cs_soap_ports_admin_getmodulepaths
description: Services SOAP interface port admin getModulePaths
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
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
|  paths | An array of names and modules:<br>module – the name<br>path – the path |

## Example

```csharp
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
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

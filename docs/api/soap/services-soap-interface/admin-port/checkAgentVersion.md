---
title: cs_soap_ports_admin_checkagentversion
description: Services SOAP interface port admin checkAgentVersion
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# checkAgentVersion

## Description

> [!CAUTION]
> This method should normally not be used.

Checks if your Service Agent client is older than the one available on the server. You can also be notified that you should upgrade as the version you are using is incompatible with SuperOfficeService on the server.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| version | The version of the agent |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| newVersion | True if there is a new version on the server. |

## Example

```csharp
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

string sessionKey;
string errorCode = ticketService.login("egon", "norges bank", out sessionKey);

if (errorCode.Equals("0")
{
  boolean newVersion;
  boolean forceUpgrade;
  adminService.checkAgentVersion(sessionKey, "13", out newVersion, out forceUpgrade);
  if(newVersion)
  {
    //...doUpgradeStuff()...
  }
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

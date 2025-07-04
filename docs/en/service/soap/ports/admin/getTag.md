---
title: getTag
uid: cs_soap_ports_admin_gettag
description: Services SOAP interface port admin getTag
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# getTag

## Description

Get the tag that is used by eJournal to identify incoming emails with the correct request.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |

## Out parameters

| Parameter | Description |
|---|---|
| tag | The configured tag for Service |

## Example

```csharp
string sessionKey;
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

string errorCode = ticketService.login("test","test",out sessionKey);
if(errorCode.Equals("0"))
{
  string tag;
  adminService.getTag(sessionKey, out tag);
}
```

<!-- Referenced links -->

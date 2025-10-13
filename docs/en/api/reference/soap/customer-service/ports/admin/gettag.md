---
uid: cs-soap-ports-admin-gettag
title: getTag
description: Services SOAP interface port admin getTag
keywords: admin port, getTag method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/admin/getTag
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

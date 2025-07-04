---
title: getErrorMessage
uid: cs_soap_ports_admin_geterrormessage
description: Services SOAP interface port admin getErrorMessage
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# getErrorMessage

## Description

Finds the descriptive text for an error. These messages are linked to the session, so only the last error message for one session is returned. For errors before you receive a valid session key see the appendix.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key. |

## Out parameters

| Parameter | Description |
|---|---|
| errorMessage | A text explaining the last error. |

## Example

```csharp
string sessionKey;
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

ticketService.login("test","test",out sessionKey);

string res = some_method();
if(res =="0")
  textBox1.Text = "OK";
else
  textBox1.Text = adminService.getErrorMessage(sessionKey);
```

<!-- Referenced links -->

---
title: cs_soap_ports_admin_getuser
description: Services SOAP interface port admin getUser
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getUser

## Description

With this method, you can get various information about the logged-in user (using the `sessionKey`). Just supply the fields you want to retrieve.

**Valid fields:**

* user.id
* user.name
* user.firstname
* user.middlename
* user.lastname
* user.email
* user.loginname
* user.username
* user.language (0 = English, 1 = Norwegian)  

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| userFields | An array of strings where each element is one of the above |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| userResult - An array of ResultStruct where each element is of the form:<br>field (name of the requested field)<br>value (the value of the requested field)<br>type (the type of the requested field) |

## Example

```csharp
admin.adminService adminService = new admin.adminService();
ticket.ticketService ticketService = new ticket.ticketService();

string sessionKey;
string errorCode = ticketService.login("egon", "pass1234", out sessionKey);

if (errorCode.Equals("0")
{
  admin.ResultStruct[] userResult;
  string[] userFields = new string[2];
  userFields[0] = "user.id";
  userFields[1] = "user.email";
  errorCode = adminService.getUser(sessionKey, userFields, out userResult);

  foreach(admin.ResultStruct i in userResult)
  {
    string field = i.field; // Here you get the field
    string value = i.value; // Here you get the value
    string type = i.type;   // Here you get the type
  }
}
```

<!-- Referenced links -->
[1]: ../error-codes.md

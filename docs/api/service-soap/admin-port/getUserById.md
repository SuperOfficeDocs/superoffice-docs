---
title: cs_soap_ports_admin_getuserbyid
description: Services SOAP interface port admin getUserById
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getUserById

## Description

With this method, you can get various information about the specified user. Just supply the fields you want to retrieve and the user ID.

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
* user.status (1 = Normal, 2 = Not available, 3 = Deleted, 4 = Read Only)

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| userId | A valid user ID |
| userFields | An array of strings where each element is one of the above |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| userResult | An array of ResultStruct where each element is of the form:<br>field (name of the requested field)<br>value (the value of therequested field)<br>type (the type of the requested field) |

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
  errorCode = adminService.getUser(sessionKey, "2", userFields, out           userResult);

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

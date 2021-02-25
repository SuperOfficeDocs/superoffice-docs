---
title: cs_soap_ports_admin_setuser
description: Services SOAP interface port admin setUser
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# setUser

## Description

With this method you can set various information about a user. Just supply the fields you want to retrieve.

**Valid fields:**

* user.password
* user.firstname
* user.middlename
* user.lastname
* user.email
* user.loginname
* user.username
* user.language (0 = English, 1 = Norwegian)
* user.status (1 = Normal, 2 = Not available)

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| userValues | An array of ValuePairStructs with a field and value |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |

<!-- Referenced links -->
[1]: ../error-codes.md

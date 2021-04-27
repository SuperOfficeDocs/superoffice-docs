---
title: cs_soap_ports_admin_getusers
description: Services SOAP interface port admin getUsers
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# getUsers

## Description

With this method, you will get theIDs of the users in SuperOffice. You can specify if you want to get only those set to normal in SuperOffice or if you want to get everyone (except deleted and read users). The result is sorted by username.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| includeOnlyNormal | do only include those with status "Normal" |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| users | An array of user ids, sorted by username |

<!-- Referenced links -->
[1]: ../error-codes.md

---
title: cs_soap_ports_ticket_finduser
description: Services SOAP interface ticket reference findUser
author: {github-id}             # Your GitHub alias.
keywords: soap
so.date: 01.25.2021
so.topic: reference
---

# findUser

## Description

Finds the ID of the specified user. If the specified user is not found, an error code will be returned.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| field | The field to search. Valid fields are: username, loginname, email |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| userId | The ID of the user |

<!-- Referenced links -->
[1]: ../error-codes.md

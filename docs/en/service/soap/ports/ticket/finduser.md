---
title: findUser
uid: cs_soap_ports_ticket_finduser
description: Services SOAP interface ticket reference findUser
author: SuperOffice Product and Engineering
keywords: soap
date: 01.25.2021
content_type: reference
---

# findUser

## Description

Finds the ID of the specified user. If the specified user is not found, an error code will be returned.

## In parameters

| Parameter | Description |
|---|---|
| sessionKey | A valid session key |
| field | The field to search. Valid fields: username, loginname, email |

## Out parameters

| Parameter | Description |
|---|---|
| errorCode | [See list of codes][1] |
| userId | The ID of the user |

<!-- Referenced links -->
[1]: ../../error-codes.md

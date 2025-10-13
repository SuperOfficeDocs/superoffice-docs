---
uid: cs-soap-ports-ticket-finduser
title: findUser
description: Services SOAP interface ticket reference findUser
keywords: ticket port, findUser method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/ticket/finduser
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

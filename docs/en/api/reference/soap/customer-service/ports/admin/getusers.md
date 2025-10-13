---
uid: cs-soap-ports-admin-getusers
title: getUsers
description: Services SOAP interface port admin getUsers
keywords: admin port, getUsers method
author: SuperOffice Product and Engineering
date: 01.25.2021
content_type: reference
category: Service
topic: legacy SOAP interface
language: en
redirect_from: /en/service/soap/ports/admin/getUsers
---

# getUsers

## Description

With this method, you will get the IDs of the users in SuperOffice. You can specify if you want to get only those set to normal in SuperOffice or if you want to get everyone (except deleted and read users). The result is sorted by username.

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
[1]: ../../error-codes.md

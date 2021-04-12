---
title: rest_api_search_associate
description: REST Web API search associate
author: {github-id}             # Your GitHub alias.
keywords: search,odata
so.date:
so.topic: howto
---

# Associate

## Associate is one of

```http
GET /api/v1/contact?$select=name,associateId&$filter=registeredBy associateIsOneOf (1,6) HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Associate is not one of

```http
GET /api/v1/contact?$select=name,associateId&$filter=registeredBy associateIsNotOneOf (1,6) HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

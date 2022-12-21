---
title: ODATA lists
uid: odata_lists
description: REST Web API search - lists
author: {github-id}
keywords: search, list, odata
so.date:
so.topic: howto
---

# ODATA lists

## Equals

```http
GET /api/v1/contact?$select=name,associateId&$filter=category equals 4 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## One of

```http
GET /api/v1/contact?$select=name,associateId&$filter=category oneOf (3,6) HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not one of

```http
GET /api/v1/contact?$select=name,associateId,category&$filter=category notOneOf (3,6) HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

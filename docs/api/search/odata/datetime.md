---
title: rest_api_search_datetime
description: REST Web API search DateTime
author: {github-id}             # Your GitHub alias.
keywords: search
so.date:
so.topic: howto
---

# DateTime

## Equals DateTime

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date dateTime '2020-05-28T15:00:00' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Before DateTime

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date beforeTime '2020-05-28T15:00:00' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## After DateTime

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date afterTime '2020-05-28T15:00:01' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

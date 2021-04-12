---
title: rest_api_search_dates
description: REST Web API search dates
author: {github-id}             # Your GitHub alias.
keywords: search
so.date:
so.topic: howto
---

# Dates

## Get all

```http
GET /api/v1/appointment?$select=type,text,contact/name HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Before date

```http
GET /api/v1/appointment?$select=date,type,text,contact/name?&$filter=date before '2020-05-28' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## After date

```http
GET /api/v1/appointment?$select=type,text,contact/name?&$filter=date after '2020-05-28' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## On Date

```http
GET /api/v1/appointment?$select=date, type,text,contact/name?&$filter=date date '2020-05-28' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Between dates

```http
GET /api/v1/appointment?$select=date, type,text,contact/name?&$filter=date between ('2020-05-11','2020-05-31') HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Before or Equal date

```http
GET /api/v1/appointment?$select=type,text,contact/name?&$filter=date beforeOrEqual '2020-05-28' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

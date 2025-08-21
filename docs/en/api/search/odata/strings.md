---
uid: rest-api-search-strings
title: String
description: REST Web API search strings
keywords: search, odata, string
author: Tony Yates, Eivind Fasting
date: 06.18.2024
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/api/netserver/search/odata/strings
---

# String

## Begins with

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name begins 'S' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Between

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name between ('A','S') HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Contains

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name contains 'Orgnr' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Equals (is)

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name is 'Testing null Orgnr' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Is not

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name isNot 'SuperOffice Software Limited' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not begins

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name notBegins 'S' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not contains

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name notContains 'Owl' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

### One of (in)

```http
GET /api/v1/contact?$select=name,category&$filter=name in ('SuperOffice Software Limited', 'Owl') HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

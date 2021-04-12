---
title: rest_api_search_strings
description: REST Web API search strings
author: {github-id}             # Your GitHub alias.
keywords: search,odata
so.date:
so.topic: howto
---

# String

## Begins with

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name begins 'S' HTTP/1.1
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

## Contains

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name contains 'Orgnr' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not Begins

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name notBegins 'S' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not Contains

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name notContains 'Owl' HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Is Not

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=name isNot 'SuperOffice Software Limited' HTTP/1.1
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

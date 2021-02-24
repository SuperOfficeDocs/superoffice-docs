---
title: rest_api_search_numbers
description: REST Web API search numbers
author: {github-id}             # Your GitHub alias.
keywords: search,odata
so.date:
so.topic: howto
---

# Numbers (integer, decimal, float)

## Equals

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId = 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId eq 2 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId equals 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId set 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not equals

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId ne 2 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Less than

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId lt 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId less 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Greater than

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId gt 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId greater 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

## Not equal to

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=contactId unequals 5 HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

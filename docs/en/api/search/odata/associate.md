---
title: Associate
uid: rest_api_search_associate
description: REST Web API search associate
author: SuperOffice Product and Engineering
keywords: search,odata
date:
content_type: howto
redirect_from: /en/api/netserver/search/odata/associate
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

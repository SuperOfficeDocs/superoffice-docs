---
uid: rest-api-search-contact
title: Select all companies
description: How to read all the companies in SuperOffice with REST Web API.
keywords: contact, company, services, API, search, rest
author: Tony Yates
date: 11.04.2021
content_type: howto
redirect_from:
  - /en/company/howto/services/get-all-contacts-rest
  - /en/api/netserver/web-services/howto/company/get-all-contacts-rest
---

# Select all companies

Read all the companies in SuperOffice.

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

```javascript
companies = Get("api/v1/Contact?$select=name,category,number")
// companies.value = 
  [
    {
    "PrimaryKey": "3",
    "EntityName": "contact",
    "name": "Amadeus AS",
    "category": "Kunde",
    "number": "AA10011"
    },{
    "PrimaryKey": "4",
    "EntityName": "contact",
    "name": "Arne's Kebab",
    "category": "Kunde",
    "number": "AA10012"
    },{
    "PrimaryKey": "5",
    "EntityName": "contact",
    "name": "Bjørge AS",
    "category": "Kunde",
    "number": "BB10013"
    } ]
```

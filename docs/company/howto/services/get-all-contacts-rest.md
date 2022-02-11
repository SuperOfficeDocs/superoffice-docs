---
title: Select all companies
uid: rest_api_search_contact
description: How to read all the companies in SuperOffice with REST Web API.
author: {github-id}
keywords: contact, company, services, API, search, rest
so.date: 11.04.2021
so.topic: howto
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

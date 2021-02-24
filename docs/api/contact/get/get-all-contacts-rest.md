---
title: rest_api_search_contact
description: REST Web API contact
author: {github-id}             # Your GitHub alias.
keywords: search
so.date:
so.topic: howto
---


# Select all companies

Read all the companies in SuperOffice

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

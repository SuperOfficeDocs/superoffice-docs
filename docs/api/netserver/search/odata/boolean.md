---
title: rest_api_search_boolean
description: REST Web API search boolean
author: {github-id}             # Your GitHub alias.
keywords: search,odata
so.date:
so.topic: howto
---

# Boolean

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=hasInterests set true HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

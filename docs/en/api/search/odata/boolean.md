---
title: Boolean
uid: rest_api_search_boolean
description: REST Web API search boolean
author: SuperOffice Product and Engineering
keywords: search,odata
date:
content_type: howto
redirect_from: /en/api/netserver/search/odata/boolean
---

# Boolean

```http
GET /api/v1/contact?$select=name,associateId,contactAssociate/fullName&$filter=hasInterests set true HTTP/1.1
Authorization: Bearer 8A:
Content-Type: application/json
Accept: application/json
```

---
title: Content types
uid: web_api_headers_content_type
description: Web API headers content types
author: {github-id}
so.date: 
keywords: 
so.topic: concept 
---

# Content types

The API supports both JSON and XML responses. Use the `Accept` header to specify which you would like to receive.

## XML

```http
Accept: application/xml
GET /api/v1/Contact/123
```

Returns an XML representation of the contact:

```xml
<ContactEntity>
  <ContactId>123</ContactId>
  <Name>Elan Hoppski</Name>
  <Department>EAvdeling</Department>
  <OrgNr></OrgNr>
  <Number1>123</Number1>
</ContactEntity>
```

## JSON

```http
Accept: application/json
GET /api/v1/Contact/123
```

Returns a JSON representation of the same (contact 123):

```json
 { "ContactId": 123,
   "Name": "Elan Hoppski",
   "Department": "EAvdeling",
   "OrgNr": "",
   "Number1": "123"
 }
```

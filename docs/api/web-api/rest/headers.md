---
title: HTTP request headers
uid: rest_api_headers
description: REST Web API HTTP request headers
author: {github-id}
keywords:
so.date:
so.topic: concept
---

# HTTP request headers

These headers only apply to the REST API.

## Modified / Unmodified

These headers apply to the major entities (Contact, Project,...) that have last modified date fields on them.

### If-Modified-Since

Returns HTTP code **304 Not Modified** if the entity has not been modified since the given date+time on the GET request.

`GET /api/v1/Contact/123` always returns a contact object.

```http
GET /api/v1/Contact/123
If-Modified-Since: Wed, 21 Oct 2015 07:28:00 GMT
```

will return a **304 Not Modified** response if the contact has not been modified since Oct 2015. This basically tells you that your cached copy of the data is still good.

### If-Unmodified-Since

Returns HTTP code **412 Precondition failed** if the entity has been modified since the given date+time on the PUT update request.

``` http
PUT /api/v1/Contact/123 
{ Name: "Some updates" }
```

always updates the contact object.

```http
PUT /api/v1/Contact/123
If-Unmodified-Since: Wed, 21 Oct 2015 07:28:00 GMT
{ Name: "Some updates" }
```

will return a **412 Precondition failed** response if the contact has been modified after Oct 2015.

This is telling you that your cached copy of the data is no good anymore. It has been modified on the server since you fetched it.

---
title: WebAPI
uid: web_api
description: Web API overview
author: {github-id}
so.date: 
keywords: webapi
so.topic: concept
---

# WebAPI

The HTTP WebAPI comes in 2 parts:

* [REST WebAPI][1] - URLs describe entities like person or sale
* [Agents WebAPI][2] - the services API accessible via HTTP

The **REST** API is not as complete as the **Agents** API, but it should cover the most common use cases, and be easier to use and navigate.

## Authorization

You will need to provide some login information in order to use the SuperOffice web API.

* BASIC authentication: Base64 Encode SuperOffice username:password
* SOTICKET authentication. Pass the SuperOffice ticket (7T:abc123==) without any encoding.
* BEARER authentication. Online only. Pass along an access token (7A:abc123==) from SuperId.

### X-XSRF-TOKEN

If you call the API without specifying an **Authorization** header, then the API will try to log in using the current user's session. To avoid 3rd party pages calling the API and piggy-backing off the current session, the API requires that a special HTTP header is added to these requests.

The SM.web pages contain an INPUT field XSRF_TOKEN. This field contains a random value identifying the current session. You must add an X-XSRF-TOKEN header with the random value from the input field.

The XSRF-TOKEN is also stored in a cookie, just in case the input field is not available.

<!-- Referenced links -->
[1]: rest/index.md
[2]: agents/index.md

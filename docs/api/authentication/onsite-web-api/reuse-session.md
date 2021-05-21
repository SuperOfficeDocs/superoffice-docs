---
title: Re-use existing session
uid: web_api_auth_x-xsrf
description: Web API authentication X-XSRF-token
author: {github-id}
so.date: 
keywords: 
so.topic: concept 
---

# Re-use existing session

## X-XSRF-TOKEN

If you call the API without specifying an **Authorization** header, then the API will try to log in using the current user's SuperOffice session. To avoid 3rd-party pages calling the API and piggy-backing off the current session, the API requires that a special HTTP header is added to these requests.

The SuperOffice pages contain an INPUT field XSRF_TOKEN. This field contains a random value identifying the current session. You must add an X-XSRF-TOKEN header with the random value from the input field.

The XSRF-TOKEN is also stored in a cookie for convenience. HTTP libraries like AXIOS will automatically pick up the XSRF-TOKEN cookie from the browser and add the X-XSRF-TOKEN header to your HTTP requests.

```http
GET /api/v1/Contact/2
Accept: application/json
```

will return HTTP error 401 Unauthorized.

```http
GET /api/v1/Contact/2
Accept: application/json
X-XSRF-TOKEN: abc1234
```

will work, and use the current user's session to read the data.

> [!NOTE]
> The user must be logged in. After the user logs out, the XSRF-TOKEN is not valid, and there is no existing session for you to re-use.

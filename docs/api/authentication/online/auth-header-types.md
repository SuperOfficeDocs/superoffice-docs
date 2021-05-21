---
title: Authorization header types
uid: auth_headers_types
description: Authorization header types
author: {github-id}
keywords: authentication,soticket,bearer
so.topic: concept
so.envir: cloud
so.client: online
---

# Authorization header types

Your application needs to provide one of the following authorization header types when accessing our APIs. Choose either SOTicket or Bearer.

## SOTicket authentication

**Content:**

Authorization header with the SuperOffice **SOTICKET** token.

**SO-AppToken** header, which is the client_secret, also known as the application secret.

**Example:**

```http
GET /Cust12345/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
accept-language: en
Authorization: SOTICKET 7T:MAA3AGYA...MgA2ADcANQA5AA==
SO-AppToken: f2398a3a7wer3759d4b220e9a9c94321
```

## Bearer authentication

**Content:**  Authorization header containing Bearer and [access token][1] from SuperID

**Example:**

```http
GET /Cust12345/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
accept-language: en
Authorization: Bearer 8A:Cust12345.AGYA...MgA2ADcANQA5AA==
```

> [!NOTE]
> Available only to SuperOffice CRM Online. Not supported for onsite.

<!-- Referenced links -->
[1]: ../tokens/access-token.md

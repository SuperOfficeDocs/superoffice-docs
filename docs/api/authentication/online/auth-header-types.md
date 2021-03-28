---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: auth_headers_types       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: # Authorization header types # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: authentication,soticket,bearer
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Authorization header types

Your application needs to provide one of the following authorization header types when accessing our APIs. Choose either SOTicket or Bearer.

## SOTicket authentication

**Content:** Authorization header with the SuperOffice **SOTICKET** token, and **SO-AppToken** header:

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
[1]: access-token.md

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: submit_rest       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to submit a REST request - non-interactive # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: web services
so.topic: howto        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to submit a REST request - non-interactive

Let's look at how your application can communicate with the SuperOffice web services *after* authenticating and obtaining the system user ticket. You have to establish a secure connection before you start exchanging data.

In contrast to the **interactive** workflow, where the `Authorization` header uses `Bearer [access_token]`, the **non-interactive** workflow requires the `Authorization` header to use `SOTicket` instead of `Bearer`, followed by the ticket value.

The **ApplicationToken** header must also be specified as SO-AppToken with the client secret (application token) value provided when the application was registered.

* **Authorization**: `SOTicket System_User_Ticket_Value`
* **SO-AppToken**: `Application_Token_Value`

## Pre-requisites

* You have a [valid system user ticket][1]

## Request

```csharp
GET /Cust26759/api/v1/MDOList/category?flat=True HTTP/1.1
Host: sod.superoffice.com
accept: application/json
authorization: SOTICKET 7T:MAA3AGYAMQBlAGQAZAAxAGQAZQAwADgAYgAxAGEAYwBkADYAOAA0ADcAMQA2ADkAOQBhADQAZgBiADMAOQAyADsAMgAwADgANwAzADEANQAwADQAMwA7AEMAdQBzAHQAMgA2ADcANQA5AA==
accept-language: en
SO-AppToken: f2398a3a7wer3759d4b220e9a9c94321
```

<!-- Referenced links -->
[1]: ../../../superoffice-docs/docs/authentication/system-user/get-system-user-ticket.md

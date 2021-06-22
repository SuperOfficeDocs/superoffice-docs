---
title: How to submit a REST request - non-interactive
uid: submit_rest
description: How to submit a REST request - non-interactive
author: {github-id}
keywords: web services, rest, webapi
so.topic: howto
so.envir: cloud
so.client: online
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
[1]: ../../authentication/online/auth-application/get-system-user-ticket.md

---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: get_system_user_ticket       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: How to exchange system user token for system user ticket  # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to exchange system user token for system user ticket

You need a system user ticket to perform non-interactive REST API calls. To get the ticket, you periodically invoke the web service endpoint and present your system user token.

The [system user token][1] is embedded in the [SuperIdToken][2] that you received when you [validated][3] the JWT security token from the initial authentication.

**Download Sample**: [Sample Code][4]

**Pre-requisites:**

* [Client secret][5] (application is registered)
* ContextIdentifier (application is [approved by customer's admin][6])
* [System user token][1] (application is authenticated)

## Get system user ticket with SOAP (NodeJS)

SuperOffice CRM Online exposes one WCF SOAP endpoint for conducting the exchange:

```javascript
https://onlineenv.superoffice.com/login/services/PartnerSystemUserService.svc
```

The [SOAP envelope][7] should contain 2 headers plus an `AuthenticationRequest` element in the SOAP body.

1. Read the partner's private PEM file

2. [Sign system user token][8]

3. Send SOAP request to SuperOffice

4. Convert XML response to JSON and obtain the JWT

5. [Validate JWT token][3]

6. Extract the system user ticket

The following example code has an extensive amount of logging to the console. This lets you see the output from each step. The final output is the system user ticket.

### package.json file

[!include[ALT](./includes/package-json.md)]

### index.js code

[!include[ALT](./includes/index-js.md)]

<!-- Referenced links -->
[1]: system-user-token.md
[2]: https://community.superoffice.com/en/developer/create-apps/reference/superidtoken/
[3]: ../certificates/validate-security-tokens.md
[4]: https://community.superoffice.com/contentassets/21dbc96303eb4a69a86279bb59ce1208/system-user-node-sample.zip
[5]: ../apps/client-id-secret.md
[6]: ../tenants/get-consent.md
[7]: https://community.superoffice.com/en/developer/create-apps/reference/soap-envelope/
[8]: sign-system-user-token.md
---
title: get_system_user_ticket
description: How to exchange system user token for system user ticketspaces.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto               # article, howto, reference, concept, guide
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# How to exchange system user token for system user ticket

You need a system user ticket to perform non-interactive REST API calls. To get the ticket, you periodically invoke the web service endpoint and present your system user token.

The [system user token][1] is embedded in the [SuperIdToken][2] that you received when you [validated][3] the JWT security token from the initial authentication.

<a href="../../../assets/downloads/system-user-node-sample.zip" download>Click to download sample</a>

## Pre-requisites

* [Client secret][5] (application is registered)
* ContextIdentifier (application is [approved by customer's admin][6])
* [System user token][1] (application is authenticated)

## Get system user ticket with SOAP (NodeJS)

SuperOffice CRM Online exposes one WCF SOAP endpoint for conducting the exchange:

`https://onlineenv.superoffice.com/login/services/PartnerSystemUserService.svc`

The [SOAP envelope][7] should contain 2 headers plus an `AuthenticationRequest` element in the SOAP body.

1. Read the partner's private PEM file

2. [Sign system user token][8]

3. Send SOAP request to SuperOffice

4. Convert XML response to JSON and obtain the JWT

5. [Validate JWT token][3]

6. Extract the system user ticket

The following example code has an extensive amount of logging to the console. This lets you see the output from each step. The final output is the system user ticket.

### package.json file

[!code-json[example 1](includes/package.json)]
<!-- [!include[ALT](./includes/package-json.md)] -->

### index.js code

[!code-javascript[index.js](includes/index.js)]

<!-- Referenced links -->
[1]: system-user-token.md
[2]: ../superid-token.md
[3]: ../certificates/validate-security-tokens.md
[5]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/client-id-secret.md
[6]: https://github.com/SuperOfficeDocs/superoffice-docs/blob/main/docs/apps/provisioning/get-consent.md
[7]: soap-envelope.md
[8]: sign-system-user-token.md

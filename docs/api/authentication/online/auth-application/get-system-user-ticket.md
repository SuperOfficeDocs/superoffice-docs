---
title: How to exchange system user token for system user ticket
uid: get_system_user_ticket
description: How to exchange a system user token for a system user ticket
author: {github-id}
so.date:
keywords: authentication, soap, system user
so.topic: howto
so.envir: cloud
so.client: online
---

# How to exchange system user token for system user ticket

To get the ticket, you periodically send a request containing a signed version of your system user token to the `partner system user service` endpoint.

The [system user token][1] is on of the claims in the `id_token` received the initial administrative authentication.

## Pre-requisites

* [Client secret][5] (obtained when application is registered)
* ContextIdentifier (tenant identity)
* [System user token][1] (application is authenticated)

There are several ways to obtain a system user ticket:

1. Use one of our nuget packages, or
2. Use our REST API, or
3. Use our SOAP API

We provide the following .NET nuget packages to help perform the task.

### SuperOffice.WebApi (preferred)

* [SuperOffice.WebApi][9] (nuget)
* [Sample Code on GitHub][10]

### SuperOffice.Crm.Online.Core

* [SuperOffice.Crm.Online.Core][11]
* [Sample Code on GitHub][12]

All means to obtain a system user ticket require a signed version of the system user token. Please read the [How to sign a system user token][8] documentation to learn that part of this equation.

## Use the REST API

```json
@signed_Token=YOUR_SIGNED_TOKEN
@client_Secret=YOUR_CLIENT_SECRET
@context_Identifier=YOUR_CUSTOMER_ID

POST https://{environment}.superoffice.com/Login/api/PartnerSystemUser/Authenticate
Content-Type: application/json
Accept: application/json

{
    "SignedSystemToken": "{{signed_Token}}",
    "ApplicationToken": "{{client_secret}}",
    "ContextIdentifier": "{{context_Identifier}}",
    "ReturnTokenType": "JWT"
}
```

## Use the SOAP API (NodeJS)

SuperOffice CRM Online exposes one WCF SOAP endpoint for conducting the exchange:

`https://onlineenv.superoffice.com/login/services/PartnerSystemUserService.svc`

The **SOAP envelope** should contain 2 header elements and the `AuthenticationRequest` element in the SOAP body.

```xml
<?xml version="1.0" encoding="UTF-8"?>
  <SOAP-ENV:Envelope xmlns:ns0="http://schemas.xmlsoap.org/soap/envelope/"
                     xmlns:ns1="http://www.superoffice.com/superid/partnersystemuser/0.1"
                     xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
                     xmlns:tns="http://www.superoffice.com/superid/partnersystemuser/0.1"
                     xmlns:SOAP-ENV="http://schemas.xmlsoap.org/soap/envelope/">
    <SOAP-ENV:Header>
      <tns:ApplicationToken>${appToken}</tns:ApplicationToken>
      <tns:ContextIdentifier>${contextId}</tns:ContextIdentifier>
    </SOAP-ENV:Header>
    <ns0:Body>
      <ns1:AuthenticationRequest>
        <ns1:SignedSystemToken>${signedToken}</ns1:SignedSystemToken>
        <ns1:ReturnTokenType>Jwt</ns1:ReturnTokenType>
      </ns1:AuthenticationRequest>
    </ns0:Body>
  </SOAP-ENV:Envelope>
```

1. Read the partner's private PEM file.

2. [Sign system user token][8].

3. Send SOAP request to SuperOffice.

4. Convert XML response to JSON and obtain the JWT.

5. [Validate JWT token][3].

6. Extract the system user ticket.

The following example code has an extensive amount of logging to the console. This lets you see the output from each step. The final output is the system user ticket.

### package.json file

[!code-json[example 1](includes/package.json)]

### index.js code

[!code-javascript[index.js](includes/index.js)]

<!-- Referenced links -->
[1]: index.md#system-user-tokens
[3]: ../validate-security-tokens.md
[5]: ../../../../../superoffice-docs/docs/apps/terminology.md
[6]: ../../../../../superoffice-docs/docs/apps/provisioning/get-consent.md
[8]: sign-system-user-token.md
[9]: https://www.nuget.org/packages/SuperOffice.WebApi
[10]: https://github.com/SuperOffice/SuperOffice.WebApi-Samples
[11]: https://www.nuget.org/packages/SuperOffice.Crm.Online.Core
[12]: https://github.com/SuperOffice/SuperOffice.DevNet.Online/tree/master/Source/SuperOffice.DevNet.Online.SystemUser.ServiceConsole
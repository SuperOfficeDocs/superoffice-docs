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

You need a system user ticket to perform non-interactive REST API calls. To get the ticket, you periodically invoke the web service endpoint and present your system user token.

The [system user token][1] is embedded in the [SuperIdToken][3] that you received when you [validated][3] the JWT security token from the initial authentication.

## Pre-requisites

* [Client secret][5] (application is registered)
* ContextIdentifier (application is [approved by customer's admin][6])
* [System user token][1] (application is authenticated)

## Get system user ticket with SOAP (NodeJS)

SuperOffice CRM Online exposes one WCF SOAP endpoint for conducting the exchange:

`https://onlineenv.superoffice.com/login/services/PartnerSystemUserService.svc`

The **SOAP envelope** should contain 2 headers plus an `AuthenticationRequest` element in the SOAP body.

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

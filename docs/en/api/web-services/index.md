---
uid: netserver-web-services-overview
title: NetServer web services
description: "The SuperOffice web services are the highest level for working with NetServer."
author: Bergfrid Dias, AnthonyYates
date: 03.28.2022
keywords: API, web services, endpoints, proxy, NetServer, SOAP, REST, Agent, SuperOffice.CRM.Services, DTO, carrier
content_type: concept
deployment: online, onsite
platform: web, win
redirect_from: /en/api/netserver/web-services/index
---

# Web services

When you are calling a web service, you usually **don’t have direct access to the database**.

The objective of the NetServer web services is to provide a simple yet powerful API to access SuperOffice CRM functionality.

The web services let you work with the database without having to know the details of how data is stored inside the database. The service layer presents a high-level API where all the hard work of language decoding, security checks, database selects, and joining tables are handled for you. A single service call will represent many database queries and contain business logic, user-preference checking, and default handling.

All SuperOffice CRM Online applications depend on NetServer web services for database access.

## NetServer web services

[NetServer][3] has many API layers to access SuperOffice data, with web services at the top of the API stack.

Each SuperOffice installation exposes web services for all clients, including SuperOffice Web, SuperOffice Mobile, and partner application clients.

Each web service

![NetServer Architecture][netserver-architecture]

## Endpoints concept

A service endpoint is primarily **a method** exposed by the NetServer to manipulate the data or enhance the presentation of the data in the SuperOffice database.

![SuperOffice.Services vs. web services diagram][img2]

NetServer has many service endpoints to support the entire SuperOffice platform.

![NetServer web services endpoint listing][img1]

### Supported protocols

SuperOffice NetServer supports two distinct web services protocols:

1. REST ([reference][13]), two distinct flavors:
    * RESTful ([reference][8])
    * HTTP RPC Agents ([reference][7])
2. SOAP ([reference][12])

The SOAP APIs use Windows Communication Foundation service models for communication and are considered legacy.

The RESTful APIs use Microsoft AspNet WebApi for communication, and come in two **flavors**:

* RESTful endpoints
* HTTP RPC Agent endpoints

#### RESTful endpoints

`RESTful endpoints` are entity endpoints that:

1. get data using an HTTP **GET** request
2. modify data using HTTP **PUT** or **PATCH**
3. create data using HTTP **POST** and
4. delete data using HTTP **DELETE**.

**Example GET sale request:**

```http
GET https://{superoffice_url}/api/v1/sale/3
Authorization: {type} {credential}
Accept: application/json
```

#### HTTP RPC Agents

`HTTP RPC Agent` endpoints are structured identical to the SOAP endpoints and implement the Service Agent pattern. Unlike SOAP, which uses XML body content to transport messages, HTTP RPC Agents use URL query string parameters and JSON body content.

![Service Agent pattern][service-agent]

Service agents endpoints represent a specific **business area**, such as Appointment, Project or Sale. An **agent** fragment exposes a set of method endpoints, typically for inserting, retrieving, updating, and deleting data. Each method on the agent corresponds to one HTTP **POST** request.

**Example GetAppointmentEntity endpoint method:**

```http
POST https://{superoffice_url}/api/v1/Agents/Appointment/GetAppointmentEntity?appointmentEntityId=4
Authorization: {type} {credential}
Accept: application/json
```

> [!NOTE]
> All HTTP RPC Agent requests are **POST** requests.

## Authentication and Authorization

Every request needs a form of credential to verify ones identity. Credentials are passed to service APIs using headers.

### RESTful headers

You must provide one of the following types of credential.

* BASIC authentication: Base64 Encode SuperOffice username:password
* SOTICKET authentication. Pass the SuperOffice ticket (7T:abc123==) without any encoding.
* BEARER authentication. Pass along an access token (7A:abc123==) from SuperID.
* NEGOTIATE / NTLM authentication. Initiates an Active Directory user authentication.

| Auth type | Example        | Onsite | Online |
|-----------|----------------|:------:|:------:|
| No header |                | x      | x      |
| Basic     | YWrtMdo=       | x      |        |
| SOTicket  | 7T:xyz123abc== | x      | x      |
| Bearer    | 8A:xyz123abc== | x      | x      |
| Negotiate |                | x      |        |

No `Authorize` header on a request means that you either:

* have [IIS configured to handle identity][1] and uses your current Active Directory user, or
* included an **X-XSRF-TOKEN** header to prove that you have access to a logged-in session

> [!NOTE]
> You must explicitly [enable the authentication methods][4] that you want to use in the *web.config* file.

#### Basic

This Authorization header is a key entry of "Basic ", and a value equal to a base64 encoded representation of the user name, plus a colon, and password.

```http
// conceptual:
Authorization: Basic username:password

// actual:
Authorization: Basic dXNlcm5hbWU6cGFzc3dvcmQ=
```

Note the space following the word *Basic*. The `username:password` text must not be passed in clear text and must be base64 encoded. It is shown here as such for demonstration purposes only.

> [!NOTE]
> Basic is not allowed in **Online**, since all usernames and passwords must flow through SuperID to get a bearer access token.

#### Bearer

This Authorization header used in CRM Online is obtained using OAuth 2.0 or OpenID Connect.

```http
Authorization: Bearer 8A:Cust12345.Aaq+TbrrXsV...truncated for brevity
```

Read more about OAuth authorization or OpenID Connect authentication in the [Authentication pages][19].

While not common, it is possible for onsite installations to use a Bearer token. This only happens when an access_token is obtained via the `UserAgent.GetCurrentToken` method.

#### SOTicket

An SOTicket Authorization header credential is used:

* by onsite installation to pass current user credentials to applications hosted in a web panel (forbidden in CRM Onsite due to security reasons)
* by CRM Online and onsite installations performing back-channel communications with a system user.

When a web page is running in the context of a SuperOffice web panel, and web panel is configured to pass the usec template variable, the current user's `SoCredential.Ticket` credential is sent as a query string parameters to the web application. In that case, the application can use the Authentication header value "SOTicket " plus the ticket string to request additional API data. Once again, notice the space following *SOTicket*.

[!include[Usec Forbidden Online](../../includes/usec-forbidden-online.md)]

**When used in online**, the `SOTicket` header must accompany with the `SO-AppToken` header, and the `SO-AppToken` value must be the application secret (OAuth client_secret).

```http
Authorization: SoTicket 7A:adasd098098sdfs0df8KJHSKh230...123dsa==
SO-AppToken: qw123f4c56770bc278017796cd16bd11
```

> [!NOTE]
> In this case, do not convert a Ticket to base64 because the **ticket value is already base64 encoded**.

#### X-XSRF-TOKEN

When [requests][1] are received without an **Authorization** header, the API will try authorize the current user's SuperOffice session.

SuperOffice pages contain a hidden INPUT field `XSRF_TOKEN`, which contains a random value identifying the current session. You must add an X-XSRF-TOKEN header with the random value from the input field.

To avoid 3rd-party pages calling the API - piggy-backing off the current session, the API requires that a special HTTP header `X-XSRF-TOKEN` is added to each requests.

The XSRF-TOKEN is also stored in a cookie for convenience. HTTP libraries like AXIOS will automatically pick up the XSRF-TOKEN cookie from the browser and add the X-XSRF-TOKEN header to your HTTP requests.

The following snippet will return HTTP error 401 Unauthorized.

```http
GET /api/v1/Contact/2
Accept: application/json
```

Whereas the following snippet will work, and use the current user's session to read the data.

```http
GET /api/v1/Contact/2
Accept: application/json
X-XSRF-TOKEN: abc1234
```

### SOAP headers

Each service method the [SOAP documentation][12] contains the following two headers:

* ApplicationToken
* Credentials

The application token is only used in CRM Online, and is reserved for application identifiers, an OAuth `client_secret` value.

The Credentials element must always be populated with the current users `Ticket` credential. This is set automatically when using the SuperOffice.NetServer.Services nuget package, but are manually set by custom proxies.

```xml
<ApplicationToken>1234567-1234-9876</ApplicationToken>
<Credentials>
  <Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
</Credentials>
```

### REST web service resources

1. Read more about: [RESTful API][15]
2. Read more about: [Agent API][14]

Here you can find OpenAPI / Swagger files for available for download for each REST flavor. They are also available for download at the bottom of each page link above, respectively.

* [Download RESTful API file][17]
* [Download Agent API file][18]

#### Nuget package

There is one nuget package for .NET developers. This package exposes the same Agent API as the SOAP proxy, making it an easy transition for applications using the [SOAP proxy][6]:

[SuperOffice.WebApi (HTTP RPC Agent)][11]

* [reference][9])

### SOAP web service resources

WSDL files for all versioned endpoints are [available for download][12] in the reference section, or as individual files on each endpoint reference page.

**Download All:**

![Download all WSDLs][wsdl-all]

**Download Single:**

![Download all WSDLs][wsdl-single]

Read more about: [SOAP Services][2].

#### Nuget package

There is one nuget package for .NET developers:

[SuperOffice.NetServer.Services (SOAP)][6]

* View [API reference][16].

## Restricted agents

Not all agents are available in SuperOffice CRM Online. Access must be requested specifically when an app is registered.

| Agent Name       | Availability               |
|------------------|----------------------------|
| CRMScriptAgent   | available upon request     |
| EMailAgent       | restricted                 |
| ErpSyncAgent     | available with ERPSync connectors|
| MessagingAgent   | restricted                 |
| ReplicationAgent | restricted                 |
| UserAgent        | restricted                 |
| WebhookAgent     | available upon request     |

## Required web service license

Access to the web services is included in your [Development Tools][4] subscription.

<!-- Referenced links -->
[1]: ../entities/index.md
[2]: endpoints/soap/index.md
[3]: ../overview/netserver.md
[4]: ../../api/config/webapi.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: ../reference/restful/rest/index.md
[8]: ../reference/restful/agent/index.md
[9]: ../reference/webapi/index.md
[11]: https://www.nuget.org/packages/SuperOffice.WebApi
[12]: ../reference/soap/index.md
[13]: ../reference/restful/index.md
[14]: endpoints/agents-webapi/index.md
[15]: endpoints/rest-webapi/index.md
[16]: ../reference/netserver/services/index.md
[17]: ../../../assets/downloads/api/Swagger-v1-REST.zip
[18]: ../../../assets/downloads/api/Swagger-v1-Agents.zip
[19]: ../authentication/online/index.md

<!-- Referenced images -->
[img1]: media/netserver-web-services.png
[img2]: media/sm-serviceinterfaces.png
[netserver-architecture]: media/netserver-architecture.png
[wsdl-all]: media/download-all-wsdls.png
[wsdl-single]: media/download-single-wsdls.png
[service-agent]: media/netserver-servce-agent.png

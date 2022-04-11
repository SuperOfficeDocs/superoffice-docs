---
uid: netserver-web-services-overview
title: NetServer web services
description: "The SuperOffice web services are the highest level for working with NetServer."
author: Bergfrid Dias, AnthonyYates
so.date: 03.28.2022
keywords: API, web services, endpoints, proxy, NetServer, SOAP, REST, Agent, SuperOffice.CRM.Services, DTO, carrier
so.topic: concept
so.envir: cloud, onsite
so.client: win, web
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

1. REST ([reference][13])
   * Two distinct flavors:
     * 1. RESTful ([reference][8])
     * 2. Agent ([reference][7])
2. SOAP ([reference][12])

The SOAP APIs, not considered legacy, use Windows Communication Foundation service models for communication.

The RESTful APIs use Microsoft AspNet WebApi services for communication, and come in two _flavors_:

* RESTful endpoints
* RESTful Agent endpoints

#### RESTful endpoints

`RESTful endpoints` are entity endpoints that are retrieved using HTTP **GET**, modified using HTTP **PUT** or **PATCH**, created using HTTP **POST** and deleted using HTTP **DELETE**.

```http
GET https://{superoffice_url}/api/v1/sale/3
Authorization: {type} {credential}
Accept: application/json
```

#### RESTful Agents

`RESTful Agent` endpoints are identical to the SOAP endpoints and implement the Service Agent pattern.

![Service Agent pattern][service-agent]

Service agents represent a specific **business area**, such as Appointment, Project or Sale. An **agent** exposes a set of methods, typically for inserting, retrieving, updating, and deleting data. Each method on the agent corresponds to one HTTP **POST** request.

```http
POST https://{superoffice_url}/api/v1/Agents/Appointment/GetAppointmentEntity?appointmentEntityId=4
Authorization: {type} {credential}
Accept: application/json
```

> [!NOTE]
> All RESTful Agent requests are **POST** requests.

## Authentication and Authorization

Each request needs credentials to verify your identity. Credentials are passed to service APIs using headers.

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
* you send an **X-XSRF-TOKEN** header to prove that you have access to a logged-in session

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

**When used in online**, the `SO-AppToken` header must accompany the SoTicket header, and the value must be the application secret (OAuth client_secret).

```http
Authorization: SoTicket 7A:adasd098098sdfs0df8KJHSKh230...123dsa==
SO-AppToken: qw123f4c56770bc278017796cd16bd11
```

> [!NOTE]
> In this case, do not use the `window.btos(...)` method to convert a Ticket to base64 because the **ticket value is already base64 encoded**.

#### X-XSRF-TOKEN

With [requests][1] without an **Authorization** header, the API will try to log in using the current user's SuperOffice session. To avoid 3rd-party pages calling the API and piggy-backing off the current session, the API requires that a special HTTP header is added to these requests.

The SuperOffice pages contain an INPUT field `XSRF_TOKEN`. This field contains a random value identifying the current session. You must add an X-XSRF-TOKEN header with the random value from the input field.

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

### SOAP headers

Each service method the [SOAP documentation][12] contains the following two headers:

* ApplicationToken
* Credentials

The application token is used exclusively in the CRM Online environment, and is reserved for application identifiers, an OAuth `client_secret` value. 

The Credentials element must always be populated with the current users `Ticket` credential. This is set automatically when using the SuperOffice.NetServer.Services nuget package, but are manually set by custom proxies.

```xml
<ApplicationToken>1234567-1234-9876</ApplicationToken>
<Credentials>
  <Ticket>7T:1234abcxyzExample==</Appointment:Ticket>
</Credentials>
```

### REST web service resources

NetServer REST web services come in two _flavors_, Agent REST and [common] REST and are distinct in use. 

The primary difference is that, unlike most common REST APIs that use GET, PUT, POST, DELETE and PATCH methods, Agent endpoints are all POST requests. Agent endpoints are also named and used just like their SOAP web service endpoint counterparts, i.e. naming conventions similar to classes and methods.

1. Read more about: [RESTful API][15]
2. Read more about: [Agent API][14]

Here you can find OpenAPI / Swagger files for available for download for each REST flavor. They are also available for download at the bottom of each page link above, respectively.

* [Download RESTful API file][17]
* [Download Agent API file][18]

#### Nuget package

There is one nuget package for .NET developers. For it's initial release, this package exposes the same Agent API as the SOAP proxy, making it an easy transition for vendors currently using the [SOAP proxy][]:

[SuperOffice.WebApi (RESTful Agent)][11]

* [reference][9])

### SOAP web service resources

NetServer SOAP web services implement the Service Agent pattern, exposing areas of SuperOffice as endpoints, i.e. Appointment and Project, and each endpoint has a list of methods that when invoked facilitate data transfer of Data Transfer Objects (DTOs). SuperOffice calls DTOs `Carriers`.

WSDL files for all versioned endpoints are [available for download][12] in the reference section, or as individual files on each endpoint reference page.

**Download All**
![Download all WSDLs][wsdl-all]

**Download Single**
![Download all WSDLs][wsdl-single]

Read more about: [SOAP Services][2].

#### Nuget package

There is one nuget package for .NET developers:

[SuperOffice.NetServer.Services (SOAP)][6]

* View [API reference][16].

## Restricted agents

Not all agents are available in SuperOffice CRM Online. Access must be requested specifically when an app is registered.

| Agent Name | Availability                     |
|-----------------------------------------|-----|
| CRMScriptAgent   | available upon request     |
| EMailAgent       | restricted                 |
| ErpSyncAgent     | available with ERPSync connectors|
| MessagingAgent   | restricted                 |
| ReplicationAgent | restricted                 |
| UserAgent        | restricted                 |
| WebhookAgent     | available upon request     |

## Required web service license

Access to the web services is included in your [Developer Tools][4] subscription.


<!-- Referenced links -->
[1]: ../entities/index.md
[2]: endpoints/soap/index.md
[3]: ../overview/netserver.md
[4]: ../../api/config/webapi.md
[5]: proxies/index.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: ../reference/restful/rest/index.md
[8]: ../reference/restful/agent/index.md
[9]: ../reference/webapi/index.md
[10]: ../rows/index.md
[11]: https://www.nuget.org/packages/SuperOffice.WebApi
[12]: ../reference/soap/index.md
[13]: ../reference/restful/index.md
[14]: endpoints/agents-webapi/index.md
[15]: endpoints/rest-webapi/index.md
[16]: ../reference/netserver/services/index.md
[17]: ../../assets/downloads/api/Swagger-v1-REST.zip
[18]: ../../assets/downloads/api/Swagger-v1-Agents.zip
[19]: ../authentication/online/index.md

<!-- Referenced images -->
[img1]: media/netserver-web-services.png
[img2]: media/sm-serviceinterfaces.png
[netserver-architecture]: media/netserver-architecture.png
[wsdl-all]: media/download-all-wsdls.png
[wsdl-single]: media/download-single-wsdls.png
[service-agent]: media/netserver-servce-agent.png
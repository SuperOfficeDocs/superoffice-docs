---
title: System user
uid: webapi-and-system-user
description: System user
author: Anthony Yates
so.date: 11.24.2021
keywords: API, web services, proxy, WebAPI, REST, system user, authentication, PartnerSystemUserService, Ticket, SystemUserClient, SuperOffice.WebApi.IdentityModel
so.topic: concept
---

# How to use System User flow

The WebAPI client library supports the System User flow. The client makes it very easy to call the online **PartnerSystemUserService endpoint**, validate the JWT and return the claims it contains.

The JWT contains a lot of information, however, it's usually just the Ticket credential that is interesting. Therefore, **SuperOffice.WebApi** simplifies calling the service, validating the response, and then returning the ticket in a single method call.

> [!WARNING]
> Do **not** ask for a System User Ticket every single time you invoke an Agent method! This is a performance penalty. **Take advantage of the 6-hour window** and only ask for a new Ticket when absolutely necessary!

## SystemUserClient

Use the `SystemUserClient` class, located in the `SuperOffice.WebApi.IdentityModel` namespace.

The constructor accepts a `SystemUserInfo` instance and contains all of the information required to submit a request to the *partnersystemuserservice.svc* endpoint.

## SystemUserInfo properties

| Property | Description |
|---|---|
| Environment | The online environment (SOD, Stage, Production. |
| ContextIdentifier | The tenant, or customer, identity. |
| ClientSecret | The application secret, a.k.a. client_secret. |
| PrivateKey | The applications RSAXML private certificate value. |
| SystemUserToken | The SystemUser token, issued during app approval. |

## Generate and send request

Given the required information, the `SystemUserClient` can generate and send a request to the service, then receive and validate the response.

```csharp
var sysUserClient = new SystemUserClient(systemUserInfo);
var sysUserJwt = await sysUserClient.GetSystemUserJwtAsync();
var sysUserTkt = await sysUserClient.GetSystemUserTicketAsync();
```

The **GetSystemUserJwtAsync** only returns the JWT, wrapped in a `SystemUserResult`. It does not validate or extract any claims.

The **GetSystemUserTicketAsync**, validates the returned JWT, populates the `SystemUserClient.ClaimsIdentity` property, and returns the SOTicket credential.

## JWT validation

`GetSystemUserTicketAsync` is what consumers will use 99.9 percent of the time, but if there is a desire to skip the convenience, there are two alternatives for performing JWT validation.

**Alternative 1:**

Use the `ValidateSystemUserResult` method, and get back a `TokenValidationResult`.

This method also populates the `SystemUserClient.ClaimsIdentity` property. This method is used by `GetSystemUserTicketAsync`.

```csharp
var tokenValidationResult = await sysUserClientValidateSystemUserResultAsync(systemUserResult);
```

**Alternative 2:**

Manually perform validation and extract claims, the `SystemUserClient` uses the `JwtTokenHandler`, located in the `SuperOffice.WebApi.IdentityModel` namespace.

```C#
var handler = new SystemUserTokenHandler(
    new System.Net.Http.HttpClient(), // HttpClient instance.
    OnlineEnvironment.SOD             // target online environment (SOD, Stage, or Production)
    );

var tokenValidationResult = await handler.ValidateAsync(sysUserJwt.Token);
```

The `SystemUserTokenHandler.ValidateAsync` method returns a `TokenValidationResult`, a Microsoft datatype located in the [Microsoft.IdentityModel.JsonWebTokens][1] namespace, in the `Microsoft.IdentityModel.JsonWebTokens` assembly.

<!-- Referenced links -->
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.identitymodel.tokens.tokenvalidationresult

---
title: IAuthorization
uid: iauthorization-intro
description: IAuthorization
author: Anthony Yates
so.date: 11.24.2021
keywords: API, web services, proxy, WebAPI, REST, IAuthorization, credentials, AuthorizationSystemUserTicket, AuthorizationAccessToken, AuthorizationUserToken, jwks_uri
so.topic: concept
---

# About IAuthorization

There are cases where a user's credentials will expire. It's probably easiest to say that the only case where credentials will not expire at runtime is using `AuthorizationUsernamePassword`. All other `IAuthorization` implementations contain **time-sensitive credentials**.

## Built-in implementations

There are 4 built-in `IAuthorization` implementations.

| Authorization type | Used in Online | Used in Onsite |
|---|:-:|:-:|
| AuthorizationAccessToken | X |  |
| AuthorizationSystemUserTicket | X | |
| AuthorizationTicket | | X |
| AuthorizationUsernamePassword | | X |
| AuthorizationUserToken | | X |

## Auto-refresh

The SuperOffice WebApi library has limited built-in support to automatically refresh credentials.

Both `AuthorizationTicket` and `AuthorizationSystemUserTicket` credentials expire after 6 hours, but only `AuthorizationSystemUserTicket` implements automatic refresh support.

To auto-refresh `AuthorizationSystemUserTicket` requires the following information:

* Environment
* ContextIdentifier
* ClientSecret
* PrivateKey
* SystemUserToken

To auto-refresh `AuthorizationAccessToken` requires the following information:

* Access Token
* Refresh Token
* Redirect URI

To auto-refresh `AuthorizationUserToken` requires the following information:

* Username
* Password

The system user flow is discussed more in the [System User][1] section.

## When is IAuthorization refreshed

This library takes a **reactive approach** and waits to receive an access denied response before attempting to refresh the Authorization.

When an **access denied** response is received, the client looks to make sure the WebApiOptions has an `IAuthorization.RefreshAuthorization` implementation. When present and the `RefreshAuthorization` implementation succeeds, `RefreshAuthorization` returns an updated `IAuthorization`.

With an updated Authorization, the client then invokes the `IAuthorization.GetAuthorization` method to get a two-value tuple, the scheme and the parameter, and uses those to set the Authorization header.

`("Bearer", "8A:Cust12345:ABCdefg....XyZ")`

Finally, the client retries that original request with an updated scheme and parameter.

## Certificate validation

Both `AuthorizationAccessToken` and `AuthorizationSystemUserTicket` validate the response from SuperOffice using the **SuperOffice public key**. The client does this by requesting the OAuth 2.0 metadata document from the online environment. This process takes two requests:

1. The first request is sent to obtain the **OAuth 2.0 metadata document**, and then extracts the `jwks_uri`.

2. The second request is sent to the `jwks_uri` to obtain the certificate details.

The benefit of this process is that the integration does not need to include any physical public certificates.

## Custom IAuthorization implementation

If for some unknown reason you want to populate the Authorization header with a different scheme/parameter values, you can implement your own `IAuthorization`. The interface is simple.

```csharp
public interface IAuthorization
{
  Func<ReAuthorizationArgs, IAuthorization> RefreshAuthorization { get; set; }
  (string scheme, string parameter) GetAuthorization();
}
```

**RefreshAuthorization** is a function that accepts a `ReAuthorizationArgs` and returns an `IAuthorization` instance with updated credential values.

The client updates the `WebApiOptions` and then calls the **GetAuthorization** method. `GetAuthorization` returns the scheme and parameter, which the client then uses to populate the request Authorization header.

<!-- Referenced links -->
[1]: systemuserclient.md

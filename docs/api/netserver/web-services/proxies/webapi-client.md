---
title: How to use SuperOffice.WebApi
uid: using_webapi_client
description: How to use SuperOffice.WebApi
author: Bergfrid Dias
so.date: 11.24.2021
keywords: API, web services, proxy, WebAPI, SuperOffice.WebApi, WebApiOptions, RequestOptions, IAuthorization, async await
so.topic: howto
---

# How to use SuperOffice.WebApi

In just a few simple steps you can get ready to work with the web service agents:

1. [Obtain OAuth tokens][3].
2. Instantiate a `WebApiOptions` object.
3. Define the [IAuthorization credential type][1].
4. Create the desired Agent class, passing in the `WebApiOptions` as a constructor parameter.

## Instantiate a WebApiOptions object

`WebApiOptions(string baseUrl);`

The primary constructor accepts the target WebApi URL, `https://sod.superoffice.com/cust12345/api`, which is available as a claim in the ID token and system user token.

`WebApiOptions` inherits from **RequestOptions**, which contain the internationalization settings. These settings can also be passed into the overloaded constructor.

```csharp
WebApiOptions(
  string baseUrl,
  IAuthorization authorization,
  string languageCode = null,
  string timeZone = null,
  bool verifyUrl = true
);
```

## Define the IAuthorization credential type

The [IAuthorization][1] parameter is used to define the credential type and to set the Authorization attribute in each HTTP request.

Assign an instance to the `WebApiOptions.Authorization` property.

**Alternative 1:**

```csharp
var auth = new AuthorizationUsernamePassword("jack@black.com", "TenaciousD!");
var config = new WebApiOptions(tenant.WebApiUrl, auth);
```

**Alternative 2:**

```csharp
var config = new WebApiOptions(tenant.WebApiUrl);
config.Authorization = new AuthorizationUsernamePassword("jack@black.com""TenaciousD!");
```

## Create and use the desired Agent

To create an Agent object, pass in the `WebApiOptions` as a constructor parameter.

```csharp
var contactAgent = new ContactAgent(config);
```

> [!NOTE]
> This is the only Agent difference when compared to using the existing [WCF SOAP proxies][2].

Now your code can make the same calls as before. The biggest change is that they are now **asynchronous** and can use the **async-await** pattern!

```csharp
public async Task<ContactEntity> GetContactEntity(contactId)
{
  return await contactAgent.GetContactEntityAsync(contactId);
}
```

<!-- Referenced links -->
[1]: ../../../authentication/webapi/iauthorization.md
[2]: built-in.md
[3]: https://www.nuget.org/packages/AspNet.Security.OAuth.SuperOffice/

---
title: Proxies
uid: ws_proxies
description: Proxies
author: Bergfrid Dias
so.date: 12.02.2021
keywords: API, web services, proxy, WebAPI, SOAP, WebApiOptions
so.topic: concept
---

# Proxies

## WebApi client library

[!include[ALT](../../../includes/webapi-client-intro.md)]

This library makes it easier to work in a **multi-tenant** environment. It isolates a tenant's context in a **WebApiOptions** instance, where each instance is configured to target one specific tenant. Each instance can be configured with its own language, culture, and timezone settings.

This library also has built-in **system user token** support.

### Howto

* [How to use SuperOffice.WebApi][5]
* [How to authenticate][4]
* [How to use the system user flow][7]

## SOAP

If your services are configured to use SOAP, each method call is a SOAP envelope that will travel over the network. SOAP calls can be made by your preferred client, such as .NET.

There is flexibility in using SuperOffice **proxies**.

**Options:**

* Use NetServer proxies ([NuGet packages][6])
* Generate a [custom proxy][3] by adding a web service

### NetServer proxies

The most complete way is to reference the NuGet packages. You can either:

* [Call in local mode][1]
* [Call in remote mode][2]

### Custom proxies

When necessary, use a tool to generate a client proxy class for a particular NetServer web service, for example, *Appointment.svc* or *Contact.svc*.

<!-- Referenced links -->
[1]: built-in.md#locally
[2]: built-in.md#remotely
[3]: custom.md
[4]: ../../../authentication/webapi/iauthorization.md
[5]: webapi-client.md
[6]: https://www.nuget.org/packages/SuperOffice.NetServer.Services
[7]: ../../../authentication/webapi/systemuserclient.md

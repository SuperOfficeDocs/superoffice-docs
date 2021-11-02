---
title: Application environment
uid: app_envir
description: About application environments
author: {github-id}
keywords: sod,stage
so.topic: concept
so.envir: cloud
so.client: online
---

# Application environments

SuperOffice CRM Online is a cloud platform serving thousands of customers. Like any serious distributed and federated platform service, it requires several phases for development, testing, and production.

SuperOffice provides 3 environments: development, stage, and production.

![x -screenshot][img1]

All [standard applications][1] must be prepared to operate in at least 2 environments before being [listed in the public App Store][2].

## SuperOffice Online Development (SOD)

SOD is where research and development happens. It is our **sandbox environment** that allows you to explore, experiment with, and play with our APIs. This is where all SuperOffice applications are born and evolve until they are ready for either [validation][3] or [certification][4].

## Stage

In stage, an application must prove it can withstand a high degree of traffic without impacting the server, the main website, and other applications that are running on the same server. This is where all SuperOffice applications go through certification and security evaluation.

## Production

This is the public space where SuperOffice CRM Online and all [deployed applications][5] reside. That means both standard applications published to the App Store and custom applications activated on a customer's [tenant][10].

### Maintenance window

Our production environment has some windows where we may upgrade and maintain our system. At these times you might not get access to the tenant and you should handle these so no data is lost. Make sure to [check the tenant status][13].

* Every night between 01.00 (UTC+1) and 03.00 (UTC+1) we recycle the application pools for all customers.

* The maintenance window is **Saturday between 20.00 (UTC+1) and Sunday 06.00 (UTC+1)**.

* The patch window is **Thursdays between 22.00 (UTC+1) and Friday 06.00 (UTC+1)** and at this time the servers may reboot.

We upgrade our customers on Tuesdays and Fridays every third week. Info regarding this will be given on the login page only. The window here is from 20.00 (UTC+1) and may last until 05:00 (UTC+1).

> [!TIP]
> Sign up for updates at [status.superoffice.com][6].

## Why different environments?

It's quite simple: **security**. SuperOffice takes security very seriously, while at the same time makes it easy for applications to transition from one environment to the next when ready.

The separation also prevents applications still in development from accidentally being used in stage and production environments.

## What's in each environment?

The development and stage environments are essentially isolated copies of production. Each environment has its own distinct components:

* Operation Center (OC)
* [App Store][7]
* Partner [applications][8]
* [SuperID][9] (URL to the SuperOffice federated authentication provider)
* SuperOffice Certificate ID (certificate thumbprint identifier)
* Customer tenants

You will most likely be connecting to the free test tenant in SOD when you develop your application.

In the SOD tenant, you get a new blank database. However, if you plan to create customizations based on a customer's settings such as list items and user-defined fields, you probably need access to [production data][12].

> [!NOTE]
> For security reasons, we don't want production data in the SOD environment.

## Environment dependencies

For each application and within each environment, you must define the following 5 environment-specific dependencies:

* [client ID][10]
* client secret (token)
* [certificates][11]
* SoFederation Gateway (SuperId)
* SuperOffice Certificate ID

![x -screenshot][img2]

<a href="../../../../data-access/docs/assets/downloads/superofficeonlinecertificates.zip" download>Click to download the SuperOffice certificates (ZIP file)</a>.

## Base URL

The base URL for any tenant is different in each environment. Given a tenant context identifier of Cust12345, the base URL is as follows:

* Development `https://sod.superoffice.com/Cust12345`
* Stage `https://qaonline.superoffice.com/Cust12345`
* Production `https://online.superoffice.com/Cust12345`

Use of the REST web services to get the company where id is equal to 3 in the development environment, assuming accessing version v1, would appear as:

`https://sod.superoffice.com/Cust12345/api/v1/contact/3/`

Use of the SOAP web services to get the company where id is equal to 3 in the development environment, assuming accessing version 87, would appear as:

`https://sod.superoffice.com/Cust12345/remote/services87/contact.svc (SOAP Action: GetContactEntity)`

Both the REST and SOAP `base URL` endpoints are included as **claims** in the OpenID Connect `id_token`.

<!-- Referenced links -->
[1]: ../standard.md
[2]: ../publish/get-listed.md
[3]: ../activate/index.md
[4]: ../certification/index.md
[5]: index.md
[6]: https://status.superoffice.com/
[7]: ../app-store.md
[8]: ../overview.md
[9]: ../../identity-management/federated-auth.md
[10]: ../terminology.md
[11]: ../../../../data-access/docs/authentication/online/certificates/index.md
[12]: ../../online/test-environment/index.md
[13]: ../tenant-status/index.md

<!-- Referenced images -->
[img1]: media/online-environments-sidebyside-650.png
[img2]: media/online-environments-settings-sidebyside2-650.png

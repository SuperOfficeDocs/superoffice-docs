---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: app_envir       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: About application environments # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: sod,stage
so.topic: concept         # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# Application environments

SuperOffice CRM Online is a cloud platform serving thousands of customers. Like any serious distributed and federated platform service, it requires several phases for development, testing, and production.

SuperOffice provides 3 environments: development, stage, and production.

![x][img1]

All [standard applications][1] must be prepared to operate in at least 2 environments before being [listed in the public App Store][2].

## SuperOffice Online Development (SOD)

SOD is where research and development happens. It is our **sandbox environment** that allows you to explore, experiment with, and play with our APIs. This is where all SuperOffice applications are born and evolve until they are ready for either [validation][3] or [certification][4].

## Stage

In stage, an application must prove it can withstand a high degree of traffic without impacting the server, the main website, and other applications that are running on the same server. This is where all SuperOffice applications go through certification and security evaluation.

## Production

This is the public space where SuperOffice CRM Online and all [deployed applications][5] reside. That means both standard applications published to the App Store and custom applications activated on a customer's [tenant][6].

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

## Environment dependencies

For each application and within each environment, you must define the following 5 environment-specific dependencies:

* [client ID][10]
* client secret (token)
* [certificates][11]
* SoFederation Gateway (SuperId)
* SuperOffice Certificate ID

![x][img2]

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
[3]: ../validation/index.md
[4]: ../certification/index.md
[5]: overview.md
[6]: ../tenant-status/index.md
[7]: ../app-store.md
[8]: ../index.md
[9]: ../../authentication/federated-auth.md
[10]: ../client-id-secret.md
[11]: ../../authentication/certificates/index.md

<!-- Referenced images -->
[img1]: media/online-environments-sidebyside-650.png
[img2]: media/online-environments-settings-sidebyside2-650.png
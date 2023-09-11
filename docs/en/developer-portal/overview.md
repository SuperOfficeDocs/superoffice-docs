---
title: Applications
uid: apps
description: About SuperOffice CRM Online applications
author: Bergfrid Dias
so.date: 09.11.2023
keywords: app, application, extensibility, integration point
so.topic: concept
so.envir: cloud
so.client: online
---

# About SuperOffice CRM Online apps

SuperOffice CRM Online has great extensibility points that allow vendors to create complimentary applications in and around SuperOffice.

While a great standalone CRM solution, SuperOffice becomes better with complimentary applications.

## What are applications?

[!include[Application defined](includes/def-app.md)]

The key to any integration is that the application is relevant and adds value to customers in their sales, marketing, customer service, and/or business processes.

You can think of an application as a link to another cloud service. The link allows the other service to retrieve, present, or add data to SuperOffice.

If you use the APIs, which you will have to use to communicate with the database, it is an application!

All SuperOffice CRM Online applications get a [unique ID][1] to identify each integration within our environment.

## SuperOffice CRM Online web client at a glance

* An online platform serving thousands of customers
* Distributed and federated platform service
* Client-side JavaScript
* CRM integrations limited to web panels and database access
* Customer Service integrations can be almost everything you want

## Ways your application can extend SuperOffice

Applications can be or do the following:

* An add-on module
  * SuperOffice Web Tools
  * Calendar synchronization
* A configuration
  * Industry-specific categorization
  * Document templates
  * Email templates
* Synchronize data between SuperOffice and an ERP system
* Trigger workflows between systems
* One-way data update (address, financial and similar) between SuperOffice and external data providers

The extensibility points are platform-independent.

Anything a consultant can do inside the SuperOffice Admin application, any application can programmatically do during or after [provisioning][3]:

* Custom lists and list items
* User-defined fields
* Web panels
* Custom buttons
* Sales guide, project guide
* Preferences
* Re-skinned to customer's brand

Applications are either developed by SuperOffice or one of our partners. The creator of the application is responsible for [hosting][2] it. SuperOffice will not bill, [provision][3], or host partner applications. Instead, the App Store redirects to our partner’s websites where customers buy directly from the partner.

### Integration services

Standard and custom applications can incorporate the following external-facing integrations:

* [Database Mirroring][6]
* [ERP Sync Connector][7]
* [Quote Connector][8]

These integration types are referred to as Integration Services.

## Application models

How customers will interact with applications, tightly linked to [user contexts][9]. Each application falls into one of the following categories:

* Internal application
* External application
* Hybrid application

### Internal application model

Internal applications have tight integration with user interface components inside SuperOffice CRM Online. Applications that add a navigator button, a menu button, or a web panel commonly follow this model.

### External application model

External applications are hidden integrations where most or all interaction happens at the partner's website or cloud. This model includes:

* Any application that has no user interface presence inside SuperOffice
* Applications that require the user to navigate to a partner website to use the application or service

### Hybrid application model

Hybrid applications can, as the name suggests, have some UI components inside SuperOffice CRM Online and can operate or be configured on a partner web portal. The majority of applications are hybrids.

## Standard and custom applications

Applications are either [built to fit many][4] and available in the SuperOffice App Store or [one-off customization][5] for your company or a customer's company only.

## Developer Portal

The [new self-service portal for developers and application partners][10] replaces the manual forms and lets you handle more of the configuration yourself.

<!-- Referenced links -->
[1]: getting-started/index.md#client-id
[2]: getting-started/hosting.md
[3]: provisioning/index.md
[4]: standard-app/index.md
[5]: custom-app/index.md
[6]: ../mirroring/overview.md
[7]: ../api/plugins/erp-connectors/index.md
[8]: ../api/plugins/quote-connectors/index.md
[9]: getting-started/user-contexts.md
[10]: https://dev.superoffice.com/

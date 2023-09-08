---
title: Applications
uid: apps
description: About SuperOffice CRM Online applications
author: {github-id}
so.date: 11.10.2021
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

## Standard and custom applications

Applications are either [built to fit many][4] and available in the SuperOffice App Store or [one-off customization][5] for your company or a customer's company only.

## Developer Portal

We're proud to release a [new self-service portal for developers and application partners][10] this year. It replaces the manual forms and let you handle more of the configuration yourself.

To get started, check out our brand new [Developer Portal documentation][9].

<!-- Referenced links -->
[1]: terminology.md
[2]: getting-started/hosting.md
[3]: provisioning/index.md
[4]: standard-app/index.md
[5]: custom-app/index.md
[6]: ../mirroring/overview.md
[7]: ../api/plugins/erp-connectors/index.md
[8]: ../api/plugins/quote-connectors/index.md
[9]: index.yml
[10]: https://dev.superoffice.com/

---
title: Introduction
uid: mirroring_intro
description: Database Mirroring Service for SuperOffice CRM Online
author: {github-id}
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---


# Database mirroring

Database mirroring is an API feature that applications can use for local processing when **real-time data is not the most important consideration**. It's not a standalone product.

Mirroring a customer's database gives partners a tremendous amount of flexibility to perform deep analysis on customer data - all without having to rely on web services subjected to latency or throughput issues.

Using NetServer web services, online applications have virtually unlimited access to customer databases for reading and writing data. However, when intensive or extensive data processing is needed, it's always best to have a local copy of a database.

> [!CAUTION]
> Database mirroring is **NOT** for customers who don't have the competence to set it up and maintain it themselves.

Imagine you are an online application vendor who has created the world's best trending software. You have created an application that can scan a database, mine it for patterns, and display trend reports. It would be nearly impossible to do this effectively with only web services.

![trendsyapp -screenshot][img1]

## Primary components

![trendsy -screenshot][img2]

### Registered application

We keep a record of the applications you register in our Operations Center. This information includes your [client ID and client secret][5] (token) and whether mirroring has been activated.

When we activate mirroring, we also store the mirroring URL, which is where the Mirroring Task will send the data.

### Mirroring task

The [Mirroring task][2] is a background process in our Operation Center that transfers data from a [tenant database][5] to a partner's registered [application][8]. It is responsible for provisioning the change tracking in the customer database and it is managed by SuperOffice.

### A web service implementing IMirrorClientService and IMirrorAdmin

You must create and host the web service that receives the data. This web service must implement the [IMirroringClient interface][1]. The service interface is responsible for establishing a trusted connection, receiving the data, and performing the actual mirroring, such as provisioning of tables and performing schema updates.

## Database management system

Microsoft SQL Server is currently the only option for SuperOffice CRM Online and our implementation of `IMirrorClientService` in the NuGet package.

The NuGet mirroring API uses SQL syntax, SQL Server dialect, for database column data types.

This avoids the need to create a NetServer instance for database independence and reduces the complexity of the overall system. It also reduces storage requirements and processing load, by using the schema and change-tracking mechanisms built into so  SQL Server.

## Is the mirror database an exact copy?

You don't get an exact copy of a tenant database, but a subset that contains more than enough data for what the application needs for offline processing.

Primary key, data type, NULL / NOT NULL, and default value are mirrored, and of course the table and column names. [Read more about the schema][3].

We remove data that is irrelevant, that would incur unnecessary stress between systems, and which would not make sense to replicate:

* Window positions
* DBI agent information
* Search criteria information and operators
* Area and travel tables
* User credentials
* Sensitive information

A complete list of tables both replicated and not replicated with reason is listed in the [blocked tables list][4]..

You will not be able to connect to the mirror database using any SuperOffice client or API!

## When should I consider database mirroring?

* Reporting
* Pattern recognition
* Trend processing

## How do I use database mirroring?

Database mirroring is an **option** that can be activated or deactivated for any online application. It is **not** a standalone, off-the-shelf application.

You must first register a [custom application][8] and then build the feature in your environment. The NuGet package provided by SuperOffice includes methods to facilitate authentication and mirroring.

The Mirroring Client service obtains access to the database by submitting the **Context Id** of the customer ("cust1234"), which uniquely identifies the customer in the online universe.

Whoever sets up database mirroring, is responsible if it breaks or stops! If you restore your primary database from backup, you should discard the mirror. **Backup-and-restore cycles during a failed upgrade do not trigger a mirror wipe.**

## Provisioning

Even though most of the mirroring client service is written by SuperOffice in the NuGet package, the partner creating the application has the ultimate responsibility to provision the mirror database as well as to host the service. How this is done and where the database resides are **solely the partner’s concern**.

There is no separate method to indicate that you have a new customer: calls simply start to come in.

The 1st mirroring happens immediately after the customer [approves the application][9].  After that, the Online master scheduler controls mirroring.

This mirroring service will provision mirror databases on 1 fixed SQL server. Each database will be named `Mirror_<contextId>`.

Any test databases (tenants) that approve your application will receive a mirror shortly after authorization, and the mirror will be kept up to date as long as it stays authorized.

## Hand-shake protocol for mirroring

Before transferring any mirrored data, we need to establish a two-way trust. The Mirroring Task will only proceed if it gets a valid response from the client.

1. SuperOffice initiates the handshake by sending a security token that contains a tenant's context identifier and timestamp to your mirroring web service.
2. The `IMirroringClientService` **Authenticate** method at your end must [validate the security token][10] and then respond with **ApplicationToken** and **timestamp** [signed with a private key][11].
3. SuperOffice validates the response.

![authenticationsequencediagram -screenshot][img3]

There is no user or session concept in the mirroring client, so no session token is ever issued.

The Mirroring Task sends the SuperOffice signed token with every call so that the client can validate each call independently.

<!-- Referenced links -->
[1]: getting-started/i-mirror-client-service.md
[2]: mirroring-task.md
[3]: sql-server-schema.md
[4]: blocked-tables.md
[5]: ../developer-portal/getting-started/index.md#terminology
[8]: ../developer-portal/custom-app/index.md
[9]: ../developer-portal/provisioning/get-consent.md
[10]: ../api/authentication/online/validate-security-tokens.md
[11]: ../api/authentication/online/auth-application/sign-system-user-token.md

<!-- Referenced images -->
[img1]: media/trendsyapp.png
[img2]: media/trendsy.png
[img3]: media/authenticationsequencediagram.png

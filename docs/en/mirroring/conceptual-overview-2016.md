---
title: Conceptual overview
uid: mirroring_conceptual_overview_2016
description: Conceptual overview of database mirroring
author: Tony Yates
so.date: 04.20.2016
keywords:
so.topic: concept
so.envir: cloud
so.client: online
---

# Conceptual overview

Imagine you are an online application vendor who has created the world's best trending software. You have created an application that can scan a database, mine it for patterns, and display trend reports. It would be nearly impossible to do this effectively with only web services.

![x -screenshot][img1]

SuperOffice Database Mirroring provides a way for online partners to have access to a tenants database. Partners do not get an exact copy of a tenant database, but a subset that contains more than enough data for what partner applications need for offline processing.

A lot of data in the database is irrelevant and would not make sense to replicate. Data, such as last know window positions, criteria information, and things of that nature are not relevant for processing customer data. User credentials and sensitive information are also removed, and as a result **you will not be able to connect to the mirror database using any SuperOffice client or APIs**.

It's important to note that Database Mirroring is not itself an application. Similar to how a window is a property of a house, Database Mirroring is a property of an application. It's an option that can be enabled or disabled for any online application. The primary components that make up Database Mirroring are:

* The registered application inside SuperOffice Operations Center (OC).
* The Mirroring Task, which is a background service in OC
* A web service that implements both the IMirrorClientService and IMirrorAdmin interfaces.

The [registered application][1] contains all of the information provided by the partner about the application: description, contact information, technical contact, and so on. It also contains the application id and application token, which was generated when the partner registered the application, as well as whether Database Mirroring is enabled or not. When enabled, the application definition must also contain the Mirroring URL; which is where the Mirroring Task will send the data.

The Mirroring Task is the responsibility of SuperOffice. It represents the background process that transfers data from a tenant database to a partner's registered application. It resides inside OC, and is responsible for provisioning the change tracking in the customer database as necessary.

![x -screenshot][img2]

Partners must create and host the web service that receives the data. Their web service must implement the IMirroringClient interface. The IMirrorClientService interface is responsible for establishing a trusted connection, receiving the data, and performing the actual mirroring, such as provisioning of tables and performing schema updates.

## Implementation Overview

SuperOffice starts the process by sending the partner web service a security token that contains a tenant's context identifier and timestamp. It's up to the IMirroringClientService Authenticate method to validate the security token and respond with its ApplicationToken and timestamp. SuperOffice in turn validates the partner's response to establish a two-way trust.

![x -screenshot][img3]

There is no user or session concept in the Mirroring Client, so no session token is ever issued. The Mirroring Task will only proceed if it gets a valid response from the Client. The **Mirroring Task sends the SuperOffice signed token with every call so that the Client can validate each call independently**.

OC handles the scheduling of the Mirroring Task, running it periodically for each customer and application instance.

On each customer tenant, there are multiple tasks running in sequence. The mirroring task is scheduled to run every 10 minutes, but times may vary if there is another long-running customer task that is not yet finished. As of April 2019, we also stop the task completely between 23.00 to 06:00 every night.

For each cycle, the following operations are performed:

1. Authenticate with the registered service. SuperOffice sends a token that contains a signed context id + timestamp. The receiver validates it and then responds with its ApplicationToken + timestamp, signed with a private key. See the section System User Authentication in the [Online Authentication in Detail article][2] for the correct formatting. The NuGet package provided by SuperOffice includes methods to facilitate these functions.

2. For each table to be synchronized
    1. Check that change tracking is enabled for the table. If not, enable it
    2. Read the physical schema, and send it to the client
    3. The client responds with the Log Sequence Number (a 64-bit integer assigned by SQL Server) it has data for, for that table; and also updates its physical schema (including creating the table from scratch) as needed.
    4. Read the `<chunksize>` oldest changes from the table. If change tracking was not installed previously, or the client did not have the table, all rows are considered changed
    5. Transmit the changes to the client, each row includes its Log Sequence Number.
    6. The client writes the data to the mirror and returns the Log Sequence Number of the last successfully written row.
    7. Repeat 2.4 - 2.6 until no more changes are found

3. After the last table has been synchronized, call the ReplicationCompleted method to indicate that mirroring is complete for this customer. The call can be used to generate indexes or perform other relevant tasks.

This process will automatically set up change tracking on the Online side and create and update the schema of tables on the client-side. It will regenerate the mirror if it is thrown away or an older version is restored from backup.

If an older original is restored from backup, then the mirror should be thrown away; this is a very rare occurrence. Also note that Mirroring does not run during "maintenance" states, such as Online version upgrades, so backup/restore cycles during a failed upgrade do not trigger a mirror wipe.

![x -screenshot][img4]

<!-- Referenced links -->
[1]: ../developer-portal/create-app/wizard/index.md
[2]: ../api/authentication/online/auth-application/sign-system-user-token.md

<!-- Referenced images -->
[img1]: media/trendsyapp.png
[img2]: media/trendsy.png
[img3]: media/authenticationsequencediagram.png
[img4]: media/mirroringprinciplessequencediagram.png

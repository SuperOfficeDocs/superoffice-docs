---
title: IMirrorClientService
uid: i_mirror_client_service
description: IMirrorClientService interface
author: SuperOffice Product and Engineering
keywords:
content_type: reference
deployment: online
platform: web
---

# IMirrorClientService interface

SuperOffice NuGet implementation of `IMirrorClientService` interface for Microsoft SQL Server.

## MirroringClientImplementation class

The `MirroringClientService` class file is the [database mirroring][1] web service that SuperOffice will call to synchronize databases. The class inherits from the `MirroringClientImplementation` class, which resides in the `SuperOffice.Online.Mirroring` assembly.

* `MirroringClientImplementation` contains almost everything a database mirroring service needs to synchronize an online tenant database with a local SQL Server database server.
* `MirroringClientImplementation` must:
  * resolve a tenants context identifier to a particular database
  * create the database if necessary
  * discover and provide the service's ApplicationToken and the private certificate key required to sign the token

Luckily for you, these 3 tasks are implemented in the *MirroringClientService.cs* file. However, you still must provide those key pieces of information in the project's *web.config* file.

## Methods

The `IMirrorClientService` interface has 5 self-contained methods:

* Authenticate
* ReplicationCompleted
* RowData
* TableSchema
* Wipe

The NuGet implementation is for Microsoft SQL Server only!

![x -screenshot][img1]

![x -screenshot][img2]

No state is carried over from a call to the next. However, multiple calls may be active at the same time, for multiple customers, tables, or both. The only guarantee is that:

* There will not be multiple active calls for a specific combination of customer and table
* Each customer’s [mirroring cycle][2] will run in a linear timeline from start to end

All implementations of `IMirrorClientService` **must be multi-tenant and fully re-entrant**.

### Authenticate

This method is called once per customer, at the beginning of a mirroring cycle, to establish that the URL of the registered application actually belongs to someone who has the private key of the same application.

It is used to exchange and validate signed tokens by both the Mirroring Task and the Mirroring Client.

No session or state on the Mirroring Client is established.

Authenticate must return the application token and a timestamped signed with the application’s private key.

### ReplicationCompleted

This method is called once at the end of a successful mirroring cycle by the Mirroring Task.

The SuperOffice NuGet implementation does nothing. The purpose is solely to call `IMirrorAdmin.OnReplicationCompleted()` with the number of inserted, updated, and deleted rows for each table during the cycle.

Partner code can use `ReplicationCompleted()` to create indexes, update derived data, or whatever else is required.

### RowData

This method is called once for each [batch][2] of data sent.

**Arguments:** 1 or more batches of row data

Each row is tagged with an operation: insert, update, or delete.

If a row has changed multiple times since the last time it was mirrored, then only the final state is transmitted. For example, if the row was inserted and then updated, then the row will be tagged with *insert* but only the final state will be sent.

Only the final batch for a table will have a valid LSN because intermediate rows may or may not have LSNs. If tracking was turned on recently, all rows existing before that time will not have an LSN.

The SuperOffice NuGet implementation saves the data and updates the LSN stored in the mirror’s metadata table. Insert operations are accumulated and committed through the Bulk Copy mechanism for speed.

### TableSchema

This method is called once before any data is sent.

**Arguments:**

* The physical schema from Online (original)
* The LSN (Log Sequence Number) is passed back to the Mirroring Task, so it knows which data to send

The mirror database is the only place where the LSN from the last update is known.

`TableSchema()` updates the mirror’s physical schema for the table if needed.

One way to trigger a schema update is by dropping the table and recreating it with the new schema. In that case,  the client should return an LSN of -1 to force a full repopulation.

`IMirrorAdmin.OnBeforeReplicateTable()` is called after each schema update, with parameters specifying the table and whether the schema is altered. It takes an array of table schemas so that the communication is more efficient. Tables not present are assumed to be deleted from the source database and should be deleted from the mirror.

The processing of each table is individual and in principle independent of other tables. It can be parallelized if desired.

### Wipe

This method is called during the initial mirroring and subsequently whenever the Mirroring Task has detected that a table needs to be fully repopulated.

There is no separate call to drop tables. This is handled by the absence of a table from the TableSchema request.

The SuperOffice NuGet implementation performs a truncate table command that removes all data but keeps all schema structures (such as indexes). `IMirrorAdmin.OnWipe()` is called after the truncate command has run.

## Overriding default functionality

You can choose to override any of the methods of the base class. For example, to inspect the parameters in detail, call the base implementation, and perform other related functions. This is useful if the existing `IMirrorAdmin` interface events are insufficient.

![x -screenshot][img3]

Partner code can use this call when it needs to adjust its data, remove indexes, or perform other preparatory functions.

<!-- Referenced links -->
[1]: ../overview.md
[2]: ../mirroring-task.md

<!-- Referenced images -->
[img1]: media/imirroringclientservice.png
[img2]: media/imirroradmininterface.png
[img3]: media/interface-implementation-classview.png

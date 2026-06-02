---
title: Requirements
uid: mirroring_requirements
description: Prerequisites for running the Database Mirroring client on a customer-managed host.
author: SuperOffice Product and Engineering
date: 05.27.2026
keywords: database mirroring, requirements, prerequisites, .NET 8, SQL Server
content_type: reference
deployment: online
platform: web
---

# Database Mirroring requirements

The Database Mirroring client runs on a customer-managed host and connects **outbound** to SuperOffice. There is no public endpoint to host, no IIS site, no SuperOffice-issued certificate to install, and no inbound firewall rule to maintain.

A SuperOffice Online subscription that includes the **Database Mirroring** add-on is required. Custom apps that incorporate Database Mirroring need the same subscription.

## Host

* Any Windows host that can run a .NET 8 application.
* **Local administrator rights** for the initial provisioning and Windows Service installation.

Sizing depends on the size of the source database and the throughput required:

| Resource | Minimum | Recommended |
|---|---|---|
| RAM | 4 GB | 8 GB or more |
| Disk space (replica DB excluded) | Modest &mdash; the client binary and logs only | &mdash; |
| Disk space for the replica DB | Plan for it to grow to roughly the size of the source CRM data, plus headroom for indexes | &mdash; |

## Software

* **.NET 8 runtime** &mdash; or use the self-contained build that ships with its own runtime.
* **Microsoft SQL Server** for the replica database. An empty database is recommended for the initial setup. SQL Server Express Edition is sufficient for small tenants; use Standard Edition (or higher) when you need SQL Agent, larger databases, or higher throughput.
* The SQL login used by the client needs **`db_owner`** on the replica database, so it can create and alter tables and maintain the internal `_ReplicationState` table.

## Network

* **Outbound HTTPS (443)** from the host to the SuperOffice Replication Dispatcher and Service URLs.
* No inbound ports.
* No SuperOffice-issued TLS certificates.

If you operate behind a strict outbound proxy, allow-list the SuperOffice replication endpoints (the exact URLs are shown in the terminal output after `provision` and in the [setup guide](setup-guide.md)).

## Backup

The replica database does not normally need its own backup strategy &mdash; the data is a copy of the SuperOffice cloud master and can always be re-synced. The exceptions are any **local additions** you make on top of the replica:

* Custom indexes, views, synonyms, triggers
* Application-specific tables that share the database

Back those up using your normal SQL Server backup process.

## Related

* [Set up the Database Mirroring client](setup-guide.md)
* [Overview](overview.md)
* [SQL Server schema](sql-server-schema.md)

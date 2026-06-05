---
title: Introduction
uid: mirroring_intro
description: Database Mirroring service for SuperOffice CRM Online &mdash; outbound-only client architecture, near-real-time CDC, simplified security.
author: SuperOffice Product and Engineering
keywords: database mirroring, replication, CDC, Kafka, replica
content_type: concept
deployment: online
platform: web
---

# Database mirroring

**Database Mirroring** keeps a customer-managed SQL Server replica in sync with your SuperOffice Online tenant. It is an API feature that applications can use for local processing &mdash; reporting, analytics, pattern recognition &mdash; when real-time data is not the most important consideration.

> [!NOTE]
> Internally, the current implementation is sometimes called the *Replication* service &mdash; this is the same Database Mirroring feature. Literal product artefacts (the **Replication** tab in Operation Center, the `SuperOffice.Online.Replication.Client.exe` binary, the `_ReplicationState` table) keep that name and are shown as-is in the documentation.

Mirroring a customer's database gives partners a great deal of flexibility to perform deep analysis on customer data &mdash; all without having to rely on web services subject to latency or throughput issues.

> [!CAUTION]
> Database Mirroring is **NOT** for customers who lack the competence to set it up and maintain it themselves.

## How it works at a glance

The customer runs a small **client** on a host of their choice. The client makes **outbound HTTPS** calls to the SuperOffice cloud, streams change events from the source CRM, and applies them to a local SQL Server replica. There is no inbound endpoint, no IIS site, no certificate to install, and no firewall opening.

```text
   +------------------------------+
   |  Customer host               |
   |                              |
   |  Mirroring client            |
   |  (Windows Service)           |
   |          |                   |
   |          | outbound HTTPS    |
   |          | long-poll         |
   |          v                   |
   |  +---------------+           |
   |  |  Replica DB   |           |
   |  +---------------+           |
   +------------------------------+
                |
                v
       SuperOffice Cloud
       (Replication Service)
```

> [!NOTE]
> An [earlier WCF-based implementation][1] inverted these roles: the cloud pushed data into a partner-hosted endpoint. That implementation is now legacy. New customers should always use the outbound-only client. Existing customers should plan a [migration][2].

## What changed and why it matters

The new client model is faster, simpler to operate, and easier to secure than the legacy WCF-based service it replaces.

### Near-real-time data instead of scheduled batches

The legacy service ran on a server-driven batch cycle. SuperOffice periodically read changed rows using the SQL Server Log Sequence Number (LSN), grouped them into batches, and pushed the batches to the customer endpoint. End-to-end latency was typically measured in hours.

The new model uses **Change Data Capture (CDC)** at the source database, with changes streamed through Kafka. The client long-polls for new events; when a row changes in the cloud, the corresponding event is normally available within seconds and applied to the replica shortly after. The architecture is event-driven rather than scheduled.

### A simpler and stronger security posture

| Concern | Legacy mirroring | New client |
|---|---|---|
| Inbound network exposure | Public HTTPS endpoint required | None &mdash; outbound only |
| TLS certificates on customer side | Manually installed, environment-specific, manually renewed | Not required |
| Authentication | RSA-signed tokens between fixed certificates | Short-lived JWT access token (~20 min) with rotating refresh token |
| Local secret storage | Files on disk, customer-managed | Stored in the replica DB, encrypted with Windows DPAPI (LocalMachine scope) |
| Token rotation | Tied to certificate renewal | Automatic, on every refresh |

The practical effect is that customers no longer need a PKI process to keep mirroring alive, and the attack surface is reduced to outbound HTTPS to a known SuperOffice endpoint.

### Lower operational overhead

The new client ships as a single command-line executable that can be installed as a Windows Service. There is no IIS site, no application pool, no hosted WCF endpoint. Setup is initiated from the customer's machine and completes in a browser-based login. Multiple instances (for example, one for Test and one for Production) can run side-by-side from separate folders without conflict.

### Schema evolution and lifecycle handled transparently

When new tables become available in the source CRM, the client picks them up automatically on its next schema-check cycle (default: hourly, configurable). When a customer database is moved between servers, restored from backup, suspended, or resumed, the SuperOffice provisioning sagas reset the offsets and trigger a fresh snapshot. The local client absorbs these events as upserts &mdash; in most cases no manual intervention is required.

## Primary components

A short tour of the moving parts:

* **Replication Dispatcher.** Handles interactive provisioning, issues access and refresh tokens, and exposes the Partner API for multi-tenant scenarios.
* **Replication Service.** Serves the event stream over a REST endpoint with long-polling, and tracks consumer offsets per session.
* **Kafka Connect (Debezium).** Reads CDC from the source SQL Server and publishes events to Kafka topics named `<ctx>-cdc` and `<ctx>-schemahistory`.
* **Mirroring client.** The on-premise component the customer runs (`SuperOffice.Online.Replication.Client.exe`). It pulls events, applies them to the replica, and persists its progress.
* **Operation Center (OC).** The SuperOffice-side admin UI for monitoring sessions and triggering recovery actions.

## Database management system

Microsoft SQL Server is the only supported target for the replica database.

The schema is **Microsoft SQL Server dialect** end-to-end. Foreign key constraints, collating sequences, and indexes are **not mirrored** &mdash; the schema is intentionally simplified. If you need indexes on the replica, create and maintain them yourself.

## Is the mirror database an exact copy?

No. You get a useful subset, not an exact copy. The replica contains more than enough data for what most applications need for offline processing.

Primary key, data type, NULL/NOT NULL, and default value are mirrored, along with the table and column names. [Read more about the schema][3].

We exclude data that is irrelevant, that would incur unnecessary stress between systems, or that simply doesn't make sense to replicate:

* Window positions
* DBI agent information
* Search criteria information and operators
* Area and travel tables
* User credentials
* Sensitive information
* Binary blobs and dictionary information tables (newly excluded with the new client)

A complete list of tables both replicated and not replicated, with reasons, is in the [blocked tables list][4].

You will **not** be able to connect to the mirror database using any SuperOffice client or API!

## When should I consider Database Mirroring?

Typical use cases:

* Reporting
* Pattern recognition
* Trend processing
* Long-running analytics that would saturate the REST API

## How do I use Database Mirroring?

Database Mirroring is an **option** that can be activated or deactivated for any online application. It is **not** a stand-alone, off-the-shelf product.

The customer must have a SuperOffice Online subscription that includes the Database Mirroring add-on. After that, the steps are:

1. [Order Database Mirroring][5] (if not already on the subscription).
2. Download the client from Operation Center.
3. [Set up the client][6].

The legacy NuGet package, WCF service, `IMirrorClientService` interface, and partner-issued certificates are **not used** in the new model. [Existing legacy mirroring users should follow the migration guide][2].

## Responsibility

Whoever sets up Database Mirroring is responsible if it breaks or stops. If you restore your primary database from backup, the SuperOffice side will normally trigger a fresh snapshot automatically. Backup-and-restore cycles during a failed upgrade do not trigger a mirror wipe.

## Next steps

* [Requirements][7] &mdash; what you need on the host
* [Set up the client][6] &mdash; step-by-step provisioning
* [Migrate from legacy mirroring][2] &mdash; if you are already running the WCF service
* [Troubleshooting][8]

<!-- Referenced links -->
[1]: conceptual-overview-2016.md
[2]: migrate.md
[3]: sql-server-schema.md
[4]: blocked-tables.md
[5]: order-database-mirroring.md
[6]: setup-guide.md
[7]: requirements.md
[8]: troubleshooting.md

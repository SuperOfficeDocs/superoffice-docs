---
uid: mirroring_track_changes
title: Change tracking
description: How Database Mirroring detects and streams changes from the source CRM to the replica.
keywords: database mirroring, change tracking, CDC, Debezium, Kafka, LSN
author: SuperOffice Product and Engineering
date: 05.27.2026
content_type: concept
deployment: online
platform: web
language: en
---

# Change tracking

The current Database Mirroring implementation uses **SQL Server Change Data Capture (CDC)** at the source database. Changes are read by a Debezium connector running in SuperOffice's infrastructure, published to per-tenant Kafka topics, and served to the client over a REST long-poll endpoint.

> [!NOTE]
> The [legacy WCF-based service][1] used SQL Server **Change Tracking** (a different and lighter-weight feature) with the Log Sequence Number (LSN) as the position marker. The mechanism described below replaces that approach for new deployments.

## How it works

1. The source SQL Server has CDC enabled on the tables that are subject to mirroring.
2. **Debezium** reads the CDC changes and publishes them to a per-tenant Kafka topic (`<ctx>-cdc`). Schema-change events are published to a parallel `<ctx>-schemahistory` topic.
3. The **Replication Service** exposes a REST endpoint with **long-polling**. It tracks consumer offsets per session.
4. The **Database Mirroring client** long-polls for new events, applies them to the replica, and commits its progress back to the service.

The position marker is the Kafka `topic:partition:offset` &mdash; not a SQL Server LSN.

## Latency

End-to-end latency is normally measured in **seconds**: a row changes in the cloud, the CDC connector publishes the event, the client picks it up on its next long-poll, and applies it to the replica. Actual latency depends on network conditions and replica throughput.

## Retention: 7 days

Change events are retained in Kafka for **7 days** by default. If the client is offline longer than that, events will have been purged from the topics and the client cannot fill the gap by replaying older events.

To recover, you re-snapshot the affected tables. See [Force re-sync][2].

## Schema-change detection

New tables and altered tables are discovered by a periodic schema-check (default: every hour, controlled by `SchemaUpdateIntervalSeconds` in `appsettings.json`). You can force an immediate check with:

```cmd
SuperOffice.Online.Replication.Client.exe update-schema
```

## Legacy SQL Server change tracking

> [!IMPORTANT]
> This section describes the original mechanism used by the legacy WCF-based mirroring service. It is kept here for context and for customers still running the legacy service.

The legacy implementation relied on the SQL Server **Change Tracking** feature (`CHANGETABLE`, `CHANGE_TRACKING_CURRENT_VERSION`), which is a lightweight mechanism implemented directly in the database engine. It uses an incremental 64-bit integer &mdash; the **Log Sequence Number (LSN)** &mdash; as the position marker.

Using this method, rather than the internal `TravelTransactionLog`, avoided complexity in situations such as:

* UDEF changes
* Merging two companies (logged differently from other operations)
* Service operations (not logged at all in `TravelTransactionLog`)

### How the legacy mechanism worked

1. When change tracking for a table was OFF, it was automatically turned ON by the mirroring system.
2. A **wipe** message was sent to the client.
3. All records in the table were considered changed and transmitted to the client.

### Legacy retention

Change tracking data in SQL Server was kept for 7 days. If a mirroring client service was down for more than a week, change data would be missing and the next synchronization would cause a complete, automatic repopulation of the mirror.

<!-- Referenced links -->
[1]: #legacy-sql-server-change-tracking
[2]: force-resync.md

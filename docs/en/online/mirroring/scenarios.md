---
title: Scenarios
uid: mirroring_scenarios
description: How the Database Mirroring client handles common situations &mdash; new customers, backups, restores, downtime, schema changes.
author: SuperOffice Product and Engineering
date: 05.27.2026
keywords: database mirroring, replication, scenarios, backup, restore, snapshot
content_type: reference
deployment: online
platform: web
---

# Database Mirroring scenarios

The system is largely self-bootstrapping. The table below summarises what happens in common situations.

## Scenarios that are handled

| Action | SuperOffice cloud | Customer / client |
|---|---|---|
| New customer | CDC is enabled at the source. An initial snapshot is published. | The client provisions, performs the initial snapshot, and starts long-polling for changes. |
| Replica restored from backup | Ordinary streaming continues. | Kafka offsets travel with the replica (stored in `_ReplicationState`). The client resumes from where the restored snapshot left off. Any changes published after the offset are received and applied. |
| Source database restored from backup or moved | Tenant-operations sagas reset the offsets and trigger a fresh snapshot. | The client receives upserts for the snapshotted rows and reaches a consistent state automatically. No manual intervention. |
| Writing to the replica fails | Streaming continues. | The client retries the failed batch. Progress is only committed when a transaction succeeds. Subsequent retries pick up where the last successful commit left off. |
| Client is offline for **less than 7 days** | Events accumulate in Kafka. | The client resumes from the saved offset and replays the buffered events. |
| Client is offline for **more than 7 days** | Events have been purged from Kafka. | The client cannot fill the gap by replay. Run [`resync-tables`][2] on the affected tables (or, in extreme cases, request a full reset from SuperOffice Operations). |
| New table added in SuperOffice Service | The schema is detected by the connector and published. | On the next schema-check cycle (default: hourly, `SchemaUpdateIntervalSeconds`) the client picks it up and snapshots it. Force immediately with `update-schema`. |
| Incompatible schema change (rare) | A schema event is published. | The client drops the affected table in the replica, re-creates it with the new schema, and requests a fresh snapshot for just that table. |
| Tenant suspended / resumed | Provisioning sagas pause and then reset offsets. | The client absorbs the resulting snapshot as upserts and continues. |

## Related

* [Set up the Database Mirroring client][1]
* [Force re-sync][2]
* [Change tracking][3]
* [Troubleshooting][4]

<!-- Referenced links -->
[1]: setup-guide.md
[2]: force-resync.md
[3]: change-tracking.md
[4]: troubleshooting.md

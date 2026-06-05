---
uid: mirroring_sql_server_schema
title: SQL Server schema
description: SQL Server schema used by the Database Mirroring replica.
keywords: database mirroring, schema, crm7, dbo, _ReplicationState, TablePrefix
author: SuperOffice Product and Engineering
date: 05.27.2026
content_type: concept
deployment: online
platform: web
language: en
---

# SQL Server schema for Database Mirroring

The replica database uses **Microsoft SQL Server** dialect end-to-end. Because the physical schema is what gets replicated, the client does not distinguish between *dictionary* and *normal* tables &mdash; or between tables belonging to Sales, Service, extra tables in Service, or partner-defined tables that might appear in the future.

The schema is **simplified**: foreign key constraints, collating sequences, and indexes are **not** mirrored.

> [!NOTE]
> Row- and column-level filtering is not supported. Tables are either mirrored or not.

## Destination schema (`crm7` vs `dbo`)

The client preserves the **source schema** by default &mdash; typically `crm7`. Most replicated tables therefore end up as `crm7.contact`, `crm7.person`, `crm7.sale`, and so on.

If your downstream applications expect tables in `dbo` (or another schema), you can override the destination with the `TablePrefix` setting in `appsettings.json`:

```json
{
  "ReplicaDatabase": {
    "TablePrefix": "dbo"
  }
}
```

| `TablePrefix` value | Result |
|---|---|
| Empty or omitted (default) | Preserves source schema &mdash; typically `crm7` |
| `"dbo"` (or any other name) | All replicated tables created in that schema |

> [!IMPORTANT]
> `TablePrefix` only takes effect during the **initial snapshot**. It must be set before you run `provision`. Changing it after provisioning **does not** move tables between schemas.

For details on choosing the right schema during a migration, see [Schema alignment][2].

## Session state: the `_ReplicationState` table

The client maintains one internal table in the replica database: **`_ReplicationState`**. It is created automatically during `provision` and stores:

* The session identifier and tenant context.
* The encrypted access and refresh tokens (encrypted with Windows DPAPI, `LocalMachine` scope).
* Replication progress offsets per Kafka topic and partition.
* The schema hash per replicated table.

Because the session state lives **inside the replica database**, it follows the database through backups, restores, and renames. No re-provisioning is required as long as the database itself moves with the client.

> [!WARNING]
> Do not edit, truncate, or drop `_ReplicationState` manually. If you need to start over, use [`resync-tables`][5] or, in extreme cases, re-`provision` against an empty database.

## Indexes and other auxiliary objects

The client creates and maintains only the **replicated tables themselves**. Any indexes, views, synonyms, or triggers you need on the replica must be created and maintained by you.

Good places to do this in your own deployment:

* As part of an initial post-`provision` setup script.
* After table changes detected through `update-schema`.

## Blocked tables

The replica contains a useful subset of the source database, not an exact copy. Tables that fall into one of the following categories are excluded:

* **Irrelevant** &mdash; for example `travelgeneratedtransaction`.
* **Not useful** for analytics &mdash; for example `traveltransactionlog`, `countervalue`.
* **Confidential** &mdash; for example `credentials`.
* **Binary blobs and dictionary cache** &mdash; the `binaryobject` table and dictionary information tables are excluded to keep the replica cleaner and faster.

See the full [list of blocked tables][3].

## When schema changes fail

This can happen if a customer creates an extra table containing a character field through SuperOffice Service, drops it, and re-creates it with the same name but a different data type for one of the columns.

In that case the client reacts by dropping the affected table in the replica, re-creating it with the new schema, and triggering a full re-snapshot for that table.

## Related

* [Set up the Database Mirroring client][1]
* [Schema alignment during migration][2]
* [Blocked tables][3]
* [Force re-sync][4]

<!-- Referenced links -->
[1]: setup-guide.md
[2]: migrate.md#schema-alignment-dbo-vs-crm7
[3]: blocked-tables.md
[4]: force-resync.md
[5]: setup-guide.md#command-reference

---
title: Migrate from the legacy mirroring service
uid: mirroring_migrate
description: How to migrate from the legacy WCF-based Database Mirroring service to the new outbound-only client.
author: Margrethe Romnes
date: 05.27.2026
keywords: database mirroring, replication, migration, cutover, legacy
content_type: howto
deployment: online
platform: web
---

# Migrate from the legacy mirroring service

This guide is for customers and partners who are already running the legacy WCF-based Database Mirroring service and want to switch to the new outbound-only client.

**Who this is for:** Technical staff at customers and partners. **Scope:** What changes, how to run both services in parallel during validation, and how to retire the legacy one.

## At a glance

| Topic | Legacy mirroring | New client |
|---|---|---|
| Network direction | Inbound to customer | Outbound from customer |
| Customer-hosted endpoint | Required (IIS + TLS cert) | None |
| Authentication | RSA certificate signing | JWT access + rotating refresh token |
| Local secret storage | File on disk | DPAPI-encrypted in replica DB |
| Transport | SOAP/WCF | REST + long-poll over Kafka-backed CDC |
| Latency | Hours, scheduled batches | Seconds, event-driven |
| Schema additions | Manual | Detected automatically |
| Setup | App registration, IIS, certificates | Zip + browser login + service install |
| Multiple instances per host | Awkward | Supported by design |
| Logging | Application-specific | Event Log, NLog, Application Insights |

## Recommended approach: parallel run with database rename cutover

The two implementations are **independent**. They do not share state, and there is no in-place upgrade. The recommended approach is to:

1. Stand up a second replica database alongside the existing one.
2. Replicate into it with the new client while the legacy service continues to feed the original replica.
3. Validate the new replica against the existing one.
4. Swap the database names so consuming applications keep using the original database name.

> [!IMPORTANT]
> Before you start, decide on the [destination schema][2] for the new replica. Schema alignment is part of the contract with your downstream applications, and the setting that controls it must be in place **before** the first sync.

## Step-by-step migration

### 1. Create a new replica database

Create an empty database alongside the existing one, with a clearly distinct name. The convention used here is `<existing_name>_new` &mdash; for example, if the legacy replica is `SuperOfficeReplica`, create `SuperOfficeReplica_new`.

The database should be empty: the new client performs an initial CDC snapshot during provisioning.

### 2. Provision the new client against the new database

Follow the [setup guide][1]. When you configure `appsettings.json`, point `ReplicaDatabase.ConnectionString` at `SuperOfficeReplica_new`. Then run:

```cmd
SuperOffice.Online.Replication.Client.exe provision
SuperOffice.Online.Replication.Client.exe validate
SuperOffice.Online.Replication.Client.exe sync
```

The legacy mirroring service continues to feed the existing replica untouched.

### 3. Run both services in parallel

The legacy service populates the original replica; the new client populates the `_new` replica. They are independent and do not contend.

### 4. Validate the new replica

While both services are running:

* Compare row counts on key tables.
* Run representative application queries against both replicas and compare the results.
* Confirm that schema changes pushed during the parallel period reach both replicas.
* Verify that any auxiliary objects on the legacy replica (custom indexes, views, synonyms, triggers) have been re-created on the new replica. See [What does not carry over][7].

### 5. Cut over with a database rename

When validation is complete:

1. **Stop the legacy mirroring client process** (and the IIS site, if applicable).

2. **Stop the new Windows Service**:

    ```cmd
    sc stop "SuperOfficeReplicationClient_<ReplicationId>"
    ```

3. **Rename both databases.** In SQL Server, rename the existing `SuperOfficeReplica` to `SuperOfficeReplica_old`, then rename `SuperOfficeReplica_new` to `SuperOfficeReplica`:

    ```sql
    ALTER DATABASE SuperOfficeReplica MODIFY NAME = SuperOfficeReplica_old;
    ALTER DATABASE SuperOfficeReplica_new MODIFY NAME = SuperOfficeReplica;
    ```

    > [!NOTE]
    > Renaming requires no active connections. Switching the database briefly to `SINGLE_USER` mode is the simplest way to enforce that.

4. **Update `appsettings.json`** so `ReplicaDatabase.ConnectionString` points at `SuperOfficeReplica` again (the new name of the database that was previously `_new`).

5. **Start the Windows Service.** The session state lives in the `_ReplicationState` table inside the database itself, so it follows the database through the rename &mdash; no re-provisioning is required.

### 6. Switch existing service connections

Downstream services and applications that consume the replica typically reference the database by name in their connection strings. Because the renamed database now carries the original name, the connection strings themselves do not need to change. However, the consuming services do need to **reconnect** so that pooled connections and any cached schema metadata are refreshed:

* **Windows Services and IIS application pools** should be restarted &mdash; the simplest and most reliable approach.
* **Long-lived processes** that hold prepared statements or schema handles must be cycled; a pool reset alone is not always sufficient.
* **Confirm SQL Server logins, database users, and role memberships** on the renamed database are intact. A rename preserves principals, but it is worth a check &mdash; especially for service accounts that downstream applications depend on.

### 7. Turn off the legacy mirroring on both sides

On the **customer side**, stop the legacy mirroring client (or stop and disable the IIS site that hosts it).

On the **SuperOffice side**, the legacy mirroring is delivered as an app registered in the SuperOffice Developer Portal. You can turn it off in either of two ways:

* Create a new version of the app with mirroring disabled and [request publishing][turn-off]. See also [How to turn off mirroring][turn-off].
* Or contact SuperOffice Operations and ask for the app to be **revoked** if it is no longer needed.

> [!WARNING]
> Until SuperOffice has confirmed the change, the cloud continues to attempt outbound calls to the (now offline) legacy mirroring endpoint and sends failure notifications by email to the technical contact.

This step is intentionally last and is only carried out once the new setup has stabilised &mdash; it makes a fast [rollback][3] possible.

## <a id="schema-alignment-dbo-vs-crm7"></a>Schema alignment: `dbo` vs `crm7`

Legacy customers chose the schema for their replica database: some standardised on `crm7`, others on `dbo`. The application code that consumes the replica is written against whichever was chosen, so the schema is part of the contract between the replica and its consumers.

The new client supports the same choice through a configuration setting in `appsettings.json`:

```json
{
  "ReplicaDatabase": {
    "TablePrefix": "dbo"
  }
}
```

When `TablePrefix` is empty or omitted (the default), the client preserves the source schema &mdash; typically `crm7`. When set to a value such as `"dbo"`, all replicated tables are created in that schema instead.

> [!IMPORTANT]
> **For a database rename swap, the schemas must be aligned.** The new replica needs to expose tables under the same schema as the existing replica; otherwise, downstream queries that reference `dbo.person` will break against a replica that exposes `crm7.person`, and vice versa.

Two practical points:

* **Set `TablePrefix` before `provision`.** The setting drives how the initial snapshot creates tables, so it must be in place before the first sync. Changing it afterwards does not move tables between schemas.

* **Confirm the schema of the existing replica first.** A quick query against the existing replica is the simplest way to be sure:

    ```sql
    SELECT DISTINCT TABLE_SCHEMA FROM INFORMATION_SCHEMA.TABLES;
    ```

If schema alignment is not desirable (for example, you want to consolidate to a different schema as part of the migration), the alternatives are to bridge with `CREATE SYNONYM` in the new database, or to update the application queries &mdash; but treat that as a separate decision from the cutover, not as the default path.

## What does not carry over

* **Offsets.** Legacy mirroring tracks position by SQL Server Log Sequence Number (LSN); the new client uses Kafka `topic:partition:offset`. There is no automatic conversion. The new client always begins with a fresh snapshot.

* **Local schema customisations** in the existing replica (indexes, views, triggers, synonyms) must be re-applied to the new replica before cutover. The replicated tables are managed by the client; auxiliary objects are not.

* **Excluded tables.** The new client uses the same base list of [blocked tables][4] as the legacy service, with a few additions to keep the replica cleaner and faster &mdash; notably the `binaryobject` table and dictionary information tables.

## <a id="rollback"></a>Rollback

**Before the rename** (during the parallel period), no special action is needed. The legacy service is still running, applications are still pointed at the original replica, and the `_new` database can simply be dropped and re-created.

**After the rename**, rollback is a second swap:

1. Stop the new Windows Service:

    ```cmd
    sc stop "SuperOfficeReplicationClient_<ReplicationId>"
    ```

2. Rename the databases back:

    ```sql
    ALTER DATABASE SuperOfficeReplica MODIFY NAME = SuperOfficeReplica_failed_new;
    ALTER DATABASE SuperOfficeReplica_old MODIFY NAME = SuperOfficeReplica;
    ```

3. Restart the downstream services.

The legacy service resumes populating the restored replica on its next cycle &mdash; which is precisely why turning off legacy mirroring on the SuperOffice side (step 7) is intentionally the last action, and only carried out once the new setup has stabilised.

## Related

* [Set up the Database Mirroring client][1]
* [Overview][5]
* [SQL Server schema][6]
* [Blocked tables][4]
* [How to turn off mirroring for an app][turn-off]

<!-- Referenced links -->
[1]: setup-guide.md
[2]: #schema-alignment-dbo-vs-crm7
[3]: #rollback
[4]: blocked-tables.md
[5]: overview.md
[6]: sql-server-schema.md
[7]: #what-does-not-carry-over
[turn-off]: ../../developer-portal/faq/turn-off-mirroring.md

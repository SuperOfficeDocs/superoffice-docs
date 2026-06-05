---
uid: force_mirroring_resync
title: Force re-sync
description: How to force a re-synchronization of one or more tables in the Database Mirroring replica.
keywords: database mirroring, replication, resync, snapshot, recovery
author: SuperOffice Product and Engineering
date: 05.27.2026
content_type: howto
deployment: online
platform: web
language: en
---

# Force re-sync

You have set up Database Mirroring and data was synchronizing as expected, but now you notice that some tables look out of date or missing rows. What do you do?

There is no GUI to inspect the replica &mdash; you must use **SQL Server Management Studio**. Generally, `SELECT * FROM <some table>` should return the same data on the source and the replica.

If a table is genuinely stale and the issue is not a transient connectivity problem, you can force a re-synchronization.

> [!NOTE]
> This page covers the new outbound-only client. For the legacy WCF-based mirroring service, see [the legacy procedure][1] at the bottom of this page.

## When you need a re-sync

Common reasons:

* A table is missing rows after extended client downtime.
* You suspect schema drift between source and replica.
* You want to revalidate a single table against the source after an incident.

## <a id="recover-from-extended-downtime-longer-than-7-days"></a>Recover from extended downtime (longer than 7 days)

Change events are streamed through Kafka topics with a default retention of **7 days**. If the client is offline longer than that window, change events will have been purged from the topics. The client cannot fill the gap by replaying older events &mdash; it has to be re-snapshotted.

You have three options, from least to most disruptive:

### Option A &mdash; Re-snapshot specific tables (recommended)

Use the `resync-tables` CLI command to trigger a Debezium signal-based snapshot of just the affected tables. The client truncates each table locally first, then receives a fresh snapshot from the cloud:

```cmd
SuperOffice.Online.Replication.Client.exe resync-tables crm7.person crm7.project
```

This is the **preferred** recovery path for most situations &mdash; it is targeted, fast, and does not disrupt other tables.

### Option B &mdash; Trigger via the Replication Service API

The same operation can be triggered from a backend or operations tool:

```http
POST /api/v1/replication/{contextIdentifier}/resync
Content-Type: application/json

{
  "tables": ["crm7.person", "crm7.project"]
}
```

This is useful when you cannot get a shell on the client host.

### Option C &mdash; Full reset (operations only)

If the entire replica needs to be rebuilt from scratch, SuperOffice Operations can reset all connector offsets, which triggers a complete re-snapshot of all tables:

```http
POST /admin/{contextIdentifier}/reset-offsets
```

This endpoint is restricted to SuperOffice Operations. Open a support case if you believe a full reset is the only option.

## Validate after a re-sync

Once the snapshot completes:

* Confirm the table is no longer empty and row counts look reasonable.
* Spot-check a handful of recent changes from the source.
* Check the Windows Event Log for any errors (source `SuperOfficeReplicationClient`).

## Legacy (WCF-based) mirroring

> [!IMPORTANT]
> This section applies **only** to the legacy WCF-based mirroring service. New deployments use the [outbound-only client][2] and follow the procedure above.

### Restart synchronization for a single table

1. Using **SQL Server Management Studio**, open the `<context identifier>_mirroring` table.
2. For each table you have identified as having a problem, **set `LSN` to `-1`** in the mirroring table.
3. Then truncate the data in the table(s) you set the LSN to `-1`:

    ```sql
    TRUNCATE TABLE <tablename>;
    ```

4. Shortly thereafter, the legacy Mirroring Task will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will begin to deliver periodic updates to your mirroring service.

### Hard reset the legacy mirror

1. Using **SQL Server Management Studio**, open the `<context identifier>_mirroring` table.
2. For each table you have identified as having problems, for example `contact`:

    ```sql
    DELETE FROM <context_identifier>_mirroring WHERE tablename = 'contact';
    ```

3. Then **drop** the affected table.
4. Shortly thereafter (the next mirroring cycle), the legacy Mirroring Task will send an authentication request, which your client must respond to. After successful authentication, SuperOffice will recreate the table and begin to deliver periodic updates.

## Related

* [Set up the Database Mirroring client][2]
* [Command reference][3]
* [Troubleshooting][4]
* [Migrate from the legacy mirroring service][5]

<!-- Referenced links -->
[1]: #legacy-wcf-based-mirroring
[2]: setup-guide.md
[3]: setup-guide.md#command-reference
[4]: troubleshooting.md
[5]: migrate.md

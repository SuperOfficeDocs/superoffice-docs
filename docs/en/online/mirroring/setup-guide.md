---
title: Set up the Database Mirroring client
uid: mirroring_setup_guide
description: Step-by-step setup and provisioning of the SuperOffice Database Mirroring client (outbound-only Replication Client).
author: Margrethe Romnes
date: 05.27.2026
keywords: database mirroring, replication, setup, provisioning, windows service, appsettings
content_type: howto
deployment: online
platform: web
---

# Set up the Database Mirroring client

The Database Mirroring client keeps a customer-managed SQL Server replica in sync with your SuperOffice Online tenant.

> [!NOTE]
> Internally, the new client is sometimes referred to as the *Replication Client* &mdash; this is the same Database Mirroring feature. The binary is named `SuperOffice.Online.Replication.Client.exe`, the Operation Center tab is labelled **Replication**, and the metadata table is `_ReplicationState`. These literal names appear throughout the product UI and are kept as-is in this guide.

Unlike the legacy WCF-based Mirroring service, the new client is **outbound-only**: it makes HTTPS calls to SuperOffice. You do not need to open inbound ports, host a public endpoint, or manage SuperOffice-issued certificates.

This guide walks you through the complete setup:

* [Prerequisites](#prerequisites) - what you need before you start
* [Step 1: Download the client](#step-1-download-the-client) from Operation Center
* [Step 2: Configure appsettings.json](#step-2-configure-appsettingsjson)
* [Step 3: Provision](#step-3-provision-authenticate-and-create-session) (authenticate and create session)
* [Step 4: Run a manual sync](#step-4-run-a-manual-sync)
* [Step 5: Install as a Windows Service](#step-5-install-as-a-windows-service)
* [Step 6: Validate](#step-6-validate)
* [Configuration reference](#configuration-reference)
* [Command reference](#command-reference)
* [Logging and diagnostics](#logging-and-diagnostics)
* [Operating considerations](#operating-considerations)

## Prerequisites

Make sure the following are in place before starting:

* **.NET 8 runtime** installed on the host machine (or use the self-contained build).
* **SQL Server** instance accessible from the host. An empty database is recommended for the initial setup.
* The SQL user needs **`db_owner`** permissions on the replica database, so the client can manage tables and the internal `_ReplicationState` table.
* **Outbound HTTPS** access from the host to the SuperOffice Replication Dispatcher and Service URLs.
* **Local administrator rights** on the host for provisioning and Windows Service installation.
* A SuperOffice Online subscription that includes the **Database Mirroring** add-on.

> [!IMPORTANT]
> There are no inbound ports to open, and no SuperOffice-issued certificates to install. The client connects outbound only.

## Step 1: Download the client

1. Sign in to **Operation Center (OC)** at [https://online.superoffice.com/OC2](https://online.superoffice.com/OC2).

2. If you have access to more than one tenant, navigate to the customer tenant and open the **Replication** tab.

    > [!NOTE]
    > If the **Replication** tab is missing, the customer does not have a Database Mirroring subscription. Contact SuperOffice to enable it.

3. Download the client zip file and extract it to a folder on the host, for example:

    ```text
    D:\ReplicationClient
    ```

## Step 2: Configure appsettings.json

Open `appsettings.json` in the extracted folder and update the connection string:

```json
{
  "ReplicaDatabase": {
    "ConnectionString": "Server=YOUR_SQL_SERVER;Database=YOUR_REPLICA_DB;Trusted_Connection=True"
  }
}
```

For more examples, see [connectionstrings.com/sql-server](https://www.connectionstrings.com/sql-server/).

### Choose the destination schema (optional)

By default the client preserves the source schema from SuperOffice &mdash; typically `crm7`. If your downstream applications expect tables in `dbo` (or another schema), set `TablePrefix` **before you run `provision`**:

```json
{
  "ReplicaDatabase": {
    "ConnectionString": "Server=...;Database=...;Trusted_Connection=True",
    "TablePrefix": "dbo"
  }
}
```

> [!WARNING]
> `TablePrefix` only takes effect during the initial snapshot. Changing it after provisioning **does not** move tables between schemas. See [Schema alignment](migrate.md#schema-alignment-dbo-vs-crm7) in the migration guide for details.

The defaults shown in the [configuration reference](#configuration-reference) suit most setups.

## Step 3: Provision (authenticate and create session)

Provisioning authenticates your administrator account and downloads the session configuration. Run this command from the extracted client folder:

```cmd
SuperOffice.Online.Replication.Client.exe provision
```

This opens a browser. Follow the sub-steps below.

### 3.1 Approve the Database Replication application

You are redirected to a SuperOffice consent page asking you to approve the **Database Replication** app by SuperOffice AS.

![SuperOffice consent page &mdash; click "I approve" to grant access -screenshot][img-consent]

Click **I approve** to continue.

### 3.2 Create the replication session

After approval you are taken to the **Provision Replication Session** page. Your tenant identity is shown automatically. Enter a **Session Name** and click **Create session**.

![Provision Replication Session page &mdash; verify identity, enter session name, click "Create session" -screenshot][img-provision]

> [!TIP]
> Choose a descriptive session name (for example, **Production** or **MyMirror**). It becomes the **Replication ID** that is visible in Operation Center and forms part of the Windows Service name.

### 3.3 Wait for provisioning to complete

Provisioning runs through five phases. It typically takes a few minutes, depending on database size.

![Phase 3/5 Ensure Primary Keys -screenshot][img-progress]

When you see the green **Provisioning complete** banner, the browser closes automatically and the terminal shows the results.

### 3.4 Confirm provisioning in the terminal

The terminal displays the provisioning summary:

![Terminal showing "Provisioning completed successfully" with Tenant, Replication ID and Service URL -screenshot][img-terminal]

Verify the output shows:

* `Provisioning completed successfully!`
* Your **Tenant ID** (for example, `cust6647`)
* The **Replication ID** (the session name you entered, lower-cased)
* The **Service URL** (for example, `https://app.superoffice.com/replication/service`)

The session, including the encrypted access and refresh tokens, is written to the `_ReplicationState` table in the replica database and is encrypted with Windows DPAPI (LocalMachine scope).

## Step 4: Run a manual sync

Before installing as a Windows Service, run a manual sync to verify replication works and to perform the initial data load:

```cmd
SuperOffice.Online.Replication.Client.exe sync
```

The terminal shows tables being created and populated in the replica database:

![Sync in progress &mdash; tables being created in the [crm7] schema of the replica database -screenshot][img-sync]

Wait until the sync completes. The initial sync can take several minutes for larger tenants. Subsequent syncs are near real-time (typically within seconds).

> [!TIP]
> You can validate the configuration without syncing by running:
>
> ```cmd
> SuperOffice.Online.Replication.Client.exe validate
> ```

## Step 5: Install as a Windows Service

Once the manual sync is verified, install the client as a Windows Service:

```cmd
SuperOffice.Online.Replication.Client.exe install
```

The installer prints the exact `sc start` command. Run it to start the service:

```cmd
sc start "SuperOfficeReplicationClient_<ReplicationId>"
```

The service name includes the Replication ID, so multiple instances (for example, Test and Production) can run side-by-side on the same host.

> [!TIP]
> After starting the service, confirm activity in **Windows Event Viewer** under **Windows Logs &rarr; Application**, filtering for source `SuperOfficeReplicationClient`.

## Step 6: Validate

Confirm the setup is working correctly:

* Open **SQL Server Management Studio** and check that tables exist in the expected schema (`crm7` by default, or whatever you set as `TablePrefix`) of your replica database.
* Run row-count queries on key tables (for example, `contact`, `person`, `sale`) and compare with the source.
* Check that the **`_ReplicationState`** table exists &mdash; it stores the encrypted session tokens and progress offsets.
* Monitor the Windows Service status in **Services (services.msc)** &mdash; it should show **Running**.
* Make a change in SuperOffice Online and verify it appears in the replica within seconds.

## Configuration reference

These keys live under the root of `appsettings.json`. The defaults suit most customers and are worth tuning only when network conditions or replica throughput become a bottleneck.

| Setting | Purpose | Default |
|---|---|---|
| `MaxBatchSize` | Maximum events per HTTP fetch | 10,000 |
| `MaxPollTimeSeconds` | Long-poll window held open by the server | 30 |
| `MaxBytes` | Soft cap on response size | 16 MB |
| `CommitIntervalSeconds` | How often progress is acknowledged to the cloud | 60 |
| `SchemaUpdateIntervalSeconds` | How often new tables are checked for | 3,600 |
| `DatabaseBatchSize` | Events per local database transaction | 1,000&ndash;10,000 |
| `ReplicaDatabase.ConnectionString` | SQL Server connection string for the replica | (required) |
| `ReplicaDatabase.TablePrefix` | Destination schema override (for example `"dbo"`) | (empty &mdash; preserves source schema) |

## Command reference

| Command | Purpose |
|---|---|
| `...exe provision` | Authenticate and download session configuration |
| `...exe validate` | Check configuration, DB connectivity and cloud reachability |
| `...exe sync` | Run replication interactively (foreground) |
| `...exe install` | Install as a Windows Service |
| `...exe uninstall` | Remove the Windows Service |
| `...exe info` | Show the current session: tenant, expiry, URLs |
| `...exe reconnect` | Re-authenticate when tokens are invalid |
| `...exe update-schema` | Force an immediate check for new tables |
| `...exe resync-tables <table> ...` | Re-snapshot specific tables (truncates them locally first). Example: `resync-tables crm7.person crm7.project` |

> [!NOTE]
> `...exe` is shorthand for `SuperOffice.Online.Replication.Client.exe`.

## Logging and diagnostics

The client supports three logging sinks out of the box. They can be combined &mdash; enabling one does not disable the others.

### Windows Event Log (default)

When run as a Windows Service, the client writes to **Event Viewer &rarr; Windows Logs &rarr; Application** under the source `SuperOffice Replication Client`. Log levels are controlled in `appsettings.json`:

```json
{
  "Logging": {
    "EventLog": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft": "Warning"
      }
    }
  }
}
```

Use `Information` for normal operation, `Warning` to reduce noise, and `Debug` only for short troubleshooting sessions &mdash; `Debug` is verbose.

### File logging with NLog

If an `nlog.config` file is present next to the executable, the client picks it up automatically and routes logs through NLog. A minimal configuration:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <targets>
    <target name="logfile" xsi:type="File"
            fileName="logs/replication-${shortdate}.log"
            layout="${longdate}|${level:uppercase=true}|${logger}|${message} ${exception:format=tostring}" />
  </targets>
  <rules>
    <logger name="*" minlevel="Info" writeTo="logfile" />
  </rules>
</nlog>
```

Because this is standard NLog, you can use any NLog target: rolling files, syslog, ElasticSearch, Splunk, Seq, a database table, or an HTTP endpoint. Logger filters can scope verbosity per namespace &mdash; for example, raising `SuperOffice.*` to `Debug` while leaving everything else at `Info`. Async wrappers are available where logging volume becomes a performance concern.

### Application Insights

If you run in Azure or already use Application Insights for observability, add a connection string to enable structured telemetry, dashboards, and alerting:

```json
{
  "ApplicationInsights": {
    "ConnectionString": "InstrumentationKey=..."
  }
}
```

## Operating considerations

A few points worth knowing:

* **Versioning.** The cloud may enforce a minimum client version. An out-of-date client stops replicating and logs a critical error. Plan a periodic upgrade window. Upgrades are a stop / replace binaries / start cycle and preserve `appsettings.json`, `nlog.config`, and the session state in the database.

* **Multiple environments on one host.** Test and Production clients can coexist by unzipping into separate folders, pointing each at its own replica database, and provisioning each independently. The installer derives unique service names from the session, so they do not collide.

* **Monitoring from the SuperOffice side.** Operation Center surfaces session health, last check-in time, and connector diagnostics. Customers do not see this UI directly, but it is the primary signal SuperOffice operations use when reacting to incidents.

* **Lifecycle events.** Database moves, restores, suspensions, and resumptions are handled by the standard tenant operations sagas on the SuperOffice side. They reset offsets and trigger a fresh snapshot, which the client absorbs as upserts. You do not normally need to intervene.

* **Recovery from extended downtime.** Change events are retained for **7 days**. If the client is offline longer than that window, see [Force re-sync](force-resync.md).

## Related

* [Requirements](requirements.md)
* [Migrate from the legacy mirroring service](migrate.md)
* [SQL Server schema](sql-server-schema.md)
* [Force re-sync](force-resync.md)
* [Troubleshooting](troubleshooting.md)

<!-- Referenced images (to be added later) -->
[img-consent]: media/replication-consent.png
[img-provision]: media/replication-provision-session.png
[img-progress]: media/replication-provision-progress.png
[img-terminal]: media/replication-provision-terminal.png
[img-sync]: media/replication-sync-progress.png

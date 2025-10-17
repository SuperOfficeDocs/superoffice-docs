---
title: Mirroring Task
uid: mirroring_task
description: About the database Mirroring Task
author: SuperOffice Product and Engineering
keywords: Mirroring Task, mirror
content_type: concept
deployment: online
platform: web
---

# The database Mirroring Task

The Operation Center schedules the database Mirroring Task, running it periodically for each customer and application instance.

This process will automatically set up change tracking on the SuperOffice CRM Online side, and create and update the schema of tables on the client-side. It will regenerate the [mirror][1] if it is thrown away or an older version is restored from backup.

[Log Sequence Number][2] (LSN) is a 64-bit integer assigned by SQL Server.

**For each cycle**, the following happens:

1. Establish 2-way trust between the Mirroring Task (MT) and the client.

2. **For each table** to be synchronized:

    1. The mirroring task enables change tracking for the table (if not already set).
    2. The mirroring task reads the physical schema and sends it to the client.
    3. The client responds with the **Log Sequence Number** if it has data for that table.
    4. The client updates its physical schema (including creating the table from scratch) as needed.
    5. For each chunk of changes (repeat until no more changes are found):
        1. The mirroring task reads the `<chunksize>` oldest changes from the table. If change tracking was not installed previously, or the client didn't have the table, all rows are considered changed.
        2. The mirroring task transmits the changes to the client. Each row includes its LSN.
        3. The client writes the data to the mirror and returns the LSN of the last successfully written row.

3. After the last table has been synchronized, call the `ReplicationCompleted` method to indicate that mirroring is complete for this customer.

> [!NOTE]
> Online customer databases don't keep state or progress indicator for mirroring, and there is no GUI for it either. By design, only the mirror knows the LSN for each table.

![sequence diagram -screenshot][img1]

## When does the mirroring task run?

The mirroring task is scheduled to run every 20 minutes. However, multiple tasks run in sequence on each customer tenant. If another task takes longer to complete than planned, the mirroring task might be delayed.

We also stop the task completely from 01.30 to 03:00 every night.

Mirroring does not run during server maintenance, such as SuperOffice CRM Online version upgrades.

## Options

Customers can add custom user preferences to control database mirroring behaviors.

| Preference Name   | Preference description                                      | Default value   |
|:---               |:---                                                         |:---:             |
|BatchSize          | Used to control how many bytes to send per request.         | 1000000         |
|SkipTable          | Comma separated list of tables that should not be mirrored. |                 |

From version 10.1.8 these may be [edited directly in Settings and maintenance][5].

![Update mirroring preferences in SuperOffice Settings and maintenance -screenshot][img2]

See the [Skip Tables][4] section to understand how to add the Mirroring preferences into SuperOffice.

## Batches

One mirroring batch is equivalent to roughly up to 1 megabyte of data. The number of rows will vary widely depending on the actual size of the rows.

Each batch refers to 1 table, but 1 call to the [IMirrorClientService][3] interface may reference multiple tables using multiple batches.

The SuperOffice CRM Online server will limit the total call size by tracking content size.

Batches can in principle be processed in parallel, but doing so would probably saturate the IO channel of the target database server.

<!-- Referenced links -->
[1]: overview.md
[2]: change-tracking.md
[3]: getting-started/i-mirror-client-service.md
[4]: skip-tables.md
[5]: ../../admin/preferences/update.md#edit

<!-- Referenced images -->
[img1]: media/mirroringprinciplessequencediagram.png
[img2]: media/mirror-preferences.png

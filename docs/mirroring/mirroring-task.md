---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_task       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: About the database Mirroring Task # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept             # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
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

![sequence diagram][img1]

## When does the mirroring task run?

The mirroring task is scheduled to run every 20 minutes. However, multiple tasks run in sequence on each customer tenant. If another task takes longer to complete than planned, the mirroring task might be delayed.

We also stop the task completely from 23.00 to 06:00 every night.

Mirroring does not run during server maintenance, such as SuperOffice CRM Online version upgrades.

## Batches

One mirroring batch is equivalent to roughly up to 1 megabyte of data. The number of rows will vary widely depending on the actual size of the rows.

Each batch refers to 1 table, but 1 call to the [IMirrorClientService][3] interface may reference multiple tables using multiple batches.

The SuperOffice CRM Online server will limit the total call size by tracking content size.

Batches can in principle be processed in parallel, but doing so would probably saturate the IO channel of the target database server.

<!-- Referenced links -->
[1]: index.md
[2]: track-changes.md
[3]: i-mirror-client-service.md

<!-- Referenced images -->
[img1]: media/mirroringprinciplessequencediagram.png
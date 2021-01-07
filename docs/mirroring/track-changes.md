---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: mirroring_track_changes       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: SQL Server change tracking # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic: concept               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: cloud           # cloud or onsite
so.client: online               # online, web, win, pocket, or mobile
---

# SQL Server change tracking

The Online customer database uses SQL Server change tracking to manage all tables that are subject to mirroring.

SQL Server change tracking is a **light-weight** mechanism implemented directly in the SQL Server database engine. It uses an incremental 64-bit integer, **Log Sequence Number**.

Using this method, rather than the internal `TravelTransactionLog`, avoids complexity in the following situations:

* UDEF changes
* Merging 2 companies is logged differently from other operations
* Service operations are not logged at all in `TravelTransactionLog`

## How does it work?

1. When change tracking for a table is OFF, it is automatically turned ON by the mirroring system.
2. A  **wipe** message is sent to the client.
3. All records in the table are considered changed and therefore transmitted to the client.

## How long is tracking data kept?

Change tracking data is kept for 7 days.

If a mirroring client service is down for more than a week, change data will be missing and the next synchronization will therefore cause a complete, automatic repopulation of the mirror.

---
title: cached_db_tables
description: Cached database tables
author: {github-id}
keywords: database
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite               # cloud or onsite
so.client: win               # online, web, win, pocket, or mobile
---

# Cached tables

Certain tables are cached on disk by the Windows client. This is to avoid lots of unnecessary database traffic during the SOCRM Windows client startup.

This means that changes in the table in the database may not be visible on the client, even though the database has changed.

To make the change in the database visible, the cache on the disk needs to be invalidated, and the new data read from the database.

The `cachetab` table contains the tables that this caching applies to, and what the current valid checksum for the cached table is.

## To invalidate the cache

* Reset the checksum field to 0.

The next time that a client logs in, the client cache checksum and the cache table checksum in the database won't match, and the disk file will be discarded and a new cache created.

## Location

The table caches are stored in *SOCACHE* folder. This folder is located in one of 2 places:

* Old style: *C:\\WINDOWS\\SOCACHE*, used if the folder exists and is writeable.
* New style: *C:\\Documents and Settings\\username\\Local Settings\\Application Data\\SuperOffice\\SOCache*, used if C:\\WINDOWS\\SOCACHE does not already exist.

> [!NOTE]
> Whole table caching is an issue for the Windows client and COM-based clients when you are updating the database using a raw database connection.

If you use COM objects or the SuperOffice OLE-DB provider, then the `cachetables` checksums are automatically updated.

Early versions of NetServer (\<3.0) do not update the `cachetables` checksums.

## Example

For example, when adding a CATEGORY row using native SQL, you need to do the following:

1. Add a row to the `category` table.
2. Add a row to the travel transaction log.
3. Add a row to the `categorygrouplink` table for each active usergroup.
4. Update the sequence counters for the `category`, `categorygrouplink`, and transaction log tables.
5. Reset the `cachetable` checksum to invalidate the disk cache (because the `category` table and the `categorygrouplink` table are listed in the `cachetables` table).

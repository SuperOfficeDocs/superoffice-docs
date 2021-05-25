---
title: Breaking database change in NetServer
uid: 85_breaking_changes
description: Heads up - Breaking database change in NetServer
author: Marek Vokáč
so-date: 04.16.2019
keywords:
so.topic: generic
so.envir:
so.client:
---

# Heads up: Breaking database change in NetServer

This coming release (new main version, 8.5) will contain the **Tags** functionality in Service. To make tag searching extremely fast, and to enable "all-of" searches, we have used a new way of encoding a many-to-many relation. Instead of having a classical link table that points to `ticket` on one side and a `tags` table on the other, we are collecting the IDs of tags into a single text field in the `ticket` table. Of course, this limits the number of tags you can have on a single ticket, but the upper limit is around 400 and that should be enough.

> [!NOTE]
> 400 is not the max number of distinct tags, but the number of different tags assigned to any *one* ticket.

The tag IDs are encoded into "words", using the letters A-J for digits 0-9 plus a Z for any possible negative signs. By doing this we can leverage the Fulltext Search functionality in SQL Server, which will discover and index these words. The result is a lightning-fast search, in tests, we have seen a 40ms search time to locate a ticket by looking for 4 tags among 10.000.000 rows. There is also an automatic fallback from Fulltext Search if that feature is turned off on SQL Server and our other supported database platforms. This fallback uses the LIKE operator, and while slower, still is useably fast.

To make this nifty encoding transparent to application developers we have extended our CDD universe with a new database column data type: `int[]` (array of integers), and specifically as a new Dictionary data type called **FKArray** (array of foreign keys). By doing this we make the encoding into these funny words invisible to developers, both inside and outside of SuperOffice. Columns declared using this type behave just like you would expect in the code, including being supported by the DotSyntax search engine. All the encoding, decoding, and searching happen down in the basement.

The cost of doing this is that the new database is **incompatible with previous NetServer releases**. *Incompatible* here means that an old NetServer will simply crash on start-up when it meets an upgraded database. This is a tad inelegant and quite possibly we can do better in the future… but right now that is what we have. In Online, we upgrade everything synchronously and expect no problems; there are no breaking changes in the service layer.

Onsite installations need some care: any partner integrations that **have their own NetServers** need to be recompiled with the new one, and be upgraded at the same time as the database is upgraded. Integrations that call the service layer are in the same position as apps in CRM Online, as long as the NetServer they're calling has been upgraded, the apps will work.

Database Mirroring is not technically affected. Mirroring looks at the database at a purely physical level, and simply sees a new NVARCHAR(4000) field that is created and replicated. Interpreting the content of this field is another matter. Hopefully, you don't need to do that, but we will publish the format and code to do so.

The error message you see in the NetServer log if you run an old NetServer against a new database looks like this:

```text
Element:
Message: Failed to load dictionary; often caused by wrong table prefix
Type: SuperOffice.Exceptions.SoDbAccessException

...

Inner Element:
Message: Exception of type 'System.ArgumentOutOfRangeException' was thrown.
Parameter name: type
Actual value was 22.
Type: System.ArgumentOutOfRangeException
```

Please use the [Continuous Database forum][1] to communicate any **questions or concerns** you may have about this change.

<!-- Referenced links -->
[1]: https://community.superoffice.com/en/Developer/Forum/Rooms/superoffice-product-api-group/continuous-database-development/

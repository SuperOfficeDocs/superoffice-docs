---
title: Attachments
description: Attachments
author: {github-id}
keywords:
so.date:
so.topic: concept
so.envir: onsite
---

# Attachments

## Splitting SuperOffice Service attachments to multiple locations

In 8.5 R09 (Onsite) we introduced a new table to support the possibility for splitting attachments in Service over multiple locations.

Before introducing this table, the location of attachment was specified in `config.attachment_path`. In versions after 8.5 R09, this is no longer used, but replaced with `attachment_location` table. This table can contain 1 or more rows. The last row is considered by the application as "current" path. We also introduced a new field on the attachment table pointing to which row in `attachment_location` particular attachment is connected to.

* [Update location (when moving Service)][1]
* [][2]

<!-- Referenced links-->
[1]: update-location.md
[2]: split-location.md

---
uid: attachment-split-loc
title: Split attachment location
description: Splitting SuperOffice Service attachments to multiple locations
author: Bergfrid Dias
date: 03.16.2023
keywords: attachment, request
topic: howto
audience: settings
envir: onsite
# client:
---

# Splitting attachment location

In 8.5 R09 (Onsite) we introduced a new table to support the possibility for splitting attachments in Service over multiple locations.

Before introducing this table, the location of attachment was specified in `config.attachment_path`. In versions after 8.5 R09, this is no longer used, but replaced with `attachment_location` table. This table can contain 1 or more rows. The last row is considered by the application as "current" path. We also introduced a new field on the attachment table pointing to which row in `attachment_location` particular attachment is connected to.

This is a more complex procedure and we do not offer any GUI for this but must be performed in SQL by adding a new row into `attachment_location`. Since this row is added, all new attachments will be stored in the new location.

> [!NOTE]
> If you need to move attachments from one location to another this is even more complex as it would also require you to update the attachment table and so on. Do not recommend doing this without a consultant.

Example of insert:

```SQL
USE [SuperOffice]

GO

declare @pdid int

DECLARE @path varchar(199)

SET @path = 'E:\SuperOffice\SO_CS\attachments'

begin transaction

update crm8.SEQUENCE set next_id = next_id +1 where tablename = 'ATTACHMENT_LOCATION'

select @pdid = next_id - 1 from crm8.SEQUENCE where tablename = 'ATTACHMENT_LOCATION'

insert into crm8.ATTACHMENT_LOCATION values (@pdid, @path, getdate(), 0, getdate(), 0, 0)

commit transaction
```

See also [how to update a location][1].

<!-- Referenced links-->
[1]: update-attachment-location.md

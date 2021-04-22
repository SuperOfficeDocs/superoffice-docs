---
title: Split locations 
uid: split_attachment_locations
description: Splitting SuperOffice Service attachments to multiple locations
author: {github-id}
keywords:
so.topic: howto
so.envir: onsite
# so.client: 
---

# Splitting attachment locations

This is a more complex procedure and we do not offer any GUI for this but must be performed in SQL by adding a new row into `attachment_location`.

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
[1]: update-location.md

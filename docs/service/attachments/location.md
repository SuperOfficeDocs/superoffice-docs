---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: attachment_location       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Splitting SuperOffice Service attachments to multiple locations # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords:
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir: onsite             # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Splitting SuperOffice Service attachments to multiple locations

In 8.5 R09 (Onsite) we introduced a new table to support the possibility for splitting attachments in Service over multiple locations.

Before introducing this table, the ocation of attachment was specified in `config.attachment_path`. In versions after 8.5 R09, this is no longer used, but replaced with `attachment_location` table. This table can contain 1 or more rows. Last row is considered by the application as "current" path. We also introduced a new field on the attachment table pointing to which row in `attachment_location` particular attachment is connected to.

## Moving Service

If moving Service and the attachment location has changed, you need to update the last row in `attachment_location` to point to the new path, for example:

```text
USE [SuperOffice]

GO

DECLARE @path varchar(199)

SET @path = 'E:\SuperOffice\SO_CS\attachments'

UPDATE [crm8].[ATTACHMENT_LOCATION]

   SET [path] = @path

      ,[updated] = getdate()

      ,[updatedCount] = updatedCount+1

WHERE attachment_location_id = (select max(attachment_location_id) from crm8.ATTACHMENT_LOCATION)
```

## Splitting attachment locations

This is a more complex procedure and we do not offer any GUI for this but must be performed in SQL by adding a new row into `attachment_location`.

> [!NOTE]
> If you need to move attachments from one location to another this is even more complex as it would also require you to update the attachment table and so on. Do not recommend doing this without a consultant.

Example of insert:

```text
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

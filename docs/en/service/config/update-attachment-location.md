---
uid: attachment-update-loc
title: Update location
description: Update location when moving Service
author: Bergfrid Dias
date: 03.16.2023
keywords: attachment, request
topic: howto
audience: settings
envir: onsite
---

# Update attachment location when moving Requests

If moving Requests and the attachment location has changed, you need to update the last row in `attachment_location` to point to the new path, for example:

```SQL
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

See also [how to split location][1].

<!-- Referenced links-->
[1]: split-attachment-location.md

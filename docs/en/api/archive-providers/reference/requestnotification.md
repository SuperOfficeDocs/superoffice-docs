---
uid: RequestNotification
title: RequestNotification
description: 
keywords: RequestNotification archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "RequestNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.RequestNotificationProvider">SuperOffice.CRM.ArchiveLists.RequestNotificationProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticketNew"|Request|
|"ticketNewMessage"|Request|
|"ticketEscalated"|Request|
|"ticketActivated"|Request|
|"ticketTransferred"|Request|
|"ticketCustomMessage"|Request|
|"ticketFavouriteUpdated"|Request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* |!!id| x |
|associateId|associate|Associate: SR\_SINGULAR\_ASSOCIATE\_TOOLTIP| x |
|originatorFullName| *None* |!!originatorFullName|  |
|notifyDateTime|datetime|!!notifyDateTime| x |
|title| *None* |!!title|  |
|updateType| *None* |!!updateType|  |
|ticketId| *None* |!!ticketId| x |
|category| *None* |!!category| x |
|customUrl| *None* |!!customUrl| x |

## Sample

```http!
GET /api/v1/archive/RequestNotification?$select=associateId,notifyDateTime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


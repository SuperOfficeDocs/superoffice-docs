---
uid: TicketCustomMessageNotification
title: TicketCustomMessageNotification
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "TicketCustomMessageNotification"
so.generated: true
so.date: 03.01.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "TicketCustomMessageNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketCustomMessageNotificationSubProvider">SuperOffice.CRM.ArchiveLists.TicketCustomMessageNotificationSubProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticketCustomMessage"|Request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* |!!id| x |
|associateId|associate|Associate: SR\_SINGULAR\_ASSOCIATE\_TOOLTIP| x |
|originatorFullName| *None* |!!originatorFullName|  |
|receiverFullName| *None* |!!receiverFullName|  |
|notifyDateTime|datetime|!!notifyDateTime| x |
|title| *None* |!!title|  |
|updateType| *None* |!!updateType|  |
|ticketId| *None* |!!ticketId| x |

## Sample

```http!
GET /api/v1/archive/TicketCustomMessageNotification?$select=associateId,receiverFullName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

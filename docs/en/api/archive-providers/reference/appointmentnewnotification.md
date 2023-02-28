---
uid: AppointmentNewNotification
title: AppointmentNewNotification
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "AppointmentNewNotification"
so.generated: true
so.date: 02.15.2023
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "AppointmentNewNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationSubProvider">SuperOffice.CRM.ArchiveLists.AppointmentNewNotificationSubProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointmentNew"|Appointment|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* |!!id| x |
|associateId|associate|Associate: SR\_SINGULAR\_ASSOCIATE\_TOOLTIP| x |
|originatorFullName|associate|!!originatorFullName - Full name: !!originatorFullName| x |
|receiverFullName|associate|!!receiverFullName - Full name: !!receiverFullName| x |
|notifyDateTime|datetime|!!notifyDateTime| x |
|title| *None* |!!title|  |
|updateType| *None* |!!updateType|  |
|startDateTime| *None* |!!startDateTime| x |
|endDateTime| *None* |!!endDateTime|  |
|location| *None* |!!location|  |
|isRecurring| *None* |!!isRecurring|  |
|isEmailInvitation| *None* |!!isEmailInvitation|  |
|isSeen| *None* |!!isSeen|  |
|recurringStartDateTime| *None* |!!recurringStartDate| x |
|recurringEndDateTime| *None* |!!recurringEndDate| x |

## Sample

```http!
GET /api/v1/archive/AppointmentNewNotification?$select=notifyDateTime,receiverFullName,updateType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

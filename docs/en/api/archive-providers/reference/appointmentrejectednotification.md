---
uid: AppointmentRejectedNotification
title: AppointmentRejectedNotification
description: 
keywords: AppointmentRejectedNotification archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "AppointmentRejectedNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationSubProvider">SuperOffice.CRM.ArchiveLists.AppointmentRejectedNotificationSubProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointmentRejected"|Appointment|

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
|startDateTime| *None* |!!startDateTime| x |
|endDateTime| *None* |!!endDateTime|  |
|location| *None* |!!location|  |
|isRecurring| *None* |!!isRecurring|  |
|isEmailInvitation| *None* |!!isEmailInvitation|  |
|invitedPersonId| *None* |!!invitedPersonId| x |
|isSeen| *None* |!!isSeen|  |
|hasConflict| *None* |!!hasConflict|  |
|recurrencePattern| *None* |!!recurrencePattern| x |
|rejectReason| *None* |!!rejectReason| x |
|isAssignment| *None* |!!isAssignment|  |

## Sample

```http!
GET /api/v1/archive/AppointmentRejectedNotification?$select=title,endDateTime
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


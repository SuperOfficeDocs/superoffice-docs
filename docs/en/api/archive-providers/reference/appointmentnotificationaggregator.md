---
uid: AppointmentNotificationAggregator
title: AppointmentNotificationAggregator
description: 
keywords: AppointmentNotificationAggregator archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "AppointmentNotificationAggregator"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider">SuperOffice.CRM.ArchiveLists.AppointmentNotificationAggregatorProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointmentNew"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentUpdated"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentCancelled"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentAccepted"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentRejected"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentRejectedByAssociate"|[[SR_COMMON_APPOINTMENT]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|id| *None* |!!id| x |
|associateId|associate|SR\_SINGULAR\_ASSOCIATE: SR\_SINGULAR\_ASSOCIATE\_TOOLTIP| x |
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
|isFree| *None* |!!isFree: bool| x |
|isSystemUserAssignment| *None* |!!isSystemUserAssignment: bool| x |

## Sample

```http!
GET /api/v1/archive/AppointmentNotificationAggregator?$select=updateType,location
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


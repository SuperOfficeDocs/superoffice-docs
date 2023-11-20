---
uid: Notification
title: Notification
description: 
keywords: Notification archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "Notification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.NotificationProvider">SuperOffice.CRM.ArchiveLists.NotificationProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointmentNew"|Appointment|
|"appointmentUpdated"|Appointment|
|"appointmentCancelled"|Appointment|
|"appointmentAccepted"|Appointment|
|"appointmentRejected"|Appointment|
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
|startDateTime| *None* |!!startDateTime|  |
|endDateTime| *None* |!!endDateTime|  |
|location| *None* |!!location|  |
|isRecurring| *None* |!!isRecurring|  |
|isEmailInvitation| *None* |!!isEmailInvitation|  |
|invitedPersonId| *None* |!!invitedPersonId|  |
|isSeen| *None* |!!isSeen|  |
|hasConflict| *None* |!!hasConflict|  |
|recurrencePattern| *None* |!!recurrencePattern|  |
|rejectReason| *None* |!!rejectReason|  |
|isAssignment| *None* |!!isAssignment|  |
|ticketId| *None* |!!ticketId|  |
|category| *None* |!!category|  |
|customUrl| *None* |!!customUrl|  |

## Sample

```http!
GET /api/v1/archive/Notification?$select=isSeen,updateType,isRecurring
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


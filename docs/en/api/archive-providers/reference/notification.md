---
uid: Notification
title: Notification
description: 
keywords: Notification archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Notification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.NotificationProvider">SuperOffice.CRM.ArchiveLists.NotificationProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"appointmentNew"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentUpdated"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentCancelled"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentAccepted"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentRejected"|[[SR_COMMON_APPOINTMENT]]|
|"appointmentRejectedByAssociate"|[[SR_COMMON_APPOINTMENT]]|
|"ticketNew"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketNewMessage"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketEscalated"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketActivated"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketTransferred"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketCustomMessage"|[[SR_CRITERIONTYPE_TICKET]]|
|"ticketFavouriteUpdated"|[[SR_CRITERIONTYPE_TICKET]]|
|"assignmentCompany"|!!Company assignment|
|"assignmentPerson"|!!Person assignment|

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
|isFree| *None* |!!isFree: bool|  |
|isSystemUserAssignment| *None* |!!isSystemUserAssignment: bool|  |
|ticketId| *None* |!!ticketId|  |
|category| *None* |!!category|  |
|customUrl| *None* |!!customUrl|  |
|type| *None* |SR\_ARCHIVE\_TICKETNOTIFICATION\_TYPE: SR\_ARCHIVE\_TICKETNOTIFICATION\_TYPE\_TOOLTIP|  |
|ownerContactId| *None* |SR\_ARCHIVE\_TICKETNOTIFICATION\_OWNERASSOCIATEID: SR\_ARCHIVE\_TICKETNOTIFICATION\_OWNERASSOCIATEID\_TOOLTIP|  |
|updatedAssocId| *None* |SR\_PROJECTARCHIVE\_LASTUPDATED\_BY: SR\_PROJECTARCHIVE\_LASTUPDATED\_BY\_TOOLTIP|  |
|companyName| *None* |!!Company name: !!Company name tooltip|  |
|personFirstName| *None* |!!Person first name: !!Person name tooltip|  |
|personMiddleName| *None* |!!Person middle name: !!Person middle name tooltip|  |
|personLastName| *None* |!!Person last name: !!Person last name tooltip|  |
|personFullName| *None* |!!Person full name: !!Person full name tooltip|  |
|personId| *None* |!!Person id: !!Person id tooltip|  |

## Sample

```http!
GET /api/v1/archive/Notification?$select=startDateTime,isRecurring,recurrencePattern
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


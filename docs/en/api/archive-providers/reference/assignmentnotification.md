---
uid: AssignmentNotification
title: AssignmentNotification
description: 
keywords: AssignmentNotification archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "AssignmentNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AssignmentNotificationProvider">SuperOffice.CRM.ArchiveLists.AssignmentNotificationProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"assignmentCompany"|!!Company assignment|
|"assignmentPerson"|!!Person assignment|

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
|type|int|Type: The type of notification|  |
|ownerContactId| *None* |Owner associate ID: The associate ID of the user who is the original owner of the notification|  |
|updatedAssocId| *None* |Updated by: Displays the name of the associate who last updated the project|  |
|companyName| *None* |!!Company name: !!Company name tooltip|  |
|personFirstName| *None* |!!Person first name: !!Person name tooltip|  |
|personMiddleName| *None* |!!Person middle name: !!Person middle name tooltip|  |
|personLastName| *None* |!!Person last name: !!Person last name tooltip|  |
|personFullName| *None* |!!Person full name: !!Person full name tooltip|  |
|personId| *None* |!!Person id: !!Person id tooltip|  |

## Sample

```http!
GET /api/v1/archive/AssignmentNotification?$select=notifyDateTime,type
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


---
uid: TicketNotification
title: TicketNotification
description: Retrieves pending request notifications for current user
keywords: TicketNotification archive provider
so.generated: true
so.topic: reference
so.envir: onsite, online
---

# "TicketNotification"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketNotificationProvider">SuperOffice.CRM.ArchiveLists.TicketNotificationProvider</see> inside NetServer's SODatabase assembly.

Retrieves pending request notifications for current user

## Supported Entities
| Name | Description |
| ---- | ----- |
|"notification"|Notifications|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|notifyId|int|Notification ID: Primary key for notification| x |
|ejUserId|ejUser|User ID: EjUserId of the user to be notified| x |
|userAssociateId| *None* |User's associate ID: Associate ID of the user to be notified|  |
|userFullname| *None* |User name: Name of the user to be notified|  |
|userContactName| *None* |User's company: The name of the company of the user to be notified|  |
|type|int|Type: The type of notification| x |
|ownerEjUserId|ejUser|Owner's EjUserId: The EjUserId of the user who is the original owner of the notification| x |
|ownerAssociateId| *None* |Owner associate ID: The associate ID of the user who is the original owner of the notification|  |
|ownerFullname| *None* |Owner name: Name of the user who is the original owner of the notification|  |
|ownerContactName| *None* |Owner company: Name of the company of the user who is the original owner of the notification|  |
|customMessage|string|Message: Custom message for the notification| x |
|expires|datetime|Expires: Time when the notification expires| x |
|ticketId|int|Request ID: ID of the request that this notification concerns| x |
|ticketTitle|string|Request title: The title of the request that this notification concerns| x |
|categoryId|int|Category ID: Category ID for the request| x |
|categoryName|listAny|Category name: Name of request category|  |
|ticketAlertId|int|Alert ID: The ID of the request alert| x |
|ticketAlertLevel|listAny|Alert level: The request alert level when the request is escalated|  |
|priorityId| *None* |Priority ID: The priority ID of the request alert|  |
|priorityName| *None* |Priority name: The priority name of the request alert|  |
|ejUser2Id|ejUser|EjUserId User 2: EjUserId of a second user involved in this notification| x |
|user2AssociateId| *None* |Associate ID User 2: Associate ID of a second user involved in this notification|  |
|user2Fullname| *None* |Name User 2: Name of a second user involved in this notification|  |
|user2ContactName| *None* |Company User 2: Company of a second user involved in this notification|  |
|chatTopicId|int|Chat topic ID: Topic identifier for chat entry| x |

## Sample

```http!
GET /api/v1/archive/TicketNotification?$select=userAssociateId,ownerAssociateId,expires
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


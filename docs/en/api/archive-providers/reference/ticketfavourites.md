---
uid: ticketfavourites
title: ticketfavourites
description: 
keywords: ticketfavourites archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ticketfavourites"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.TicketFavouritesProvider">SuperOffice.CRM.ArchiveLists.TicketFavouritesProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ticket"|Favourite request|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|contactId|int|Company ID: Database ID of company| x |
|personId|int|Contact ID: Database ID of the contact row| x |
|saleId|int|Sale ID: The database ID of the sale record| x |
|projectId|int|Project ID: Database ID of project record| x |
|ticketStatusId|int|Status ID: Status| x |
|priorityId|int|Priority ID: ID of priority in database| x |
|categoryId|int|Category ID: ID of ticket category in database| x |
|ticketTypeName|listAny|Request type: Request type| x |
|ticketStatusName|listAny|Status: Request status| x |
|categoryFullName|ejCategory|Category: Request category| x |
|priorityName|listAny|Priority: Service priority| x |
|ownedBy|ejUser|Owner: The owner of the request| x |
|ticketId|int|ID: Displays request ID| x |
|title|string|Title: Displays the request title| x |
|createdAt|datetime|Created: Displays when the request was created| x |
|lastChanged|datetime|Last changed: Displays when the request was last changed| x |
|author|string|Author: Displays the author of the request| x |
|readByOwner|datetime|Read by owner: Displays when the request was read by the owner| x |
|firstReadByOwner|datetime|First read by owner: Displays when the request was read by owner for the first time| x |
|firstReadByUser|datetime|First read by user: Displays when the request was read by user for the first time| x |
|readByCustomer|datetime|Read by contact: Displays when the request was read by the contact| x |
|status|listAny|Internal status: Shows only system defined statuses for a request| x |
|origin|listAny|Origin: Origin| x |
|slevel|listAny|Access level: Access level| x |
|numberOfMessages|int|Number of messages: Number of messages| x |
|numberOfReplies|int|Number of replies: Number of replies| x |
|connectId|int|Merged with request: Merged with request| x |
|readStatus|listAny|Read: Read| x |
|realTimeSpentQueue|timeSpan|Real time in queue: Real time in queue| x |
|realTimeSpentExternally|timeSpan|Real time externally: Real time externally| x |
|realTimeSpentInternally|timeSpan|Real time internally: Real time internally| x |
|timeSpentQueue|timeSpan|Time spent in queue: Time spent in queue| x |
|timeSpentExternally|timeSpan|Time spent externally: Time spent externally| x |
|timeSpentInternally|timeSpan|Time spent internally: Time spent internally| x |
|timeSpent|timeSpan|Time spent: Time spent| x |
|timeToReply|timeSpan|Time to reply: Time to reply| x |
|timeToClose|timeSpan|Time to close: Time to close| x |
|realTimeToReply|timeSpan|Real time to reply: Real time to reply| x |
|realTimeToClose|timeSpan|Real time to close: Real time to close| x |
|repliedAt|datetime|Replied at: Replied at| x |
|closedAt|datetime|Closed at: Closed at| x |
|activated|datetime|Postponed to: Postponed to| x |
|deadline|datetime|Deadline: Deadline| x |
|has\_attachment|bool|Has attachment: Indicates whether the e-mail has one or more attachments| x |
|tags|intArray|Tags: Tags connected to a request| x |
|createdBy|ejUser|Created by: Created by| x |
|content|string|Content: Search for content in messages related to requests| x |
|messageLanguage|listAny|Language: Recognized language in messages|  |
|sentimentScore|listAny|Sentiment: Sentiment score, -100 to +100|  |
|sentimentConfidence|int|Sentiment confidence: Sentiment confidence| x |
|suggestedCategory|listAny|Suggested category: Suggested service category|  |
|createdByWorkflow|listAny|Created by flow: Created by flow| x |
|entityIcon| *None* |Row specific icon: Row specific icon| x |
|icon| *None* |Category: Displays the icon for an activity type| x |
|text|positiveString|Favourite: Displays a descriptive text for the item| x |
|favouriteAssociateId|associate|ID: Displays the login ID of the associate who owns the activity.| x |
|createdBy/firstName|string|Created by - First name: Displays the contact's first name| x |
|createdBy/lastName|string|Created by - Last name: Displays the contact's last name| x |
|createdBy/middleName|string|Created by - Middle Name: Displays the contact's middle name.| x |
|createdBy/fullName|string|Created by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|createdBy/contactId|int|Created by - Company ID: Database ID of the company the user belongs to|  |
|createdBy/personId|int|Created by - Contact ID: Database ID of the contact row|  |
|createdBy/mrMrs|string|Created by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|createdBy/title|string|Created by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|createdBy/associateDbId|associate|Created by - ID| x |
|createdBy/contactName|string|Created by - Owning company: Name of the company the user belongs to| x |
|createdBy/contactDepartment|string|Created by - Owning department: Name of the department at the company the user belongs to| x |
|createdBy/usergroup|userGroup|Created by - Primary group: The user's primary user group| x |
|createdBy/usergroupId|int|Created by - Group ID: The user's primary user group| x |
|createdBy/contactFullName|string|Created by - Owner: Name and department of the company the user belongs to| x |
|createdBy/contactCategory|listAny|Created by - Category: Category| x |
|createdBy/role|listAny|Created by - Role: Role| x |
|createdBy/assocName|associate|Created by - User ID: User ID| x |
|createdBy/assocTooltip|string|Created by - Description: Description|  |
|createdBy/assocType|listAny|Created by - Type: Type of user: associate, external user, system user, anonymous account| x |
|createdBy/ejUserId|int|Created by - Service user ID: The database ID of a Service user|  |
|createdBy/simultaneousEjUser|bool|Created by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|createdBy/ejDisplayName|string|Created by - Nickname: User's nickname in Service| x |
|createdBy/ejStatus|int|Created by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|createdBy/credentialType| *None* |Created by - Auth. type: What type of credentials to use when this user logs in| x |
|createdBy/credentialDisplayValue| *None* |Created by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|createdBy/isActive|bool|Created by - Active: Is this user active, and should be able to log in?| x |
|createdBy/isActiveText|bool|Created by - Active status: Is this user active, and should be able to log in?| x |
|createdBy/portraitThumbnail| *None* |Created by - Person image: Person image|  |
|createdBy/otherGroups|userGroup|Created by - Other groups: Other groups|  |
|createdBy/userName|string|Created by - User name: User name| x |
|createdBy/personEmail|string|Created by - E-mail| x |
|createdBy/locationAddress|string|Created by - Location: Location| x |
|createdBy/isLocation|bool|Created by - Is a location: Is a location| x |
|ownedBy/firstName|string|Owner - First name: Displays the contact's first name| x |
|ownedBy/lastName|string|Owner - Last name: Displays the contact's last name| x |
|ownedBy/middleName|string|Owner - Middle Name: Displays the contact's middle name.| x |
|ownedBy/fullName|string|Owner - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|ownedBy/contactId|int|Owner - Company ID: Database ID of the company the user belongs to|  |
|ownedBy/personId|int|Owner - Contact ID: Database ID of the contact row|  |
|ownedBy/mrMrs|string|Owner - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|ownedBy/title|string|Owner - Title: Displays whether the contact is addressed as Mr or Ms| x |

## Supported Columns (cont.)
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|ownedBy/associateDbId|associate|Owner - ID| x |
|ownedBy/contactName|string|Owner - Owning company: Name of the company the user belongs to| x |
|ownedBy/contactDepartment|string|Owner - Owning department: Name of the department at the company the user belongs to| x |
|ownedBy/usergroup|userGroup|Owner - Primary group: The user's primary user group| x |
|ownedBy/usergroupId|int|Owner - Group ID: The user's primary user group| x |
|ownedBy/contactFullName|string|Owner - Owner: Name and department of the company the user belongs to| x |
|ownedBy/contactCategory|listAny|Owner - Category: Category| x |
|ownedBy/role|listAny|Owner - Role: Role| x |
|ownedBy/assocName|associate|Owner - User ID: User ID| x |
|ownedBy/assocTooltip|string|Owner - Description: Description|  |
|ownedBy/assocType|listAny|Owner - Type: Type of user: associate, external user, system user, anonymous account| x |
|ownedBy/ejUserId|int|Owner - Service user ID: The database ID of a Service user|  |
|ownedBy/simultaneousEjUser|bool|Owner - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ownedBy/ejDisplayName|string|Owner - Nickname: User's nickname in Service| x |
|ownedBy/ejStatus|int|Owner - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|ownedBy/credentialType| *None* |Owner - Auth. type: What type of credentials to use when this user logs in| x |
|ownedBy/credentialDisplayValue| *None* |Owner - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|ownedBy/isActive|bool|Owner - Active: Is this user active, and should be able to log in?| x |
|ownedBy/isActiveText|bool|Owner - Active status: Is this user active, and should be able to log in?| x |
|ownedBy/portraitThumbnail| *None* |Owner - Person image: Person image|  |
|ownedBy/otherGroups|userGroup|Owner - Other groups: Other groups|  |
|ownedBy/userName|string|Owner - User name: User name| x |
|ownedBy/personEmail|string|Owner - E-mail| x |
|ownedBy/locationAddress|string|Owner - Location: Location| x |
|ownedBy/isLocation|bool|Owner - Is a location: Is a location| x |
|ticketStatus/ticketStatusId|int|Status - ID: Displays request status ID| x |
|ticketStatus/name|string|Status - Name: Displays the name of the request status| x |
|ticketStatus/rank|int|Status - Status rank: Sort order of the status in the ticket status list| x |
|ticketPriority/ticketPriorityId|int|Priority - ID: Displays the ID of the priority| x |
|ticketPriority/name|string|Priority - Name: Displays the name of the priority| x |
|ticketPriority/rank|int|Priority - Priority rank: Sort order of priority in the priority list| x |
|extra/x\_ticket\_integer|int|Extra integer: Custom ticket integer. Default 123. External. Show in properties| x |
|extra/x\_ticket\_float|decimal|Extra float: Custom float on Request. 2 decimal places| x |
|extra/x\_ticket\_longtext|string|Extra long text: Custom long text on Request. Keep HTML tags. 9 line text area. Show in props| x |
|extra/x\_ticket\_date|date|Extra date: Custom date field on Request. No default value| x |
|extra/x\_ticket\_datetime|datetime|Extra DateTime: Custom date+time on ticket. Default = 28.03.2019 2:24 pm. External. Show in properties. Display for new request| x |
|extra/x\_ticket\_time| *None* |Extra time: Custom time field on Request. Default = 13min Display for new.| x |
|extra/x\_ticket\_boolean|bool|Extra boolean: Custom boolean on Ticket.| x |
|extra/x\_ticket\_timespan|timeSpan|Extra timespan: Custom timespan field on Request. Default = 1 hr 25 minutes. Show in props| x |
|extra/x\_ticket\_short\_text|string|Extra short text: Custom short text field on Request. Do not keep HTML tags. Display on new request| x |
|extra/x\_ticket\_shorttext\_list|listAny|Extra Dropdown: Custom short text with list for Request Pink, Orange, Yellow, Polkadot| x |
|extra/x\_ticket\_timestamp|datetime|Extra timestamp: Custom date time field on ticket with default = current date + time. Field cannot change. Hide field| x |
|extra/x\_ticket\_project\_relation|stringorPK|Extra project: Custom project relation on Request| x |
|extra/x\_ticket\_faq|stringorPK|Extra FAQ Relation: Extra FAQ Relation| x |
|extra/x\_ticket\_category\_relation|listAny|Extra category relation: Category relation on request| x |
|extra/y\_equipment/x\_name|string|Equipment - Name: Equpment name custom field. Cannot be null., show in table| x |
|extra/y\_car/id|int|Car - id: Displays the row's primary key (y\_car)| x |

## Sample

```http!
GET /api/v1/archive/ticketfavourites?$select=extra/x_ticket_short_text,content,createdBy/role
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


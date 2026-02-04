---
uid: SystemEvents
title: SystemEvents
description: Provider base for system events.
keywords: SystemEvents archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "SystemEvents"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SystemEventsProviderBase">SuperOffice.CRM.ArchiveLists.SystemEventsProviderBase</see> inside NetServer's SODatabase assembly.

Provider base for system events.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"systemevent"|systemevent|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|SystemEvent\_id|int|ID: Primary key| x |
|scope|int|Scope: Scope of system event| x |
|type|string|Type: Type of system event| x |
|owner|int|Owner: The owner of this system event| x |
|eventkey|string|Key: Identifier| x |
|eventname|string|Event: Name of system event| x |
|status|string|Status: Status of the event| x |
|eventmess|string|Message: Message to display if this event occurs| x |
|extrainfo|int|Extra Info: Extra information| x |
|eta|datetime|Finished: Expected finish| x |
|registered|date|Activated: When the event was registered| x |
|updatedCount|int|Updated count: Number updated| x |
|registered\_associate\_id/firstName|string|Activated by - First name: Displays the contact's first name| x |
|registered\_associate\_id/lastName|string|Activated by - Last name: Displays the contact's last name| x |
|registered\_associate\_id/middleName|string|Activated by - Middle Name: Displays the contact's middle name.| x |
|registered\_associate\_id/fullName|string|Activated by - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|registered\_associate\_id/contactId|int|Activated by - Company ID: Database ID of the company the user belongs to|  |
|registered\_associate\_id/personId|int|Activated by - Contact ID: Database ID of the contact row|  |
|registered\_associate\_id/mrMrs|string|Activated by - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|registered\_associate\_id/title|string|Activated by - Title: Displays whether the contact is addressed as Mr or Ms| x |
|registered\_associate\_id/associateDbId|associate|Activated by - ID| x |
|registered\_associate\_id/contactName|string|Activated by - Owning company: Name of the company the user belongs to| x |
|registered\_associate\_id/contactDepartment|string|Activated by - Owning department: Name of the department at the company the user belongs to| x |
|registered\_associate\_id/usergroup|userGroup|Activated by - Primary group: The user's primary user group| x |
|registered\_associate\_id/usergroupId|int|Activated by - Group ID: The user's primary user group| x |
|registered\_associate\_id/contactFullName|string|Activated by - Owner: Name and department of the company the user belongs to| x |
|registered\_associate\_id/contactCategory|listAny|Activated by - Category: Category| x |
|registered\_associate\_id/role|listAny|Activated by - Role: Role| x |
|registered\_associate\_id/assocName|associate|Activated by - User ID: User ID| x |
|registered\_associate\_id/assocTooltip|string|Activated by - Description: Description|  |
|registered\_associate\_id/assocType|listAny|Activated by - Type: Type of user: associate, external user, system user, anonymous account| x |
|registered\_associate\_id/ejUserId|int|Activated by - Service user ID: The database ID of a Service user|  |
|registered\_associate\_id/simultaneousEjUser|bool|Activated by - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|registered\_associate\_id/ejDisplayName|string|Activated by - Nickname: User's nickname in Service| x |
|registered\_associate\_id/ejStatus|int|Activated by - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|registered\_associate\_id/credentialType| *None* |Activated by - Auth. type: What type of credentials to use when this user logs in| x |
|registered\_associate\_id/credentialDisplayValue| *None* |Activated by - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|registered\_associate\_id/isActive|bool|Activated by - Active: Is this user active, and should be able to log in?| x |
|registered\_associate\_id/isActiveText|bool|Activated by - Active status: Is this user active, and should be able to log in?| x |
|registered\_associate\_id/portraitThumbnail| *None* |Activated by - Person image: Person image|  |
|registered\_associate\_id/otherGroups|userGroup|Activated by - Other groups: Other groups|  |
|registered\_associate\_id/userName|string|Activated by - User name: User name| x |
|registered\_associate\_id/personEmail|string|Activated by - E-mail| x |
|registered\_associate\_id/locationAddress|string|Activated by - Location: Location| x |
|registered\_associate\_id/isLocation|bool|Activated by - Is a location: Is a location| x |

## Sample

```http!
GET /api/v1/archive/SystemEvents?$select=registered_associate_id/lastName,registered_associate_id/contactName
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


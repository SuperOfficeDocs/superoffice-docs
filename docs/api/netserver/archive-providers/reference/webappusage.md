---
uid: WebAppUsage
title: WebAppUsage
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "WebAppUsage"
so.generated: true
so.date: 03.23.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "WebAppUsage"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.WebAppUsageProvider">SuperOffice.CRM.ArchiveLists.WebAppUsageProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"webAppUsage"|[webAppUsage]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|webAppUsage\_id|int|DB Id: Db Id of WebAppUsage row| x |
|version|int|Version: Client version| x |
|timeStamp|date|Date: Day when event was registered and counted| x |
|assocId|associate|ID| x |
|viewState|string|Event: Event registered and counted on this day| x |
|aggregateBin|int|Bin: No idea what this is for!| x |
|aggregateCount|int|Count: Number of times this event was triggered on this day| x |
|fileVersion| *None* |File version: Decoded Build info of client version number as Revision.Build|  |
|associate/firstName|string|Associate - First name: Displays the contact's first name| x |
|associate/lastName|string|Associate - Last name: Displays the contact's last name| x |
|associate/middleName|string|Associate - Middle Name: Displays the contact's middle name.| x |
|associate/fullName|string|Associate - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|associate/contactId|int|Associate - Company ID: Database ID of the company the user belongs to|  |
|associate/personId|int|Associate - Contact ID: Database ID of the contact row|  |
|associate/mrMrs|string|Associate - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|associate/title|string|Associate - Title: Displays whether the contact is addressed as Mr or Ms| x |
|associate/associateDbId|associate|Associate - ID| x |
|associate/contactName|string|Associate - Owning company: Name of the company the user belongs to| x |
|associate/contactDepartment|string|Associate - Owning department: Name of the department at the company the user belongs to| x |
|associate/usergroup|userGroup|Associate - Primary group: The user's primary user group| x |
|associate/contactFullName|string|Associate - Owner: Name and department of the company the user belongs to| x |
|associate/contactCategory|listAny|Associate - Category: Category| x |
|associate/role|listAny|Associate - Role: Role| x |
|associate/assocName|associate|Associate - User ID: User ID| x |
|associate/assocTooltip|string|Associate - Description: Description|  |
|associate/assocType|listAny|Associate - Type: Type of user: associate, external user, system user, anonymous account| x |
|associate/ejUserId|int|Associate - Service user ID: The database ID of a Service user|  |
|associate/simultaneousEjUser|bool|Associate - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|associate/ejDisplayName|string|Associate - Nick name: User's nick name in Service| x |
|associate/ejStatus|int|Associate - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|associate/credentialType| *None* |Associate - Auth. type: What type of credentials to use when this user logs in| x |
|associate/credentialDisplayValue| *None* |Associate - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|associate/isActive|bool|Associate - Active: Is this user active, and should be able to log in?| x |
|associate/isActiveText|bool|Associate - Active status: Is this user active, and should be able to log in?| x |
|associate/portraitThumbnail| *None* |Associate - Person image: Person image|  |
|associate/otherGroups|userGroup|Associate - Other groups: Other groups|  |
|associate/userName|string|Associate - User name: User name| x |
|associate/personEmail|string|Associate - E-mail| x |

## Sample

```http!
GET /api/v1/archive/WebAppUsage?$select=associate/mrMrs,associate/fullName,associate/contactDepartment
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


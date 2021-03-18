---
uid: SuperListColumnSize
title: SuperListColumnSize
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 18.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "SuperListColumnSize"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.SuperListColumnSizeProvider">SuperOffice.CRM.ArchiveLists.SuperListColumnSizeProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"superListColumnSize"|[superListColumnSize]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|superListColumnSize\_id|int|DB Id: Db Id of SuperListColumnSize row| x |
|assocId|associate|ID| x |
|listOwner|string|List owner: List owner tooltip| x |
|extraInfo|string|Extra info: Extra list owner context info...| x |
|columnKey|string|Column key: Unique key for column as supplied by provider metadata| x |
|columnSize|string|Size: Encoded column size| x |
|rank|int|Rank: Left to right order of active columns| x |
|orderByRank|int|Order by: If this column is used to order by, rank of sort order| x |
|orderByDirection|int|Asc/Desc: Asc/Desc order by direction if order by rank| x |
|registered|date|Registered date: Date &amp; time this record was created| x |
|updated|date|Updated date: Date &amp; time this record was last updated| x |
|ownerTable|int|Owner Table Id: Table Id of owner for a dynamic entity-bound configuration| x |
|ownerRecord|int|Owner Record Id: Record Id of owner for a dynamic entity-bound configuration| x |
|groupId|int|Group Id: Group Id tooltip| x |
|configurationName|string|Configuration name: User configuration name| x |
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
GET /api/v1/archive/SuperListColumnSize?$select=associate/assocType,groupId,associate/mrMrs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


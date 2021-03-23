---
uid: Numbers
title: Numbers
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "Numbers"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Numbers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.NumbersProviderBase">SuperOffice.CRM.ArchiveLists.NumbersProviderBase</see> inside NetServer's SODatabase assembly.

Archive provider for the list of userpreferences

Blah...
<para />
blah....
<para />
...
<para />
........

## Supported Entities
| Name | Description |
| ---- | ----- |
|"number"|[number]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|RefCounts\_id|int|ID: Primary key of counter| x |
|fieldId|int|Field ID: Referenced field ID| x |
|icon|int|Icon: Icon denoting counter type| x |
|recordId|int|Record ID: Referenced record ID| x |
|currentvalue|int|Value: Current value| x |
|travelprefix|int|Travel prefix: Prefix of Travel instance| x |
|satprefix|int|Prefix of referenced satellite| x |
|flags|int|Flags: Flags for boolean properties| x |
|active|bool|Allocate: Counter is active| x |
|unique|bool|Unique: Counter is unique| x |
|readonly|bool|Read-only: Counter is read-only| x |
|blankallowed|bool|Allow blank: Counter permits blanks| x |
|name|string|Counter: Counter name| x |
|updated|date|Last used: Last update time| x |
|nextnum|int|Next: Next number| x |
|updated\_associate/firstName|string|By - First name: Displays the contact's first name| x |
|updated\_associate/lastName|string|By - Last name: Displays the contact's last name| x |
|updated\_associate/middleName|string|By - Middle Name: Displays the contact's middle name.| x |
|updated\_associate/fullName|string|By - Full name: Displays full name of user (first, middle, last - according to settings)| x |
|updated\_associate/contactId|int|By - Company ID: Database ID of the company the user belongs to|  |
|updated\_associate/personId|int|By - Contact ID: Database ID of the contact row|  |
|updated\_associate/mrMrs|string|By - Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|updated\_associate/title|string|By - Title: Displays whether the contact is addressed as Mr or Ms| x |
|updated\_associate/associateDbId|associate|By - ID| x |
|updated\_associate/contactName|string|By - Owning company: Name of the company the user belongs to| x |
|updated\_associate/contactDepartment|string|By - Owning department: Name of the department at the company the user belongs to| x |
|updated\_associate/usergroup|userGroup|By - Primary group: The user's primary user group| x |
|updated\_associate/contactFullName|string|By - Owner: Name and department of the company the user belongs to| x |
|updated\_associate/contactCategory|listAny|By - Category: Category| x |
|updated\_associate/role|listAny|By - Role: Role| x |
|updated\_associate/assocName|associate|By - User ID: User ID| x |
|updated\_associate/assocTooltip|string|By - Description: Description|  |
|updated\_associate/assocType|listAny|By - Type: Type of user: associate, external user, system user, anonymous account| x |
|updated\_associate/ejUserId|int|By - Service user ID: The database ID of a Service user|  |
|updated\_associate/simultaneousEjUser|bool|By - Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|updated\_associate/ejDisplayName|string|By - Nick name: User's nick name in Service| x |
|updated\_associate/ejStatus|int|By - Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|updated\_associate/credentialType| *None* |By - Auth. type: What type of credentials to use when this user logs in| x |
|updated\_associate/credentialDisplayValue| *None* |By - Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|updated\_associate/isActive|bool|By - Active: Is this user active, and should be able to log in?| x |
|updated\_associate/isActiveText|bool|By - Active status: Is this user active, and should be able to log in?| x |
|updated\_associate/portraitThumbnail| *None* |By - Person image: Person image|  |
|updated\_associate/otherGroups|userGroup|By - Other groups: Other groups|  |
|updated\_associate/userName|string|By - User name: User name| x |
|updated\_associate/personEmail|string|By - E-mail| x |

## Sample

```http!
GET /api/v1/archive/Numbers?$select=updated_associate/credentialDisplayValue,updated,updated_associate/mrMrs
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


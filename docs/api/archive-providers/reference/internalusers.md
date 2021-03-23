---
uid: InternalUsers
title: InternalUsers
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "InternalUsers"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "InternalUsers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.InternalUsersProvider">SuperOffice.CRM.ArchiveLists.InternalUsersProvider</see> inside NetServer's SODatabase assembly.

Concrete provider for Internal Users - our own employees. See <see cref="T:SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
the actual functionality of the provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|
|"superoffice_admin-system-user"|[System user administrator]|
|"superoffice_admin-extern-user"|[External user administrator]|
|"superoffice_visible-for"|[Confidential activities]|
|"superoffice_reporter-studio-user"|[Reporter Studio]|
|"superoffice_outlook-synchronizer"|[Outlook Synchronizer]|
|"superoffice_admin-anonymous-user"|[Anonymous user admin]|
|"superoffice_publish"|[Publish to external]|
|"superoffice_superlicense-complete"|[Complete CRM User]|
|"superoffice_superlicense-no-selection"|[(No Selection)]|
|"superoffice_superlicense-sales-pro"|[Sales User]|
|"superoffice_superlicense-marketing-pro"|[Marketing User]|
|"potential"|Potential users|
|"retired"|Former employee|
|"loggedOnWin"|Logged-on to Windows client|
|"expired"|Expired|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userplan| *None* |User plan: User plan (licence)|  |
|canLogin|bool|Can log in: Can log in|  |
|superoffice\_admin-system-user| *None* |System user administrator: Allows user to admin system user in SOADMIN user panel.|  |
|superoffice\_admin-extern-user| *None* |External user administrator: Allows user to admin external user in CRM client|  |
|superoffice\_visible-for| *None* |Confidential activities: Enables the visible-for dropdown in the CRM client|  |
|superoffice\_reporter-studio-user| *None* |Reporter Studio: Allows user to log in to Reporter Studio.|  |
|superoffice\_outlook-synchronizer| *None* |Outlook Synchronizer: Enables Outlook client sync (??)|  |
|superoffice\_admin-anonymous-user| *None* |Anonymous user admin: Allows user to admin anonymous user in SOADMIN user panel.|  |
|superoffice\_publish| *None* |Publish to external: Enables Publish checkbox in CRM client. Requires Extern-user|  |
|superoffice\_superlicense-complete| *None* |Complete CRM User: User Plan: Can edit Companies, Diary, Project, Selections, Sales, Reports and use Customer Service|  |
|superoffice\_superlicense-no-selection| *None* |(No Selection): User Plan: License Not in Use.|  |
|superoffice\_superlicense-sales-pro| *None* |Sales User: User Plan: Can edit Companies, Diary, Project, Combi Selections, Sales, Reports|  |
|superoffice\_superlicense-marketing-pro| *None* |Marketing User: User Plan: Can edit Companies, Diary, Project, Combi Selections, Reports, eMarketing|  |
|firstName|string|First name: Displays the contact's first name| x |
|lastName|string|Last name: Displays the contact's last name| x |
|middleName|string|Middle Name : Displays the contact's middle name.| x |
|fullName|string|Full name: Displays full name of user (first, middle, last - according to settings)| x |
|contactId|int|Company ID: Database ID of the company the user belongs to|  |
|personId|int|Contact ID: Database ID of the contact row|  |
|mrMrs|string|Mr/Ms: Displays whether the contact is addressed as Mr or Ms| x |
|title|string|Title: Displays whether the contact is addressed as Mr or Ms| x |
|associateDbId|associate|ID| x |
|contactName|string|Owning company: Name of the company the user belongs to| x |
|contactDepartment|string|Owning department: Name of the department at the company the user belongs to| x |
|usergroup|userGroup|Primary group: The user's primary user group| x |
|contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactCategory|listAny|Category: Category| x |
|role|listAny|Role : Role| x |
|assocName|associate|User ID : User ID| x |
|assocTooltip|string|Description : Description|  |
|assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|ejUserId|int|Service user ID: The database ID of a Service user|  |
|simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ejDisplayName|string|Nick name: User's nick name in Service| x |
|ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|isActive|bool|Active: Is this user active, and should be able to log in?| x |
|isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|otherGroups|userGroup|Other groups: Other groups|  |
|userName|string|User name: User name| x |
|personEmail|string|E-mail| x |

## Sample

```http!
GET /api/v1/archive/InternalUsers?$select=firstName,title
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


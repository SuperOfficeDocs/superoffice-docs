---
uid: AllUsers
title: AllUsers
description: Concrete provider for all kinds of users, unfiltered. See <see cref="T -SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
keywords: AllUsers archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "AllUsers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.AllUsersProvider">SuperOffice.CRM.ArchiveLists.AllUsersProvider</see> inside NetServer's SODatabase assembly.

Concrete provider for all kinds of users, unfiltered. See <see cref="T:SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
the actual functionality of the provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|
|"superoffice_system-user-cal"|System user|
|"superoffice_admin-system-user"|System user administrator|
|"superoffice_admin-extern-user"|External user administrator|
|"superoffice_visible-for"|Confidential activities|
|"superoffice_reporter-studio-user"|Reporter Studio|
|"superoffice_admin-anonymous-user"|Anonymous user admin|
|"superoffice_publish"|Publish to external|
|"superoffice_superlicense-no-selection"|(No Selection)|
|"superoffice_ten-sales"|Sales Premium|
|"superoffice_ten-service"|Service Premium|
|"superoffice_ten-marketing"|Marketing Premium|
|"superoffice_ten-salesservicemarketing"|SalesPremiumServicePremiumMarketingPremium|
|"superoffice_outlook-synchronizer"|Outlook Synchronizer|
|"expired"|Expired|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userplan| *None* |User plan: User plan (licence)|  |
|canLogin|bool|Can log in: Can log in|  |
|superoffice\_system-user-cal| *None* |System user: Allows log in to NetServer|  |
|superoffice\_admin-system-user| *None* |System user administrator: Allows user to admin system user in SOADMIN user panel.|  |
|superoffice\_admin-extern-user| *None* |External user administrator: Allows user to admin external user in CRM client|  |
|superoffice\_visible-for| *None* |Confidential activities: Enables the visible-for dropdown in the CRM client|  |
|superoffice\_reporter-studio-user| *None* |Reporter Studio: Allows user to log in to Reporter Studio.|  |
|superoffice\_admin-anonymous-user| *None* |Anonymous user admin: Allows user to admin anonymous user in SOADMIN user panel.|  |
|superoffice\_publish| *None* |Publish to external: Enables Publish checkbox in CRM client. Requires Extern-user|  |
|superoffice\_superlicense-no-selection| *None* |No Selection: User Plan: License Not in Use.|  |
|superoffice\_ten-sales| *None* |Sales Premium: User Plan: Can edit Companies, Diary, Sales, Selections, Reports|  |
|superoffice\_ten-service| *None* |Service Premium: User Plan: Can edit Requests|  |
|superoffice\_ten-marketing| *None* |Marketing Premium: User Plan: Can send Mailings, Combined Selections|  |
|superoffice\_ten-salesservicemarketing| *None* |SalesPremiumServicePremiumMarketingPremium: User Plan: Can edit sales, requests, mailings.|  |
|superoffice\_outlook-synchronizer| *None* |Outlook Synchronizer: Enables Outlook client sync (??)|  |
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
|usergroupId|int|Group ID: The user's primary user group| x |
|contactFullName|string|Owner: Name and department of the company the user belongs to| x |
|contactCategory|listAny|Category: Category| x |
|role|listAny|Role : Role| x |
|assocName|associate|User ID : User ID| x |
|assocTooltip|string|Description : Description|  |
|assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
|ejUserId|int|Service user ID: The database ID of a Service user|  |
|simultaneousEjUser|bool|Simultaneous Service user: If this flag is set, then the user will only have access if the maximum number of simultaneous users is not exceeded|  |
|ejDisplayName|string|Nickname: User's nickname in Service| x |
|ejStatus|int|Service status: Status for Service user: Normal; Unavailable / holiday; Deleted; Read-only|  |
|credentialType| *None* |Auth. type: What type of credentials to use when this user logs in| x |
|credentialDisplayValue| *None* |Auth. value: Credential value (public, visible part) to be used when this user logs in| x |
|isActive|bool|Active: Is this user active, and should be able to log in?| x |
|isActiveText|bool|Active status: Is this user active, and should be able to log in?| x |
|portraitThumbnail| *None* |Person image: Person image|  |
|otherGroups|userGroup|Other groups: Other groups|  |
|userName|string|User name: User name| x |
|personEmail|string|E-mail| x |
|locationAddress|string|Location: Location| x |
|isLocation|bool|Is a location: Is a location| x |

## Sample

```http!
GET /api/v1/archive/AllUsers?$select=superoffice_ten-salesservicemarketing,credentialDisplayValue,superoffice_outlook-synchronizer
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


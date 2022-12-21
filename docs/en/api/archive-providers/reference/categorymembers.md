---
uid: CategoryMembers
title: CategoryMembers
description: Archive of CategoryMember - used by the web api.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "CategoryMembers"
so.generated: true
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "CategoryMembers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.CategoryMembersProvider">SuperOffice.CRM.ArchiveLists.CategoryMembersProvider</see> inside NetServer's SODatabase assembly.

Archive of CategoryMember - used by the web api.
Combines all CategoryMembers in table together with added, edited or removed through restrictions.

## Supported Entities

| Name | Description |
| ---- | ----------- |
|"existingCategoryMember"|[existingCategoryMember]|
|"newCategoryMember"|[newCategoryMember]|

## Supported Columns

| Name | Restriction | Description | OrderBy |
| ---- | ----------- | ----------- | ------- |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|addedRows|string||  |
|removedRows| *None* ||  |
|editedRows| *None* ||  |
|categoryMembershipId| *None* |ID: ID|  |
|categoryId| *None* |Category ID: Category ID|  |
|weight|int|Weight: Weight| x |
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
GET /api/v1/archive/CategoryMembers?$select=contactId,usergroup
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>

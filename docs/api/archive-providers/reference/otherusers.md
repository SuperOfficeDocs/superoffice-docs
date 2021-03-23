---
uid: OtherUsers
title: OtherUsers
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "OtherUsers"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "OtherUsers"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.OtherUsersProvider">SuperOffice.CRM.ArchiveLists.OtherUsersProvider</see> inside NetServer's SODatabase assembly.

Concrete provider for 'Other' Users - System and Anonymous user accounts. See <see cref="T:SuperOffice.CRM.ArchiveLists.UsersProviderBase" /> for
the actual functionality of the provider.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"all"|All|
|"superoffice_system-user-cal"|[System user]|
|"expired"|Expired|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|userplan| *None* |User plan: User plan (licence)|  |
|canLogin|bool|Can log in: Can log in|  |
|superoffice\_system-user-cal| *None* |System user: Allows log in to NetServer|  |
|associateDbId|associate|ID| x |
|role|listAny|Role : Role| x |
|assocName|associate|User ID : User ID| x |
|assocTooltip|string|Description : Description|  |
|assocType|listAny|Type: Type of user: associate, external user, system user, anonymous account| x |
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
GET /api/v1/archive/OtherUsers?$select=role,assocType
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


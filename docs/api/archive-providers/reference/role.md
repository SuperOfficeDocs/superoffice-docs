---
uid: Role
title: Role
description: Archive of Roles  - used by the web api.
Lists all Roles in table.
keywords:
  - "archive"
  - "provider"
  - "archive provider"
so.generated: true
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "Role"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.RoleProvider">SuperOffice.CRM.ArchiveLists.RoleProvider</see> inside NetServer's SODatabase assembly.

Archive of Roles  - used by the web api.
Lists all Roles in table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"role"|[role]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|roleId|int|RoleId| x |
|name|string|Role name | x |
|description|string|Description| x |
|roleTypeId|int|Role Type Id| x |
|roleTypeName| *None* |Role Type|  |
|useCategories|bool|Use Categories| x |
|rank|int|Rank| x |
|isDeleted|bool|Is Deleted| x |
|updatedBy|associate|Updated by: The user who last updated the data| x |
|updatedDate|date|Updated: The date/time the data was last updated in UTC.| x |
|registeredBy|associate|Registered by: The user who registered the data| x |
|registeredDate|date|Registered date: The date/time the data was registered in UTC.| x |

## Sample

```http!
GET /api/v1/archive/Role?$select=description,useCategories
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


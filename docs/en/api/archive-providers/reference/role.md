---
uid: Role
title: Role
description: Archive of Roles  - used by the web api.
keywords: Role archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "Role"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.RoleProvider">SuperOffice.CRM.ArchiveLists.RoleProvider</see> inside NetServer's SODatabase assembly.

Archive of Roles  - used by the web api.
Lists all Roles in table.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"role"|role|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|roleId|int|RoleId| x |
|name|string|SR\_ADMIN\_ROLE\_ROLENAME| x |
|description|string|Description| x |
|roleTypeId|int|Role Type Id| x |
|roleTypeName| *None* |Role Type|  |
|useCategories|bool|Use Categories| x |
|rank|int|Rank| x |
|isDeleted|bool|Is Deleted| x |
|updatedBy|associate|SR\_UPDATEDASSOC: SR\_UPDATEDASSOC\_TOOLTIP| x |
|updatedDate|date|SR\_UPDATEDDATE: SR\_UPDATEDDATE\_TOOLTIP| x |
|registeredBy|associate|SR\_REGISTEREDASSOC: SR\_REGISTEREDASSOC\_TOOLTIP| x |
|registeredDate|date|SR\_REGISTEREDDATE: SR\_REGISTEREDDATE\_TOOLTIP| x |

## Sample

```http!
GET /api/v1/archive/Role?$select=description,useCategories
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


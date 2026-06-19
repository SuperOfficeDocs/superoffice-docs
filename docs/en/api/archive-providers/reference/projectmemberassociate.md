---
uid: ProjectMemberAssociate
title: ProjectMemberAssociate
description: 
keywords: ProjectMemberAssociate archive provider
generated: true
content_type: reference
envir: onsite, online
---

# "ProjectMemberAssociate"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProjectMemberAssociateProvider">SuperOffice.CRM.ArchiveLists.ProjectMemberAssociateProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ProjectMember"|ProjectMember|
|"hideConflict"|[[SR_HIDE_CONFLICT]]|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|conflictStatus| *None* |SR\_BOOKING\_CONFLICT: SR\_BOOKING\_CONFLICT\_TOOLTIP|  |
|function|listAny|SR\_PROJECTMEMBERARCHIVE\_FUNCTION: SR\_PROJECTMEMBERARCHIVE\_FUNCTION\_TOOLTIP| x |
|fullName|string|SR\_ACTIVITYARCHIVE\_PERSON: SR\_ACTIVITYARCHIVE\_PERSON\_TOOLTIP| x |
|nameDepartment|string|SR\_ACTIVITYARCHIVE\_CONTACT: SR\_ACTIVITYARCHIVE\_CONTACT\_TOOLTIP| x |
|projectId|int|SR\_PROJECT\_ID: SR\_PROJECT\_ID| x |

## Sample

```http!
GET /api/v1/archive/ProjectMemberAssociate?$select=conflictStatus,function
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```

See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


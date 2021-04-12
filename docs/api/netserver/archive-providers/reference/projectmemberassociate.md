---
uid: ProjectMemberAssociate
title: ProjectMemberAssociate
description: 
keywords:
  - "archive"
  - "provider"
  - "archive provider"
  - "ProjectMemberAssociate"
so.generated: true
so.date: 23.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# "ProjectMemberAssociate"

This provider name is implemented by the class <see cref="T:SuperOffice.CRM.ArchiveLists.ProjectMemberAssociateProvider">SuperOffice.CRM.ArchiveLists.ProjectMemberAssociateProvider</see> inside NetServer's SODatabase assembly.

## Supported Entities
| Name | Description |
| ---- | ----- |
|"ProjectMember"|[ProjectMember]|
|"hideConflict"|Hide conflict|

## Supported Columns
| Name | Restriction | Description | OrderBy
| ---- | ----- | ------- | ------ |
|getAllRows|bool|GetAll: Get all rows of archive - use with care, you may be fetching the whole database|  |
|getNoRows|bool|GetNone: Do not get any rows from the archive|  |
|conflictStatus| *None* |Status: Shows any conflicts with other follow-ups|  |
|function|listAny|Function: Displays the project member's function in the project| x |
|fullName|stringorPK|Contact: Displays the contact to which an item is linked| x |
|nameDepartment| *None* |Company: Displays the company an activity is linked to| x |
|projectId|int|Project ID: Project ID| x |

## Sample

```http!
GET /api/v1/archive/ProjectMemberAssociate?$select=conflictStatus,function
Authorization: Basic dGplMDpUamUw
Accept: application/json; charset=utf-8
Accept-Language: sv

```



See also: <see cref="T:SuperOffice.CRM.Services.IArchiveAgent">IArchiveAgent</see>.</p>


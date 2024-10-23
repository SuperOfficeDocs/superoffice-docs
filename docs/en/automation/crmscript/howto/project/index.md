---
uid: crmscript-project
title: Projects
description: Working with projects in CRMScript
keywords: project, project management, CRMScript
author: Bergfrid Dias
date: 05.31.2023
version: 9
topic: howto
---

# Projects

[!include[License requirement](../../../../../../common/includes/req-for-project-mgt.md)]

## CRMScript classes

There are no native CRMScript classes pertaining to projects. Use the NetServer classes:

* [NSProjectAgent][10]
* [NSProject][11]
* [NSProjectEntity][12]
* [NSProjectMember][13]
* [NSProjectStatus][14]
* [NSProjectType][15]

## Frequently used fields

| Field | Description |
|:--|:--|
| project_id | ID |
| name | name of project |
| associate_id | project manager or owner |
| type_idx | type of project |
| status_idx | status |
| done | 0 = no, 1 = yes |

For a complete list of fields, see the [database reference][7].

## Status of a project

| Status | Description |
|-|---|
| 1 | Planned |
| 2 | In progress |
| 3 | Completed |
| 4 | Stopped |
| 5 | Closing |

## Timestamp values

| Field | Description |
|:--|:--|
| registered | UtcDateTime of registration |
| updated | UtcDateTime of last update |
| endDate | Expected closing time or when it was completed or stopped (DateTime) |
| nextMilestoneDate | Closest non-complete future milestone activity (DateTime) |

## How-tos and examples

* [Create project][2]
* [Get project][1]
* [Update project][5]
* [Work with a project guide][4]
* [Manage project members][3]
* [Various samples][6]

<!-- Referenced links -->
[1]: get.md
[2]: create.md
[3]: members.md
[4]: guides.md
[5]: update.md
[6]: samples.md
[7]: ../../../../database/tables/project.md
[10]: ../../reference/CRMScript.NetServer.NSProjectAgent.yml
[11]: ../../reference/CRMScript.NetServer.NSProject.yml
[12]: ../../reference/CRMScript.NetServer.NSProjectEntity.yml
[13]: ../../reference/CRMScript.NetServer.NSProjectMember.yml
[14]: ../../reference/CRMScript.NetServer.NSProjectStatus.yml
[15]: ../../reference/CRMScript.NetServer.NSProjectType.yml

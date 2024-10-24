---
title: Projects
uid: project-overview
description: Working with projects
author: Bergfrid Dias
date: 05.31.2023
keywords: project, project management
topic: concept
# envir:
# client:
---

# Projects

[!include[License requirement](../../../common/includes/req-for-project-mgt.md)]

![Project card -screenshot][img1]

A project typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to completing the project.

## Key info

* A unique ID
* A name
* A project manager or owner
* Project members
* The type of project
* A status
* Milestones
* An (expected) end date

## Project members

A project always has a project manager or owner. In addition, it can have (and usually has) project members. These are stored in the [projectmember table][5].

Deleting project members doesn't delete the actual person. It only severs the link between the person and the project by removing the row from the database table. For example, a person has retired from the company and you need to clean up the database.

## Project guides

Using a guide will simplify and structure the process for the project manager with suggestions for which follow-ups to do and which documents to create at each stage.

![Project guide -screenshot][img2]

## Project type

A *project type* is a named set of reuseable info that will help you standardize the process. Aside from the name and ID, you'll find info such as:

* The expected duration
* Whether a project guide is available
* Stages

Some project types have an associated project guide. For those types, it's important to understand stages and how to work with suggested activities.

## Stages

Each stage has a set of **suggested activities**. There is also a setting controlling whether the project will automatically advance to the next stage when the last guided activity in a stage is completed.

The sequence of the stages is determined by the **rank** of each stage.

## Suggested activities

Suggested activities are just that  - **suggested**. They're blueprints that can be used to create actual follow-ups and documents.

The blueprints sit at the intersection between project types and stages. A project type can have many stages, and a stage can apply to multiple project types. The [ProjectTypeStatusLink table][4] connects them all.

## Howtos

* [Project management in the UI][1]
* [Using CRMScript][3]
* [Using raq SQL][2]

## Projects vs. other entities

When working with projects, data will often intersect with the following entities:

* [Company][14] (contact table)
* [Contact][15] (person table)
* [Documents][12]
* [Follow-ups][13] (appointment table)
* [Sales][16]

<!-- Referenced links -->
[1]: learn/index.md
[2]: howto/sql/index.md
[3]: ../automation/crmscript/howto/project/index.md
[4]: ../database/tables/projecttypestatuslink.md
[5]: ../database/tables/projectmember.md
[12]: ../document/index.yml
[13]: ../diary/index.yml
[14]: ../company/index.yml
[15]: ../contact/index.yml
[16]: ../sale/index.yml

<!-- Referenced images -->
[img1]: media/project.png
[img2]: media/project-guide.png

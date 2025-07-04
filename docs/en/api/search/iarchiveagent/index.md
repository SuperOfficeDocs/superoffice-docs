---
title: Archive agents
uid: archive_agents
description: Archive agents
author: SuperOffice Product and Engineering
keywords: 
content_type: concept
date:
category: 
area: api-services
---

# Archive agents

Archives are tables of rows and columns that contain de-normalized and processed data relating to Persons, Activities, Projects, and many more.

## Required namespaces

* SuperOffice.CRM.Services
* SuperOffice.CRM.ArchiveLists
* SuperOffice.CRM.Archives

## Agents

* [IArchiveAgent][1]

## Activity archive

Activity Archive is unique compared to the other archives provided by NetServer since it merges Appointments, Documents, and Sales into one archive. The filter applies only to `ContactActivityArchiveProvider` and to `ProjectActivityArchiveProvider`. These providers make use of the filter setting when building the query that is used when retrieving the data from the database.

It should be noted that specific archive providers such as `Sales` do not make use of the filter settings since they assume that the outer archive class either the `ContactActivityArchiveProvider` or `ProjectActivityArchiveProvider` takes care of it.

<!-- Referenced links -->
[1]: iarchiveagent.md

---
title: archive_agents       
description: Archive agents
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: concept                # article, howto, reference, concept, guide
so.date:
so.category: 
so.area: api-services

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
